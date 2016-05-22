using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Text;
using System.Diagnostics;


// to do
// provide an event on the hover.
//   on mousemove, 
namespace RegexTest
{
	public enum HoverState
	{
		Ready,
		InHover,
		AfterClick
	}

	public class HoverEventArgs: EventArgs
	{
		int characterOffset;

		public HoverEventArgs(int characterOffset)
		{
			this.characterOffset = characterOffset;
		}

		public int CharacterOffset
		{
			get
			{
				return characterOffset;
			}
		}
	}

	public class HoverDetailAction
	{
		int highlightStart;
		int highlightLength;
		string tooltipText;

		public HoverDetailAction(int highlightStart, int highlightLength, string tooltipText)
		{
			this.highlightStart = highlightStart;
			this.highlightLength = highlightLength;
			this.tooltipText = tooltipText;
		}

		public int HighlightStart
		{
			get
			{
				return highlightStart;
			}
		}

		public int HighlightLength
		{
			get
			{
				return highlightLength;
			}
		}
		
		public string TooltipText
		{
			get
			{
				return tooltipText;
			}
		}

	}

	public delegate HoverDetailAction HoverDetailEventHandler(object sender, HoverEventArgs args);


	/// <summary>
	/// A textbox that has advanced hovering support. 
	/// </summary>
	public class TextBoxHoverable : System.Windows.Forms.TextBox
	{
		Graphics g = null;
		MouseEventArgs lastLocation;
		private System.Windows.Forms.Timer hoverTimer;
		private System.ComponentModel.IContainer components;
		SizeF characterSize;		// estimated character size
		HoverState hoverState = HoverState.Ready;
		int mouseMoveIgnore = 0;
		HoverTooltip hoverTooltip = new HoverTooltip();

		public event HoverDetailEventHandler HoverDetail;

        public TextBoxHoverable()
		{
			InitializeComponent();
		}

		protected override void OnMouseMove(MouseEventArgs args)
		{
			if (args.Button == MouseButtons.None)
			{
				if (mouseMoveIgnore > 0)
				{
					mouseMoveIgnore--;
					return;
				}
				lastLocation = args;

				if (hoverState == HoverState.InHover)
				{
					DoHover();
				}
				else
				{
					try
					{
						hoverTimer.Enabled = false;
						hoverTimer.Enabled = true;
						hoverTimer.Start();
						hoverState = HoverState.Ready;
					}
					catch (InvalidOperationException)
					{
						// eat this here...
					}
				}
			}

			base.OnMouseMove(args);
		}

		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.hoverTimer = new System.Windows.Forms.Timer(this.components);
			// 
			// hoverTimer
			// 
			this.hoverTimer.Tick += new System.EventHandler(this.hoverTimer_Tick);

		}

		protected override void OnPaint(PaintEventArgs pe)
		{
			// TODO: Add custom paint code here

			// Calling the base class OnPaint
			base.OnPaint(pe);
		}

		private void hoverTimer_Tick(object sender, System.EventArgs e)
		{
			DoHover();
		}

		private void DoHover()
		{
				// if the user has clicked and hasn't moved the mouse, 
				// don't do anything...
			if (hoverState == HoverState.AfterClick)
				return;

			hoverTimer.Enabled = false;

				// first time - create the Graphics object, and get the
				// height of the characters...
			if (g == null)
			{
				g = Graphics.FromHwnd(this.Handle);
				characterSize = g.MeasureString("X", Font);
			}

				// Figure out what character we're hovering over. 
				// Start by identifying the line

			int line = (int) (lastLocation.Y / characterSize.Height);
			if (line >= Lines.Length)
			{
				DoneHover();
				return;
			}

			// Do this with a brute-force algorithm, by measuring
			// the string until we find the character that puts us
			// to the right of the mouse location.

			string s = Lines[line];
			SizeF size = g.MeasureString(s, Font);
			if (lastLocation.X > size.Width)	// past end of line
			{
				DoneHover();
				return;
			}

			while (size.Width > lastLocation.X)
			{
				s = s.Substring(0, s.Length - 1);
				size = g.MeasureString(s, Font);
			}

				// figure out the character offset for this line...
			int offset = 0;
			for (int lineIndex = 0; lineIndex < line; lineIndex++)
			{
				offset += Lines[lineIndex].Length + 2;	// add 2 to cover /r/n at the end of each line
			}

			HoverDetailAction action = OnHoverDetail(s.Length + offset);
			if (action != null)
			{
				this.SelectionStart = action.HighlightStart;
				this.SelectionLength = action.HighlightLength;
				if (SelectionLength < 0)
					SelectionLength = 0;
				
				hoverTooltip.WindowText = action.TooltipText;
				
				hoverTooltip.Location = 
					PointToScreen(new Point(50, 
					                        (int) (Font.Height * (line + 2))));
				hoverTooltip.Show();
				Debug.WriteLine(action.TooltipText);
				if (!Focused)
				{
					Focus();
				}
				hoverState = HoverState.InHover;
			}

			hoverTimer.Enabled = false;
		}

		protected override void OnClick(EventArgs e)
		{
			hoverTimer.Enabled = false;
			hoverState = HoverState.AfterClick;
			hoverTooltip.Hide();
			mouseMoveIgnore = 1;
			base.OnClick(e);
		}

		void DoneHover()
		{
			if (hoverState == HoverState.InHover)
			{
				hoverTooltip.Hide();
				this.SelectionLength = 0;
				hoverState = HoverState.Ready;
				hoverTimer.Enabled = false;
			}
		}

		protected override void OnLostFocus(EventArgs e)
		{
			DoneHover();
			base.OnLostFocus(e);
		}

		protected HoverDetailAction OnHoverDetail(int offset)
		{
			if (HoverDetail != null)
			{
				return HoverDetail(this, new HoverEventArgs(offset));
			}
			return null;
		}

		protected override void OnLeave(EventArgs e)
		{
			DoneHover();
			base.OnMouseLeave(e);
		}

		protected override void OnMouseLeave(EventArgs e)
		{
			DoneHover();
			base.OnMouseLeave(e);
		}
	}
}
