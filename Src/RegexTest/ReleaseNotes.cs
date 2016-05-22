using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace RegexTest
{
	/// <summary>
	/// Summary description for ReleaseNotes.
	/// </summary>
	public class ReleaseNotes : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label labelNotes;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ReleaseNotes()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			this.labelNotes.Text =
				@"7/3/2003 V2.0

Lots of changes in this version:
1) The UI is revised, with a real menu
2) Regexes can be saved into a library, and then easily reloaded
3) A description can now be associated with a regex
4) Support for calling Regex.Replace() has been added.
5) A match evalutor function can be written in the tool
6) Added unit tests for the interpretation function, and fixed several bugs. NUnit is now required.
";

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.labelNotes = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// labelNotes
			// 
			this.labelNotes.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelNotes.Location = new System.Drawing.Point(8, 8);
			this.labelNotes.Name = "labelNotes";
			this.labelNotes.Size = new System.Drawing.Size(976, 568);
			this.labelNotes.TabIndex = 0;
			this.labelNotes.Text = "asjdfjasjdf as fjas fajsfjas fjd jasfjajfdjasjfjasjfasdf asjf as fasj fjasf";
			// 
			// ReleaseNotes
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(992, 586);
			this.Controls.Add(this.labelNotes);
			this.Name = "ReleaseNotes";
			this.Text = "ReleaseNotes";
			this.ResumeLayout(false);

		}
		#endregion

	}
}
