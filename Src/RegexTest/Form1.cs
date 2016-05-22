using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using System.Reflection;
using Timing;

namespace RegexTest
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox Strings;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox Output;
		private System.Windows.Forms.CheckBox IgnoreWhitespace;
		private System.Windows.Forms.CheckBox IgnoreCase;
		private System.Windows.Forms.CheckBox Compiled;
		private System.Windows.Forms.CheckBox ExplicitCapture;
		private System.Windows.Forms.CheckBox Singleline;
		private System.Windows.Forms.CheckBox Multiline;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox Elapsed;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox Iterations;
		private System.Windows.Forms.Button Interpret;
		private System.Windows.Forms.Button Split;
		private TextBoxHoverable RegexText;
		private System.Windows.Forms.TextBox CompileTime;
		private System.Windows.Forms.Label label33;
		private System.Windows.Forms.CheckBox OneString;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuItem8;
		private System.Windows.Forms.MenuItem menuItem9;
		private System.Windows.Forms.MenuItem menuItem10;
		private System.Windows.Forms.MenuItem menuItem11;
		private System.Windows.Forms.MenuItem menuItem12;
		private System.Windows.Forms.MenuItem menuItem13;
		private System.Windows.Forms.MenuItem menuItem14;
		private System.Windows.Forms.MenuItem menuItem15;
		private System.Windows.Forms.MenuItem menuItem16;
		private System.Windows.Forms.MenuItem menuItem17;
		private System.Windows.Forms.MenuItem menuItem18;
		private System.Windows.Forms.MenuItem menuItem19;
		private System.Windows.Forms.MenuItem menuItem20;
		private System.Windows.Forms.MenuItem menuItem21;
		private System.Windows.Forms.MenuItem menuItem22;
		private System.Windows.Forms.MenuItem menuItem23;
		private System.Windows.Forms.MenuItem menuItem24;
		private System.Windows.Forms.MenuItem menuItem25;
		private System.Windows.Forms.MenuItem menuItem26;
		private System.Windows.Forms.MenuItem menuItem27;
		private System.Windows.Forms.MenuItem menuItem28;
		private System.Windows.Forms.MenuItem menuItem29;
		private System.Windows.Forms.MenuItem menuItem30;
		private System.Windows.Forms.MenuItem menuItem31;
		private System.Windows.Forms.MenuItem menuItem32;
		private System.Windows.Forms.MenuItem menuItem33;
		private System.Windows.Forms.MenuItem menuItem34;
		private System.Windows.Forms.MenuItem menuItem35;
		private System.Windows.Forms.MenuItem menuItem36;
		private System.Windows.Forms.MenuItem menuItem37;
		private System.Windows.Forms.MenuItem menuItem38;
		private System.Windows.Forms.MenuItem menuItem39;
		private System.Windows.Forms.MenuItem menuItem40;
		private System.Windows.Forms.MenuItem menuItem41;
		private System.Windows.Forms.MenuItem menuItem42;
		private System.Windows.Forms.MenuItem menuItem43;
		private System.Windows.Forms.MenuItem menuItem44;
		private System.Windows.Forms.MenuItem menuItem45;
		private System.Windows.Forms.MenuItem menuItem46;
		private System.Windows.Forms.MenuItem menuItem47;
		private System.Windows.Forms.MenuItem menuItem48;
		private System.Windows.Forms.MenuItem menuItem49;
		private System.Windows.Forms.MenuItem menuItem50;
		private System.Windows.Forms.MenuItem menuItem51;
		private System.Windows.Forms.MenuItem menuItem52;
		private System.Windows.Forms.MenuItem menuItem53;
		private System.Windows.Forms.MenuItem menuItem54;
		private System.Windows.Forms.MenuItem menuItem56;
		private System.Windows.Forms.MenuItem menuItem55;
		private System.Windows.Forms.MenuItem menuItem57;
		private System.Windows.Forms.MenuItem menuItem58;
		private System.Windows.Forms.MenuItem menuItem59;
		private System.Windows.Forms.MenuItem menuItem60;
		private System.Windows.Forms.MenuItem menuItem61;
		private System.Windows.Forms.MenuItem menuItem62;
		private System.Windows.Forms.MenuItem menuItem63;
		private System.Windows.Forms.MenuItem menuItem64;
		private System.Windows.Forms.MenuItem menuItem65;
		private System.Windows.Forms.MenuItem menuItem66;
		private System.Windows.Forms.MenuItem menuItem67;
		private System.Windows.Forms.MenuItem BackReferenceMenuItem;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.MenuItem menuItem68;
		private System.Windows.Forms.MenuItem menuItem69;

		int regexInsertionPoint = -1;
		RegexBuffer buffer = null;
		MouseEventArgs lastLocation;
		SizeF characterSize;
		private System.Windows.Forms.CheckBox HoverInterpret;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem70;
		private System.Windows.Forms.MenuItem addItem;
		private System.Windows.Forms.MenuItem menuItem73;
		private System.Windows.Forms.MenuItem copyAsCSharp;
		private System.Windows.Forms.MenuItem copyAsVB;
		private System.Windows.Forms.MenuItem pasteFromCSharp;
		private System.Windows.Forms.MenuItem library;
		private System.Windows.Forms.MenuItem about;
		private System.Windows.Forms.MenuItem makeAssemblyItem;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.MenuItem saveRegex;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox Description;
		bool bufferDirty = true;
		private System.Windows.Forms.CheckBox HideGroupZero;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.MenuItem undoMenuItem;
		private System.Windows.Forms.MenuItem menuItem72;
		private System.Windows.Forms.MenuItem cutMenuItem;
		private System.Windows.Forms.MenuItem copyMenuItem;
		private System.Windows.Forms.MenuItem pasteMenuItem;
		private System.Windows.Forms.MenuItem deleteMenuItem;
		private System.Windows.Forms.MenuItem menuItem78;
		private System.Windows.Forms.MenuItem selectAllMenuItem;
		private System.Windows.Forms.MenuItem menuItem80;
		string currentDirectory = System.Environment.CurrentDirectory;

		MenuItem contextMenuAddItems = null;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox ReplaceString;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Panel panel9;
		private System.Windows.Forms.Button Replace;
		private System.Windows.Forms.CheckBox MatchEvaluator;
		private System.Windows.Forms.MenuItem menuItem71;
		private System.Windows.Forms.MenuItem menuReleaseNotes;
		MenuItem contextMenuBackreferences = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			EventHandler menuHandler = new System.EventHandler(this.addItem_Click);
			foreach (MenuItem mainItem in this.addItem.MenuItems)
			{
				foreach (MenuItem subItem in mainItem.MenuItems)
				{
					subItem.Click += menuHandler;
				}
			}

				// create the context menu for the regex box. To get
				// the ordering we want, we have to create a new context
				// menu, clone over the add items menu items, and then
				// copy over the ones from the orignal context menu
			ContextMenu newContextMenu = new ContextMenu();
			contextMenuAddItems = addItem.CloneMenu();
			newContextMenu.MenuItems.Add(contextMenuAddItems);
			foreach (MenuItem contextItem in contextMenu1.MenuItems)
			{
				newContextMenu.MenuItems.Add(contextItem.CloneMenu());
			}
			RegexText.ContextMenu = newContextMenu;

				// Find backreferences entry so we can use it for later
				// fixups...
			foreach (MenuItem subItem in contextMenuAddItems.MenuItems)
			{
				if (subItem.Text.IndexOf("Backreference") != -1)
				{
					this.contextMenuBackreferences = subItem;
				}
			}
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.RegexText = new RegexTest.TextBoxHoverable();
			this.contextMenu1 = new System.Windows.Forms.ContextMenu();
			this.menuItem80 = new System.Windows.Forms.MenuItem();
			this.undoMenuItem = new System.Windows.Forms.MenuItem();
			this.menuItem72 = new System.Windows.Forms.MenuItem();
			this.cutMenuItem = new System.Windows.Forms.MenuItem();
			this.copyMenuItem = new System.Windows.Forms.MenuItem();
			this.pasteMenuItem = new System.Windows.Forms.MenuItem();
			this.deleteMenuItem = new System.Windows.Forms.MenuItem();
			this.menuItem78 = new System.Windows.Forms.MenuItem();
			this.selectAllMenuItem = new System.Windows.Forms.MenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.Strings = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.IgnoreWhitespace = new System.Windows.Forms.CheckBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.Output = new System.Windows.Forms.TextBox();
			this.IgnoreCase = new System.Windows.Forms.CheckBox();
			this.Compiled = new System.Windows.Forms.CheckBox();
			this.ExplicitCapture = new System.Windows.Forms.CheckBox();
			this.Singleline = new System.Windows.Forms.CheckBox();
			this.Multiline = new System.Windows.Forms.CheckBox();
			this.label4 = new System.Windows.Forms.Label();
			this.Elapsed = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.Iterations = new System.Windows.Forms.TextBox();
			this.Interpret = new System.Windows.Forms.Button();
			this.Split = new System.Windows.Forms.Button();
			this.CompileTime = new System.Windows.Forms.TextBox();
			this.label33 = new System.Windows.Forms.Label();
			this.OneString = new System.Windows.Forms.CheckBox();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.menuItem7 = new System.Windows.Forms.MenuItem();
			this.menuItem8 = new System.Windows.Forms.MenuItem();
			this.menuItem9 = new System.Windows.Forms.MenuItem();
			this.menuItem10 = new System.Windows.Forms.MenuItem();
			this.menuItem11 = new System.Windows.Forms.MenuItem();
			this.menuItem12 = new System.Windows.Forms.MenuItem();
			this.menuItem13 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItem14 = new System.Windows.Forms.MenuItem();
			this.menuItem15 = new System.Windows.Forms.MenuItem();
			this.menuItem68 = new System.Windows.Forms.MenuItem();
			this.menuItem16 = new System.Windows.Forms.MenuItem();
			this.menuItem17 = new System.Windows.Forms.MenuItem();
			this.menuItem18 = new System.Windows.Forms.MenuItem();
			this.menuItem19 = new System.Windows.Forms.MenuItem();
			this.menuItem20 = new System.Windows.Forms.MenuItem();
			this.menuItem21 = new System.Windows.Forms.MenuItem();
			this.menuItem22 = new System.Windows.Forms.MenuItem();
			this.menuItem23 = new System.Windows.Forms.MenuItem();
			this.menuItem24 = new System.Windows.Forms.MenuItem();
			this.menuItem25 = new System.Windows.Forms.MenuItem();
			this.menuItem26 = new System.Windows.Forms.MenuItem();
			this.menuItem27 = new System.Windows.Forms.MenuItem();
			this.menuItem28 = new System.Windows.Forms.MenuItem();
			this.menuItem29 = new System.Windows.Forms.MenuItem();
			this.menuItem69 = new System.Windows.Forms.MenuItem();
			this.menuItem30 = new System.Windows.Forms.MenuItem();
			this.menuItem31 = new System.Windows.Forms.MenuItem();
			this.menuItem32 = new System.Windows.Forms.MenuItem();
			this.menuItem33 = new System.Windows.Forms.MenuItem();
			this.menuItem34 = new System.Windows.Forms.MenuItem();
			this.menuItem35 = new System.Windows.Forms.MenuItem();
			this.menuItem36 = new System.Windows.Forms.MenuItem();
			this.menuItem37 = new System.Windows.Forms.MenuItem();
			this.menuItem38 = new System.Windows.Forms.MenuItem();
			this.menuItem39 = new System.Windows.Forms.MenuItem();
			this.menuItem40 = new System.Windows.Forms.MenuItem();
			this.menuItem41 = new System.Windows.Forms.MenuItem();
			this.menuItem42 = new System.Windows.Forms.MenuItem();
			this.menuItem43 = new System.Windows.Forms.MenuItem();
			this.menuItem44 = new System.Windows.Forms.MenuItem();
			this.menuItem45 = new System.Windows.Forms.MenuItem();
			this.menuItem46 = new System.Windows.Forms.MenuItem();
			this.menuItem47 = new System.Windows.Forms.MenuItem();
			this.menuItem53 = new System.Windows.Forms.MenuItem();
			this.menuItem48 = new System.Windows.Forms.MenuItem();
			this.menuItem49 = new System.Windows.Forms.MenuItem();
			this.menuItem50 = new System.Windows.Forms.MenuItem();
			this.menuItem51 = new System.Windows.Forms.MenuItem();
			this.menuItem52 = new System.Windows.Forms.MenuItem();
			this.menuItem54 = new System.Windows.Forms.MenuItem();
			this.menuItem55 = new System.Windows.Forms.MenuItem();
			this.menuItem56 = new System.Windows.Forms.MenuItem();
			this.menuItem57 = new System.Windows.Forms.MenuItem();
			this.menuItem58 = new System.Windows.Forms.MenuItem();
			this.menuItem59 = new System.Windows.Forms.MenuItem();
			this.menuItem60 = new System.Windows.Forms.MenuItem();
			this.menuItem61 = new System.Windows.Forms.MenuItem();
			this.menuItem62 = new System.Windows.Forms.MenuItem();
			this.menuItem63 = new System.Windows.Forms.MenuItem();
			this.menuItem64 = new System.Windows.Forms.MenuItem();
			this.menuItem65 = new System.Windows.Forms.MenuItem();
			this.menuItem66 = new System.Windows.Forms.MenuItem();
			this.menuItem67 = new System.Windows.Forms.MenuItem();
			this.BackReferenceMenuItem = new System.Windows.Forms.MenuItem();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.HoverInterpret = new System.Windows.Forms.CheckBox();
			this.Description = new System.Windows.Forms.TextBox();
			this.HideGroupZero = new System.Windows.Forms.CheckBox();
			this.ReplaceString = new System.Windows.Forms.TextBox();
			this.Replace = new System.Windows.Forms.Button();
			this.MatchEvaluator = new System.Windows.Forms.CheckBox();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem70 = new System.Windows.Forms.MenuItem();
			this.saveRegex = new System.Windows.Forms.MenuItem();
			this.makeAssemblyItem = new System.Windows.Forms.MenuItem();
			this.menuItem73 = new System.Windows.Forms.MenuItem();
			this.copyAsCSharp = new System.Windows.Forms.MenuItem();
			this.copyAsVB = new System.Windows.Forms.MenuItem();
			this.pasteFromCSharp = new System.Windows.Forms.MenuItem();
			this.addItem = new System.Windows.Forms.MenuItem();
			this.library = new System.Windows.Forms.MenuItem();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.about = new System.Windows.Forms.MenuItem();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.label7 = new System.Windows.Forms.Label();
			this.panel7 = new System.Windows.Forms.Panel();
			this.panel8 = new System.Windows.Forms.Panel();
			this.panel9 = new System.Windows.Forms.Panel();
			this.menuItem71 = new System.Windows.Forms.MenuItem();
			this.menuReleaseNotes = new System.Windows.Forms.MenuItem();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel8.SuspendLayout();
			this.SuspendLayout();
			// 
			// RegexText
			// 
			this.RegexText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.RegexText.ContextMenu = this.contextMenu1;
			this.RegexText.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.RegexText.Location = new System.Drawing.Point(144, 32);
			this.RegexText.Multiline = true;
			this.RegexText.Name = "RegexText";
			this.RegexText.Size = new System.Drawing.Size(856, 184);
			this.RegexText.TabIndex = 0;
			this.RegexText.Text = "\\((?<AreaCode>\\d{3})\\)";
			this.RegexText.Leave += new System.EventHandler(this.RegexText_Leave);
			this.RegexText.HoverDetail += new RegexTest.HoverDetailEventHandler(this.RegexText_HoverDetail);
			this.RegexText.TextChanged += new System.EventHandler(this.RegexText_TextChanged_1);
			this.RegexText.Enter += new System.EventHandler(this.RegexText_Enter);
			// 
			// contextMenu1
			// 
			this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.menuItem80,
																						 this.undoMenuItem,
																						 this.menuItem72,
																						 this.cutMenuItem,
																						 this.copyMenuItem,
																						 this.pasteMenuItem,
																						 this.deleteMenuItem,
																						 this.menuItem78,
																						 this.selectAllMenuItem});
			this.contextMenu1.Popup += new System.EventHandler(this.contextMenu1_Popup);
			// 
			// menuItem80
			// 
			this.menuItem80.Index = 0;
			this.menuItem80.Text = "----";
			// 
			// undoMenuItem
			// 
			this.undoMenuItem.Index = 1;
			this.undoMenuItem.Text = "Undo";
			this.undoMenuItem.Click += new System.EventHandler(this.undoMenuItem_Click);
			// 
			// menuItem72
			// 
			this.menuItem72.Index = 2;
			this.menuItem72.Text = "-------";
			// 
			// cutMenuItem
			// 
			this.cutMenuItem.Index = 3;
			this.cutMenuItem.Text = "Cut";
			this.cutMenuItem.Click += new System.EventHandler(this.cutMenuItem_Click);
			// 
			// copyMenuItem
			// 
			this.copyMenuItem.Index = 4;
			this.copyMenuItem.Text = "Copy";
			this.copyMenuItem.Click += new System.EventHandler(this.copyMenuItem_Click);
			// 
			// pasteMenuItem
			// 
			this.pasteMenuItem.Index = 5;
			this.pasteMenuItem.Text = "Paste";
			this.pasteMenuItem.Click += new System.EventHandler(this.pasteMenuItem_Click);
			// 
			// deleteMenuItem
			// 
			this.deleteMenuItem.Index = 6;
			this.deleteMenuItem.Text = "Delete";
			this.deleteMenuItem.Click += new System.EventHandler(this.deleteMenuItem_Click);
			// 
			// menuItem78
			// 
			this.menuItem78.Index = 7;
			this.menuItem78.Text = "----";
			// 
			// selectAllMenuItem
			// 
			this.selectAllMenuItem.Index = 8;
			this.selectAllMenuItem.Text = "Select All";
			this.selectAllMenuItem.Click += new System.EventHandler(this.selectAllMenuItem_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(144, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Regex:";
			// 
			// Strings
			// 
			this.Strings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.Strings.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Strings.Location = new System.Drawing.Point(144, 232);
			this.Strings.Multiline = true;
			this.Strings.Name = "Strings";
			this.Strings.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.Strings.Size = new System.Drawing.Size(856, 144);
			this.Strings.TabIndex = 2;
			this.Strings.Text = "(425) 123-4567\r\n(111) 555-1212";
			this.toolTip1.SetToolTip(this.Strings, "Strings to use to test the regex");
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(96, 232);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Strings:";
			// 
			// IgnoreWhitespace
			// 
			this.IgnoreWhitespace.Location = new System.Drawing.Point(8, 16);
			this.IgnoreWhitespace.Name = "IgnoreWhitespace";
			this.IgnoreWhitespace.Size = new System.Drawing.Size(116, 24);
			this.IgnoreWhitespace.TabIndex = 4;
			this.IgnoreWhitespace.Text = "IgnoreWhitespace";
			this.toolTip1.SetToolTip(this.IgnoreWhitespace, "Ignore any whitespace or comments in the text");
			this.IgnoreWhitespace.CheckedChanged += new System.EventHandler(this.IgnoreWhitespace_CheckedChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(32, 312);
			this.button1.Name = "button1";
			this.button1.TabIndex = 5;
			this.button1.Text = "Execute";
			this.toolTip1.SetToolTip(this.button1, "Execute this regex");
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(88, 512);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "Output:";
			// 
			// Output
			// 
			this.Output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.Output.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Output.Location = new System.Drawing.Point(144, 504);
			this.Output.Multiline = true;
			this.Output.Name = "Output";
			this.Output.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.Output.Size = new System.Drawing.Size(856, 336);
			this.Output.TabIndex = 7;
			this.Output.Text = "";
			this.toolTip1.SetToolTip(this.Output, "Output window");
			// 
			// IgnoreCase
			// 
			this.IgnoreCase.Location = new System.Drawing.Point(8, 40);
			this.IgnoreCase.Name = "IgnoreCase";
			this.IgnoreCase.Size = new System.Drawing.Size(112, 24);
			this.IgnoreCase.TabIndex = 8;
			this.IgnoreCase.Text = "IgnoreCase";
			this.toolTip1.SetToolTip(this.IgnoreCase, "Ignore the case of letters");
			// 
			// Compiled
			// 
			this.Compiled.Location = new System.Drawing.Point(8, 64);
			this.Compiled.Name = "Compiled";
			this.Compiled.TabIndex = 9;
			this.Compiled.Text = "Compiled";
			this.toolTip1.SetToolTip(this.Compiled, "Compile to a custom engine");
			// 
			// ExplicitCapture
			// 
			this.ExplicitCapture.Location = new System.Drawing.Point(8, 88);
			this.ExplicitCapture.Name = "ExplicitCapture";
			this.ExplicitCapture.TabIndex = 10;
			this.ExplicitCapture.Text = "ExplicitCapture";
			this.toolTip1.SetToolTip(this.ExplicitCapture, "Capture only with (?<name>) syntax");
			this.ExplicitCapture.CheckedChanged += new System.EventHandler(this.ExplicitCapture_CheckedChanged);
			// 
			// Singleline
			// 
			this.Singleline.Location = new System.Drawing.Point(8, 136);
			this.Singleline.Name = "Singleline";
			this.Singleline.TabIndex = 11;
			this.Singleline.Text = "Singleline";
			this.toolTip1.SetToolTip(this.Singleline, "\".\" matches \"\\n\"");
			// 
			// Multiline
			// 
			this.Multiline.Location = new System.Drawing.Point(8, 112);
			this.Multiline.Name = "Multiline";
			this.Multiline.TabIndex = 12;
			this.Multiline.Text = "Multiline";
			this.toolTip1.SetToolTip(this.Multiline, "^ and $ match beginning and end of any line");
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 72);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 23);
			this.label4.TabIndex = 13;
			this.label4.Text = "Time:";
			// 
			// Elapsed
			// 
			this.Elapsed.Location = new System.Drawing.Point(16, 88);
			this.Elapsed.Name = "Elapsed";
			this.Elapsed.TabIndex = 14;
			this.Elapsed.Text = "";
			this.toolTip1.SetToolTip(this.Elapsed, "Time it took to do the match");
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(16, 24);
			this.label5.Name = "label5";
			this.label5.TabIndex = 15;
			this.label5.Text = "Iterations";
			// 
			// Iterations
			// 
			this.Iterations.Location = new System.Drawing.Point(16, 48);
			this.Iterations.Name = "Iterations";
			this.Iterations.TabIndex = 16;
			this.Iterations.Text = "1";
			this.toolTip1.SetToolTip(this.Iterations, "Number of iterations to use when timing ");
			// 
			// Interpret
			// 
			this.Interpret.Location = new System.Drawing.Point(32, 280);
			this.Interpret.Name = "Interpret";
			this.Interpret.TabIndex = 17;
			this.Interpret.Text = "Interpret";
			this.toolTip1.SetToolTip(this.Interpret, "Interpret what this regex means");
			this.Interpret.Click += new System.EventHandler(this.Interpret_Click);
			// 
			// Split
			// 
			this.Split.Location = new System.Drawing.Point(32, 344);
			this.Split.Name = "Split";
			this.Split.TabIndex = 18;
			this.Split.Text = "Split";
			this.toolTip1.SetToolTip(this.Split, "Call Regex.Split()");
			this.Split.Click += new System.EventHandler(this.Split_Click);
			// 
			// CompileTime
			// 
			this.CompileTime.Location = new System.Drawing.Point(16, 128);
			this.CompileTime.Name = "CompileTime";
			this.CompileTime.TabIndex = 22;
			this.CompileTime.Text = "";
			this.toolTip1.SetToolTip(this.CompileTime, "Time it took to create the regex");
			// 
			// label33
			// 
			this.label33.Location = new System.Drawing.Point(16, 112);
			this.label33.Name = "label33";
			this.label33.Size = new System.Drawing.Size(80, 23);
			this.label33.TabIndex = 21;
			this.label33.Text = "Compile Time:";
			// 
			// OneString
			// 
			this.OneString.Location = new System.Drawing.Point(16, 248);
			this.OneString.Name = "OneString";
			this.OneString.Size = new System.Drawing.Size(120, 24);
			this.OneString.TabIndex = 23;
			this.OneString.Text = "Treat as one string";
			this.toolTip1.SetToolTip(this.OneString, "Pass strings in one block rather than as separate calls to regex");
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 0;
			this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem4,
																					  this.menuItem5,
																					  this.menuItem6,
																					  this.menuItem7,
																					  this.menuItem8,
																					  this.menuItem9,
																					  this.menuItem10,
																					  this.menuItem11,
																					  this.menuItem12,
																					  this.menuItem13});
			this.menuItem2.Text = "Character Shortcuts";
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 0;
			this.menuItem4.Text = "Bell - \\a";
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 1;
			this.menuItem5.Text = "Tab - \\t";
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 2;
			this.menuItem6.Text = "Carriage Return - \\r";
			// 
			// menuItem7
			// 
			this.menuItem7.Index = 3;
			this.menuItem7.Text = "Vertical Tab - \\v";
			// 
			// menuItem8
			// 
			this.menuItem8.Index = 4;
			this.menuItem8.Text = "Form Feed - \\f";
			// 
			// menuItem9
			// 
			this.menuItem9.Index = 5;
			this.menuItem9.Text = "Newline - \\n";
			// 
			// menuItem10
			// 
			this.menuItem10.Index = 6;
			this.menuItem10.Text = "Escape - \\e";
			// 
			// menuItem11
			// 
			this.menuItem11.Index = 7;
			this.menuItem11.Text = "ASCII Value - \\x<nn>";
			// 
			// menuItem12
			// 
			this.menuItem12.Index = 8;
			this.menuItem12.Text = "CTRL Char - \\C<letter>";
			// 
			// menuItem13
			// 
			this.menuItem13.Index = 9;
			this.menuItem13.Text = "Unicode Char - \\u<XXXX>";
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 1;
			this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem14,
																					  this.menuItem15,
																					  this.menuItem68,
																					  this.menuItem16,
																					  this.menuItem17,
																					  this.menuItem18,
																					  this.menuItem19,
																					  this.menuItem20,
																					  this.menuItem21,
																					  this.menuItem22});
			this.menuItem3.Text = "Character Classes";
			// 
			// menuItem14
			// 
			this.menuItem14.Index = 0;
			this.menuItem14.Text = "Group - [<chars>]";
			// 
			// menuItem15
			// 
			this.menuItem15.Index = 1;
			this.menuItem15.Text = "Negated group - [^<chars>]";
			// 
			// menuItem68
			// 
			this.menuItem68.Index = 2;
			this.menuItem68.Text = "-";
			// 
			// menuItem16
			// 
			this.menuItem16.Index = 3;
			this.menuItem16.Text = "Any - .";
			// 
			// menuItem17
			// 
			this.menuItem17.Index = 4;
			this.menuItem17.Text = "Word [a-zA-Z_0-9] - \\w";
			// 
			// menuItem18
			// 
			this.menuItem18.Index = 5;
			this.menuItem18.Text = "Non-Word - \\W";
			// 
			// menuItem19
			// 
			this.menuItem19.Index = 6;
			this.menuItem19.Text = "Whitespace [\\f\\n\\r\t\\v] - \\s";
			// 
			// menuItem20
			// 
			this.menuItem20.Index = 7;
			this.menuItem20.Text = "Non-Whitespace - \\S";
			// 
			// menuItem21
			// 
			this.menuItem21.Index = 8;
			this.menuItem21.Text = "Decimal digit - \\d";
			// 
			// menuItem22
			// 
			this.menuItem22.Index = 9;
			this.menuItem22.Text = "Non-decimal digit - \\D";
			// 
			// menuItem23
			// 
			this.menuItem23.Index = 2;
			this.menuItem23.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.menuItem24,
																					   this.menuItem25,
																					   this.menuItem26,
																					   this.menuItem27,
																					   this.menuItem28,
																					   this.menuItem29,
																					   this.menuItem69,
																					   this.menuItem30,
																					   this.menuItem31,
																					   this.menuItem32,
																					   this.menuItem33,
																					   this.menuItem34,
																					   this.menuItem35});
			this.menuItem23.Text = "Quantifiers";
			// 
			// menuItem24
			// 
			this.menuItem24.Index = 0;
			this.menuItem24.Text = "Zero or more - *";
			// 
			// menuItem25
			// 
			this.menuItem25.Index = 1;
			this.menuItem25.Text = "One or more - +";
			// 
			// menuItem26
			// 
			this.menuItem26.Index = 2;
			this.menuItem26.Text = "Zero or one - ?";
			// 
			// menuItem27
			// 
			this.menuItem27.Index = 3;
			this.menuItem27.Text = "From n to m - {<n>,<m>}";
			// 
			// menuItem28
			// 
			this.menuItem28.Index = 4;
			this.menuItem28.Text = "At least n - {<n>,}";
			// 
			// menuItem29
			// 
			this.menuItem29.Index = 5;
			this.menuItem29.Text = "Exactly n - {<n>}";
			// 
			// menuItem69
			// 
			this.menuItem69.Index = 6;
			this.menuItem69.Text = "-";
			// 
			// menuItem30
			// 
			this.menuItem30.Index = 7;
			this.menuItem30.Text = "Zero or more non greedy - *?";
			// 
			// menuItem31
			// 
			this.menuItem31.Index = 8;
			this.menuItem31.Text = "One or more non greedy - +?";
			// 
			// menuItem32
			// 
			this.menuItem32.Index = 9;
			this.menuItem32.Text = "Zero or one non greedy - ??";
			// 
			// menuItem33
			// 
			this.menuItem33.Index = 10;
			this.menuItem33.Text = "From n to m non greedy - {<n>,<m>}?";
			// 
			// menuItem34
			// 
			this.menuItem34.Index = 11;
			this.menuItem34.Text = "At least n non greedy - {<n>,}?";
			// 
			// menuItem35
			// 
			this.menuItem35.Index = 12;
			this.menuItem35.Text = "Exactly n non greedy - {<n>}?";
			// 
			// menuItem36
			// 
			this.menuItem36.Index = 3;
			this.menuItem36.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.menuItem37,
																					   this.menuItem38,
																					   this.menuItem39,
																					   this.menuItem40,
																					   this.menuItem41,
																					   this.menuItem42,
																					   this.menuItem43});
			this.menuItem36.Text = "Anchors";
			// 
			// menuItem37
			// 
			this.menuItem37.Index = 0;
			this.menuItem37.Text = "Beginning of string - ^";
			// 
			// menuItem38
			// 
			this.menuItem38.Index = 1;
			this.menuItem38.Text = "Beginning, multiline - \\A";
			// 
			// menuItem39
			// 
			this.menuItem39.Index = 2;
			this.menuItem39.Text = "End of string - $";
			// 
			// menuItem40
			// 
			this.menuItem40.Index = 3;
			this.menuItem40.Text = "End, multiline - \\Z";
			// 
			// menuItem41
			// 
			this.menuItem41.Index = 4;
			this.menuItem41.Text = "End, multiline -  \\z";
			// 
			// menuItem42
			// 
			this.menuItem42.Index = 5;
			this.menuItem42.Text = "Word boundary - \\b";
			// 
			// menuItem43
			// 
			this.menuItem43.Index = 6;
			this.menuItem43.Text = "Non-word boundary - \\B";
			// 
			// menuItem44
			// 
			this.menuItem44.Index = 4;
			this.menuItem44.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.menuItem45,
																					   this.menuItem46,
																					   this.menuItem47,
																					   this.menuItem53});
			this.menuItem44.Text = "Grouping";
			// 
			// menuItem45
			// 
			this.menuItem45.Index = 0;
			this.menuItem45.Text = "Capture - (<exp>)";
			// 
			// menuItem46
			// 
			this.menuItem46.Index = 1;
			this.menuItem46.Text = "Named capture - (?<<name>>x)";
			// 
			// menuItem47
			// 
			this.menuItem47.Index = 2;
			this.menuItem47.Text = "Non-capture - (?:<exp>)";
			// 
			// menuItem53
			// 
			this.menuItem53.Index = 3;
			this.menuItem53.Text = "Alternation - (<x>|<y>)";
			// 
			// menuItem48
			// 
			this.menuItem48.Index = 5;
			this.menuItem48.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.menuItem49,
																					   this.menuItem50,
																					   this.menuItem51,
																					   this.menuItem52});
			this.menuItem48.Text = "Zero-Width";
			// 
			// menuItem49
			// 
			this.menuItem49.Index = 0;
			this.menuItem49.Text = "Positive Lookahead - (?=<x>)";
			// 
			// menuItem50
			// 
			this.menuItem50.Index = 1;
			this.menuItem50.Text = "Negative Lookahead - (?!<x>)";
			// 
			// menuItem51
			// 
			this.menuItem51.Index = 2;
			this.menuItem51.Text = "Positive Lookbehind - (?<=<x>)";
			// 
			// menuItem52
			// 
			this.menuItem52.Index = 3;
			this.menuItem52.Text = "Negative Lookbehind - (?<!<x>)";
			// 
			// menuItem54
			// 
			this.menuItem54.Index = 6;
			this.menuItem54.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.menuItem55,
																					   this.menuItem56});
			this.menuItem54.Text = "Conditionals";
			// 
			// menuItem55
			// 
			this.menuItem55.Index = 0;
			this.menuItem55.Text = "Expression - (?(<exp>)yes|no)";
			// 
			// menuItem56
			// 
			this.menuItem56.Index = 1;
			this.menuItem56.Text = "Named - (?(<name>)yes|no)";
			// 
			// menuItem57
			// 
			this.menuItem57.Index = 7;
			this.menuItem57.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.menuItem58,
																					   this.menuItem59,
																					   this.menuItem60,
																					   this.menuItem61,
																					   this.menuItem62,
																					   this.menuItem63,
																					   this.menuItem64,
																					   this.menuItem65,
																					   this.menuItem66,
																					   this.menuItem67});
			this.menuItem57.Text = "Options";
			// 
			// menuItem58
			// 
			this.menuItem58.Index = 0;
			this.menuItem58.Text = "Ignore Case - (?i:)";
			// 
			// menuItem59
			// 
			this.menuItem59.Index = 1;
			this.menuItem59.Text = "Ignore Case off - (?-i:)";
			// 
			// menuItem60
			// 
			this.menuItem60.Index = 2;
			this.menuItem60.Text = "Multline - (?m:)";
			// 
			// menuItem61
			// 
			this.menuItem61.Index = 3;
			this.menuItem61.Text = "Multiline off - (?-m:)";
			// 
			// menuItem62
			// 
			this.menuItem62.Index = 4;
			this.menuItem62.Text = "Explicit Capture - (?n:)";
			// 
			// menuItem63
			// 
			this.menuItem63.Index = 5;
			this.menuItem63.Text = "Explicit Capture off - (?-n:)";
			// 
			// menuItem64
			// 
			this.menuItem64.Index = 6;
			this.menuItem64.Text = "Singleline - (?s:)";
			// 
			// menuItem65
			// 
			this.menuItem65.Index = 7;
			this.menuItem65.Text = "Singleline off - (?-s:)";
			// 
			// menuItem66
			// 
			this.menuItem66.Index = 8;
			this.menuItem66.Text = "Ignore Whitespace - (?x:)";
			// 
			// menuItem67
			// 
			this.menuItem67.Index = 9;
			this.menuItem67.Text = "Ignore Whitespace off - (?-x:)";
			// 
			// BackReferenceMenuItem
			// 
			this.BackReferenceMenuItem.Index = 8;
			this.BackReferenceMenuItem.Text = "Backreferences";
			// 
			// HoverInterpret
			// 
			this.HoverInterpret.Checked = true;
			this.HoverInterpret.CheckState = System.Windows.Forms.CheckState.Checked;
			this.HoverInterpret.Location = new System.Drawing.Point(16, 8);
			this.HoverInterpret.Name = "HoverInterpret";
			this.HoverInterpret.TabIndex = 27;
			this.HoverInterpret.Text = "Hover Interpret";
			this.toolTip1.SetToolTip(this.HoverInterpret, "Display interpretation in a popup window");
			// 
			// Description
			// 
			this.Description.Location = new System.Drawing.Point(312, 8);
			this.Description.Name = "Description";
			this.Description.Size = new System.Drawing.Size(688, 20);
			this.Description.TabIndex = 29;
			this.Description.Text = "";
			this.toolTip1.SetToolTip(this.Description, "Description for this regular expression");
			// 
			// HideGroupZero
			// 
			this.HideGroupZero.Location = new System.Drawing.Point(16, 544);
			this.HideGroupZero.Name = "HideGroupZero";
			this.HideGroupZero.TabIndex = 31;
			this.HideGroupZero.Text = "Hide Groups[0]";
			this.toolTip1.SetToolTip(this.HideGroupZero, "Hide Group[0] in the output window");
			// 
			// ReplaceString
			// 
			this.ReplaceString.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ReplaceString.Location = new System.Drawing.Point(144, 392);
			this.ReplaceString.Multiline = true;
			this.ReplaceString.Name = "ReplaceString";
			this.ReplaceString.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.ReplaceString.Size = new System.Drawing.Size(856, 96);
			this.ReplaceString.TabIndex = 36;
			this.ReplaceString.Text = "";
			this.toolTip1.SetToolTip(this.ReplaceString, "Replace text or MatchEvaluator");
			// 
			// Replace
			// 
			this.Replace.Location = new System.Drawing.Point(32, 432);
			this.Replace.Name = "Replace";
			this.Replace.TabIndex = 38;
			this.Replace.Text = "Replace";
			this.toolTip1.SetToolTip(this.Replace, "Call Regex.Replace");
			this.Replace.Click += new System.EventHandler(this.Replace_Click);
			// 
			// MatchEvaluator
			// 
			this.MatchEvaluator.Location = new System.Drawing.Point(16, 464);
			this.MatchEvaluator.Name = "MatchEvaluator";
			this.MatchEvaluator.TabIndex = 39;
			this.MatchEvaluator.Text = "MatchEvaluator";
			this.toolTip1.SetToolTip(this.MatchEvaluator, "Write an implementation of a MatchEvaluator");
			this.MatchEvaluator.CheckedChanged += new System.EventHandler(this.MatchEvaluator_CheckedChanged);
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem70,
																					  this.menuItem73,
																					  this.addItem,
																					  this.library,
																					  this.about});
			// 
			// menuItem70
			// 
			this.menuItem70.Index = 0;
			this.menuItem70.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.saveRegex,
																					   this.makeAssemblyItem});
			this.menuItem70.Text = "File";
			// 
			// saveRegex
			// 
			this.saveRegex.Index = 0;
			this.saveRegex.Text = "Save Regex";
			this.saveRegex.Click += new System.EventHandler(this.saveRegex_Click);
			// 
			// makeAssemblyItem
			// 
			this.makeAssemblyItem.Index = 1;
			this.makeAssemblyItem.Text = "Make Assembly";
			this.makeAssemblyItem.Click += new System.EventHandler(this.makeAssemblyItem_Click);
			// 
			// menuItem73
			// 
			this.menuItem73.Index = 1;
			this.menuItem73.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.copyAsCSharp,
																					   this.copyAsVB,
																					   this.pasteFromCSharp});
			this.menuItem73.Text = "Edit";
			// 
			// copyAsCSharp
			// 
			this.copyAsCSharp.Index = 0;
			this.copyAsCSharp.Text = "Copy as C#";
			this.copyAsCSharp.Click += new System.EventHandler(this.copyAsCSharp_Click);
			// 
			// copyAsVB
			// 
			this.copyAsVB.Index = 1;
			this.copyAsVB.Text = "Copy as VB";
			this.copyAsVB.Click += new System.EventHandler(this.copyAsVB_Click);
			// 
			// pasteFromCSharp
			// 
			this.pasteFromCSharp.Index = 2;
			this.pasteFromCSharp.Text = "Paste from C#";
			this.pasteFromCSharp.Click += new System.EventHandler(this.pasteFromCSharp_Click);
			// 
			// addItem
			// 
			this.addItem.Index = 2;
			this.addItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					this.menuItem2,
																					this.menuItem3,
																					this.menuItem23,
																					this.menuItem36,
																					this.menuItem44,
																					this.menuItem48,
																					this.menuItem54,
																					this.menuItem57,
																					this.BackReferenceMenuItem});
			this.addItem.Text = "Add Item";
			this.addItem.Popup += new System.EventHandler(this.addItem_Popup);
			this.addItem.Click += new System.EventHandler(this.addItem_Click);
			// 
			// library
			// 
			this.library.Index = 3;
			this.library.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					this.menuItem1});
			this.library.Text = "Library";
			this.library.Popup += new System.EventHandler(this.library_Popup);
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.Text = "Fake Item";
			// 
			// about
			// 
			this.about.Index = 4;
			this.about.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																				  this.menuItem71,
																				  this.menuReleaseNotes});
			this.about.Text = "About";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.IgnoreWhitespace);
			this.groupBox1.Controls.Add(this.Multiline);
			this.groupBox1.Controls.Add(this.ExplicitCapture);
			this.groupBox1.Controls.Add(this.Compiled);
			this.groupBox1.Controls.Add(this.Singleline);
			this.groupBox1.Controls.Add(this.IgnoreCase);
			this.groupBox1.Location = new System.Drawing.Point(8, 32);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(128, 168);
			this.groupBox1.TabIndex = 28;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Options";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(232, 8);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(72, 23);
			this.label6.TabIndex = 30;
			this.label6.Text = "Description:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.CompileTime);
			this.groupBox2.Controls.Add(this.label33);
			this.groupBox2.Controls.Add(this.Elapsed);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.Iterations);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Location = new System.Drawing.Point(8, 640);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(128, 168);
			this.groupBox2.TabIndex = 32;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Timing";
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Location = new System.Drawing.Point(8, 384);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(984, 1);
			this.panel1.TabIndex = 33;
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Location = new System.Drawing.Point(-1, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(984, 1);
			this.panel2.TabIndex = 34;
			// 
			// panel3
			// 
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel3.Location = new System.Drawing.Point(-1, 40);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(984, 1);
			this.panel3.TabIndex = 34;
			// 
			// panel4
			// 
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel4.Controls.Add(this.panel5);
			this.panel4.Location = new System.Drawing.Point(8, 496);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(984, 1);
			this.panel4.TabIndex = 34;
			// 
			// panel5
			// 
			this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel5.Controls.Add(this.panel6);
			this.panel5.Location = new System.Drawing.Point(-1, 0);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(984, 1);
			this.panel5.TabIndex = 34;
			// 
			// panel6
			// 
			this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel6.Location = new System.Drawing.Point(-1, 40);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(984, 1);
			this.panel6.TabIndex = 34;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(80, 400);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(56, 16);
			this.label7.TabIndex = 35;
			this.label7.Text = "Replace:";
			// 
			// panel7
			// 
			this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel7.Controls.Add(this.panel8);
			this.panel7.Location = new System.Drawing.Point(8, 224);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(984, 1);
			this.panel7.TabIndex = 37;
			// 
			// panel8
			// 
			this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel8.Controls.Add(this.panel9);
			this.panel8.Location = new System.Drawing.Point(-1, 0);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(984, 1);
			this.panel8.TabIndex = 34;
			// 
			// panel9
			// 
			this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel9.Location = new System.Drawing.Point(-1, 40);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(984, 1);
			this.panel9.TabIndex = 34;
			// 
			// menuItem71
			// 
			this.menuItem71.Index = 0;
			this.menuItem71.Text = "About Regular Expression Workbench";
			this.menuItem71.Click += new System.EventHandler(this.menuItem71_Click);
			// 
			// menuReleaseNotes
			// 
			this.menuReleaseNotes.Index = 1;
			this.menuReleaseNotes.Text = "Release Notes";
			this.menuReleaseNotes.Click += new System.EventHandler(this.menuReleaseNotes_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1008, 837);
			this.Controls.Add(this.MatchEvaluator);
			this.Controls.Add(this.Replace);
			this.Controls.Add(this.panel7);
			this.Controls.Add(this.ReplaceString);
			this.Controls.Add(this.Description);
			this.Controls.Add(this.Output);
			this.Controls.Add(this.Strings);
			this.Controls.Add(this.RegexText);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.HideGroupZero);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.HoverInterpret);
			this.Controls.Add(this.OneString);
			this.Controls.Add(this.Split);
			this.Controls.Add(this.Interpret);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.Text = "Regular Expression Workbench";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void SaveValues()
		{
			SaveRegex(Environment.GetFolderPath(Environment.SpecialFolder.Personal) +
					  "\\regex.xml");
		}


		private RegexOptions CreateRegexOptions()
		{
			RegexOptions regOp = new RegexOptions();
			if (this.IgnoreWhitespace.Checked)
			{
				regOp |= RegexOptions.IgnorePatternWhitespace;
			}
			if (this.IgnoreCase.Checked)
			{
				regOp |= RegexOptions.IgnoreCase;
			}
			if (this.Compiled.Checked)
			{
				regOp |= RegexOptions.Compiled;
			}
			if (this.ExplicitCapture.Checked)
			{
				regOp |= RegexOptions.ExplicitCapture;
			}
			if (this.Singleline.Checked)
			{
				regOp |= RegexOptions.Singleline;
			}
			if (this.Multiline.Checked)
			{
				regOp |= RegexOptions.Multiline;
			}

			return regOp;
		}

		private Regex CreateRegex()
		{
			RegexOptions regOp = CreateRegexOptions();
			return new Regex(RegexText.Text, regOp);
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			SaveValues();

			Regex regex = null;
			try
			{
				Counter counter = new Counter();
				counter.Start();
				regex = CreateRegex();
				counter.Stop();
				this.CompileTime.Text = counter.Seconds.ToString();
			}
			catch (Exception ex)
			{
				Output.Text = ex.ToString();
				return;
			}

			string[] groupNames = regex.GetGroupNames();

			string[] strings;
				// if checked, pass all lines as a single block
			if (OneString.Checked)
			{
				strings = new string[1];
				strings[0] = Strings.Text;
			}
			else
			{
				strings = Regex.Split(Strings.Text, @"\r\n");
				//strings = Strings.Text.Split('\n\r');
			}

			StringBuilder outString = new StringBuilder();
			foreach (string s in strings)
			{
				outString.Append(String.Format("Matching: {0}\r\n", s));

				Elapsed.Text = "";
				int iterations = Convert.ToInt32(Iterations.Text);
				Counter counter = new Counter();
				counter.Start();
				Match m = null;
				for (int i = 0; i < iterations; i++)
				{
					m = regex.Match(s);
					while (m.Success)
					{
						m = m.NextMatch();
					}
				}
				counter.Stop();
				Elapsed.Text = String.Format("{0:f2}", counter.Seconds);

				m = regex.Match(s);
				bool noMatch = true;
				while (m.Success)
				{
					noMatch = false;
					GroupCollection groups = m.Groups;
					
					int groupNumber = 0;
					foreach (Group group in m.Groups)
					{
						foreach (Capture capture in group.Captures)
						{
							if ((HideGroupZero.Checked == false) ||
								(groupNames[groupNumber] != "0"))
							{
								outString.Append(String.Format("    {0} => {1}\r\n", groupNames[groupNumber], capture));
							}
							//CaptureCollection c = group.Captures;
						}
						groupNumber++;
					}

					m = m.NextMatch();
				}
				if (noMatch)
				{
					outString.Append("    No Match\r\n");
				}
			}
			Output.Text = outString.ToString();
		}

		#region SaveRestore

		private void SaveRegex(string filename)
		{
			// write to SOAP (XML)
			using(FileStream streamWrite = File.Create(filename))
			{
				SoapFormatter soapWrite = new SoapFormatter();

				Settings settings = new Settings();
				settings.RegexText = RegexText.Text;
				settings.Strings = Strings.Text;
				settings.IgnoreWhitespace = IgnoreWhitespace.Checked;
				settings.IgnoreCase = IgnoreCase.Checked;
				settings.Compiled = Compiled.Checked;
				settings.ExplicitCapture = ExplicitCapture.Checked;
				settings.Multiline = Multiline.Checked;
				settings.Singleline = Singleline.Checked;
				settings.Iterations = Iterations.Text;
				settings.OneString = OneString.Checked;
				settings.Description = Description.Text;
				settings.ReplaceString = ReplaceString.Text;
				settings.MatchEvaluator = MatchEvaluator.Checked;
				settings.HideGroupZero = HideGroupZero.Checked;
				soapWrite.Serialize(streamWrite, settings);
			}
		}
		private void LoadRegex(string filename)
		{
			try
			{
				using (FileStream streamRead = File.OpenRead(filename))
				{
					try
					{
						SoapFormatter soapRead = new SoapFormatter();
						Settings settings = 
							(Settings) soapRead.Deserialize(streamRead);

						RegexText.Text = settings.RegexText;
						Strings.Text = settings.Strings;
						IgnoreWhitespace.Checked = settings.IgnoreWhitespace;
						IgnoreCase.Checked = settings.IgnoreCase;
						Compiled.Checked = settings.Compiled;
						ExplicitCapture.Checked = settings.ExplicitCapture;
						Multiline.Checked = settings.Multiline;
						Singleline.Checked = settings.Singleline;
						Iterations.Text = settings.Iterations;
						OneString.Checked = settings.OneString;
						Description.Text = settings.Description;
						MatchEvaluator.Checked = settings.MatchEvaluator;
						ReplaceString.Text = settings.ReplaceString;
						HideGroupZero.Checked = settings.HideGroupZero;
					}
					catch (Exception e)
					{
						string s = e.ToString();
					}
				}
			}
			catch (FileNotFoundException)
			{
				return;
			}
		}
		#endregion

		private void Form1_Load(object sender, System.EventArgs e)
		{
			string filename = 
				String.Format(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\regex.xml");

			if (File.Exists(filename))
			{
				LoadRegex(filename);
			}

			Graphics g = Graphics.FromHwnd(this.Handle);
			this.characterSize = g.MeasureString(RegexText.Text, RegexText.Font);
			this.characterSize.Width /= RegexText.Text.Length;
		}

		// Go from commented regex version to non-commented version
		private string RemoveWhitespace(string regexString)
		{
			if (!this.IgnoreWhitespace.Checked)
				return regexString;

				// first, get rid of all comments...
			Regex removeComments = new Regex(@"\#.+");
			regexString = removeComments.Replace(regexString, "");
			
				// remove un-escaped whitespace...
			Regex removeWhitespace = new Regex(@"(?<!\\)[ \t\n]");
			regexString = removeWhitespace.Replace(regexString, "");
			regexString = regexString.Replace("\r", "");
			return regexString;
		}

		private void Interpret_Click(object sender, System.EventArgs e)
		{
			SaveValues();

			buffer = new RegexBuffer(RegexText.Text);
			buffer.RegexOptions = CreateRegexOptions();
			try
			{
				RegexExpression exp = new RegexExpression(buffer);

				Output.Text = exp.ToString(0);

			}
			catch (Exception ex)
			{
				if (buffer.ErrorLocation != -1)
				{
					RegexText.SelectionStart = buffer.ErrorLocation;
					RegexText.SelectionLength = buffer.ErrorLength;
				}
				Output.Text = 
					"Error intepreting regex\r\n" + ex.Message;
				RegexText.Focus();
			}
		}

		private void Split_Click(object sender, System.EventArgs e)
		{
			SaveValues();
			Regex regex = null;
			try
			{
				regex = CreateRegex();
			}
			catch (Exception ex)
			{
				Output.Text = ex.ToString();
				return;
			}

			string[] strings;
			// if checked, pass all lines as a single block
			if (OneString.Checked)
			{
				strings = new string[1];
				strings[0] = Strings.Text;
			}
			else
			{
				strings = Regex.Split(Strings.Text, @"\r\n");
				//strings = Strings.Text.Split('\n\r');
			}

			StringBuilder outString = new StringBuilder();
			foreach (string s in strings)
			{
				outString.Append(String.Format("Splitting: {0}\r\n", s));			

				string[] arr = regex.Split(s);

				int index = 0;
				foreach (string split in arr)
				{
					outString.Append(String.Format("    [{0}] => {1}\r\n", index, split));
					index++;
				}
			}
			Output.Text = outString.ToString();

		}

		private void Replace_Click(object sender, System.EventArgs e)
		{
			SaveValues();
			Regex regex = null;
			try
			{
				regex = CreateRegex();
			}
			catch (Exception ex)
			{
				Output.Text = ex.ToString();
				return;
			}

			string[] strings;
			// if checked, pass all lines as a single block
			if (OneString.Checked)
			{
				strings = new string[1];
				strings[0] = Strings.Text;
			}
			else
			{
				strings = Regex.Split(Strings.Text, @"\r\n");
				//strings = Strings.Text.Split('\n\r');
			}

			ReplaceMatchEvaluator replacer = null;

			if (MatchEvaluator.Checked)
			{
				replacer = new ReplaceMatchEvaluator(regex, ReplaceString.Text);
				string output = replacer.CreateAndLoadClass();
				if (output != null)
				{
					Output.Text = output;
					return;
				}
			}

			StringBuilder outString = new StringBuilder();
			string replace = ReplaceString.Text;
			foreach (string s in strings)
			{
				outString.Append(String.Format("Replacing: {0}\r\n", s));
				
				string output = null;
				if (this.MatchEvaluator.Checked)
				{
					outString.Append("  with a custom MatchEvaluator\r\n");	
					output = regex.Replace(s, replacer.MatchEvaluator);
				}
				else
				{
					outString.Append(String.Format("  with: {0}\r\n", replace));	
					output = regex.Replace(s, replace); 
				}
				outString.Append(String.Format("  result: {0}\r\n", output));
			}
			Output.Text = outString.ToString();
		}

		private void makeAssemblyItem_Click(object sender, System.EventArgs e)
		{
			MakeAssemblyDialog dialog = new MakeAssemblyDialog();
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				RegexCompilationInfo[] regexCompInfo = {
														   new RegexCompilationInfo(
														   RegexText.Text, 
														   CreateRegexOptions(), dialog.TypeName.Text, dialog.Namespace.Text, dialog.CreatePublic.Checked)
													   };

				AssemblyName assemblyName = new AssemblyName();
				assemblyName.Name = dialog.AssemblyName.Text;
				Regex.CompileToAssembly(regexCompInfo, assemblyName);
				
			}
		}

		private void CopyCSharp_Click(object sender, System.EventArgs e)
		{

		}

		string MakeCSharpString()
		{
			string s =
				"Regex regex = new Regex(@\"\r\n" +
				RegexText.Text.Replace("\"", "\"\"") +
				"\", \r\n";

			ArrayList optionStrings = new ArrayList();
			RegexOptions options = CreateRegexOptions();

			foreach (RegexOptions option in Enum.GetValues(typeof(RegexOptions)))
			{
				if ((options & option) != 0)
				{
					optionStrings.Add("RegexOptions." + Enum.GetName(typeof(RegexOptions), option));
				}
			}	
		
			if (optionStrings.Count != 0)
			{
				s += String.Join(" | \r\n", (string[]) optionStrings.ToArray(typeof(string)));
			}
			else
			{
				s += " (RegexOptions) 0";
			}
			s += ");";

			s = s.Replace("\n", "\n\t\t\t\t");
			return s;
#if fred
Regex r = new Regex(
				@"(?<Field>         # capture to field
				[^,""]+              # one or more not , or ""
				|                 # or
				""[^""]+              # "" and one or more not , or ""
				""),               # end capture", 
				RegexOptions.IgnorePatternWhitespace);
			
			#endif
		}

		private void RegexText_Leave(object sender, System.EventArgs e)
		{
			regexInsertionPoint = RegexText.SelectionStart;
		}

			// this routine is called by both the Add Item menu and the
			// pick on the context menu.
			// Rather than figure out which, we just update both. 
			// (yes, I know, it's inefficient)
		private void addItem_Popup(object sender, System.EventArgs e)
		{
			UpdateBackreferences(addItem, BackReferenceMenuItem);
			UpdateBackreferences(contextMenuAddItems, contextMenuBackreferences);
		}

		private void UpdateBackreferences(MenuItem addItem, MenuItem BackReferenceMenuItem)
		{

				// BUG:
				// If you clear a menu item and then add items back into
				// it, the newly added items don't show up. If you
				// remove it from the context menu and then add it back
				// it works fine. 
			addItem.MenuItems.Remove(BackReferenceMenuItem);

			BackReferenceMenuItem.MenuItems.Clear();

			Regex regexCapture = new Regex(
				@"\(\?<
				(?<Name>.+?)
				>.+?\)
				", 
				RegexOptions.ExplicitCapture | 
				RegexOptions.IgnorePatternWhitespace);

			Match m = regexCapture.Match(RegexText.Text);

			while (m.Success)
			{
				string name = m.Groups["Name"].Value;
				string item = String.Format("{0} - \\k<{1}>", name, name);
				MenuItem menuItem = new MenuItem(item, new System.EventHandler(this.addItem_Click));
				BackReferenceMenuItem.MenuItems.Add(menuItem);
				m = m.NextMatch();
			}

				// now match any unnamed captures, and add
				// references for them...
			if (!ExplicitCapture.Checked)
			{
				Regex regexUnnamed = new Regex(
					@"\(            # Opening (
				(?!           # Not followed by
				 (\?<|\?:))   #     ""?<"" or ""?:""s
				", 
					RegexOptions.ExplicitCapture | 
					RegexOptions.IgnorePatternWhitespace);			

				m = regexUnnamed.Match(RegexText.Text);

				int number = 1;
				while (m.Success)
				{
					string item = String.Format("{0} - \\<{1}>", number, number);
					MenuItem menuItem = new MenuItem(item, new System.EventHandler(this.addItem_Click));
					BackReferenceMenuItem.MenuItems.Add(menuItem);
					number++;
					m = m.NextMatch();
				}

			
			}
			addItem.MenuItems.Add(BackReferenceMenuItem);
		}

		
		private void addItem_Click(object sender, System.EventArgs e)
		{
			MenuItem menuItem = (MenuItem) sender;

			Regex regexBreak = new Regex(".+ - (?<Placeholder>.+)");
			Match match = regexBreak.Match(menuItem.Text);
			if (match.Success)
			{
				string insert = match.Groups["Placeholder"].ToString();
				regexInsertionPoint = RegexText.SelectionStart;
				string start = "";
				string end = "";

				//try
				//{
					start = RegexText.Text.Substring(0, regexInsertionPoint);
					end = RegexText.Text.Substring(regexInsertionPoint);
				//}
				//catch (Exception)
			//	{
			//		// anything bad happens, don't worry about the rest of the string...
			//	}
				RegexText.Text = start + insert + end;

				Regex regexSelect = new Regex("(?<Select><[^<]+?>)");
				match = regexSelect.Match(insert);
				if (match.Success)
				{
					Group g = match.Groups["Select"];
					RegexText.SelectionStart = 
						regexInsertionPoint + g.Index;
					RegexText.SelectionLength = g.Length;
				}
				else
				{
					RegexText.SelectionStart = regexInsertionPoint;
				}
				RegexText.Focus();
			}
		}

		private void CopyVB_Click(object sender, System.EventArgs e)
		{

		}

		string MakeVBString()
		{
#if fred
   Dim r As Regex
      Dim m As Match
    
      r = New Regex("href\s*=\s*(?:""(?<1>[^""]*)""|(?<1>\S+))", _
         RegexOptions.IgnoreCase Or RegexOptions.Compiled)
    
      m = r.Match(inputString)
      While m.Success
         Console.WriteLine("Found href " & m.Groups(1).Value _
            & " at " & m.Groups(1).Index.ToString())
         m = m.NextMatch()
      End While
   End Sub
#endif
			string s =
				"Dim r as Regex\r\n\r\n" +
				"r = new Regex( _\r\n";

			Regex splitter = new Regex("\r\n");
			string[] lines = splitter.Split(RegexText.Text);

			s += "\"";
			s += String.Join("\" + _ \r\n\"", lines);
			s += "\" _\r\n";

			ArrayList optionStrings = new ArrayList();
			RegexOptions options = CreateRegexOptions();

			foreach (RegexOptions option in Enum.GetValues(typeof(RegexOptions)))
			{
				if ((options & option) != 0)
				{
					optionStrings.Add("RegexOptions." + Enum.GetName(typeof(RegexOptions), option));
				}
			}	
		
			if (optionStrings.Count != 0)
			{
				s += ", ";
				s += String.Join(" Or ", (string[]) optionStrings.ToArray(typeof(string)));
			}

			s += ")";

			
			return s;
		}


		private void about_Click(object sender, System.EventArgs e)
		{
			About about = new About();
			about.ShowDialog();
		}

		private void UpdateBuffer()
		{
			if (bufferDirty)
			{
				buffer = new RegexBuffer(RegexText.Text);
				buffer.RegexOptions = CreateRegexOptions();
				bufferDirty = false;
			}
		}

		private void RegexText_TextChanged(object sender, System.EventArgs e)
		{
			bufferDirty = true;
		}

		private RegexTest.HoverDetailAction RegexText_HoverDetail(object sender, RegexTest.HoverEventArgs args)
		{
			HoverDetailAction action = null;
			if (!HoverInterpret.Checked)
				return null;
			
			UpdateBuffer();
			try
			{
				RegexExpression exp = new RegexExpression(buffer);
			}
			catch (Exception e)
			{
				Output.Text = e.ToString();
				return null;
			}

			RegexRef regexRef = buffer.MatchLocations(args.CharacterOffset);
			if (regexRef != null)
			{
				//action = new HoverDetailAction(regexRef.Start, regexRef.Length, regexRef.Item.ToString(0));
				action = new HoverDetailAction(regexRef.Start, regexRef.Length, regexRef.StringValue);
			}
			return action;
		}

		private void RegexText_Enter(object sender, System.EventArgs e)
		{
			bufferDirty = true;
		}

		private void RegexText_TextChanged_1(object sender, System.EventArgs e)
		{
			bufferDirty = true;
		}

		private void IgnoreWhitespace_CheckedChanged(object sender, System.EventArgs e)
		{
			bufferDirty = true;
		}

		private void ExplicitCapture_CheckedChanged(object sender, System.EventArgs e)
		{
			bufferDirty = true;
		}

			// get the contents of a C# regex, and make it nicer...
		private void pasteFromCSharp_Click(object sender, System.EventArgs e)
		{
			IDataObject clipboard = Clipboard.GetDataObject();
			string value = (string) clipboard.GetData(typeof(string));

				// first, get rid of the "Regex regex line, if it exists"
			Regex regex2 = new Regex(@"
				^.+?new\ Regex\(@""(?<Rest>.+)
				", 
				RegexOptions.Multiline | 
				RegexOptions.ExplicitCapture | 
				RegexOptions.Singleline | 
				RegexOptions.IgnorePatternWhitespace);

			Match m = regex2.Match(value);
			if (m.Success)
			{
				value = m.Groups["Rest"].Value;
			}

				// get rid of the leading whitespace on each line...
			Regex regex = new Regex(@"
				^\s+
				", 
				RegexOptions.Multiline | 
				RegexOptions.ExplicitCapture | 
				RegexOptions.IgnorePatternWhitespace);

			value = regex.Replace(value, "");

				// see if there is a " and options after the string...
			Regex regex3 = new Regex(@"
				(?<Pattern>.+)^\s*"",(?<Rest>.+)
				", 
				RegexOptions.Multiline | 
				RegexOptions.ExplicitCapture | 
				RegexOptions.Singleline | 
				RegexOptions.IgnorePatternWhitespace);

			m = regex3.Match(value);
			if (m.Success)
			{
				value = m.Groups["Pattern"].Value;

					// clear all the patterns, and then set the ones
					// that are on...
				this.IgnoreCase.Checked = false;
				this.IgnoreWhitespace.Checked = false;
				this.Multiline.Checked = false;
				this.Singleline.Checked = false;
				this.Compiled.Checked = false;
				this.ExplicitCapture.Checked = false;

				string rest = m.Groups["Rest"].Value;
				if (rest.IndexOf("IgnoreCase") != -1)
					this.IgnoreCase.Checked = true;

				if (rest.IndexOf("IgnorePatternWhitespace") != -1)
					this.IgnoreWhitespace.Checked = true;

				if (rest.IndexOf("Multiline") != -1)
					this.Multiline.Checked = true;

				if (rest.IndexOf("Singleline") != -1)
					this.Singleline.Checked = true;

				if (rest.IndexOf("Compiled") != -1)
					this.Compiled.Checked = true;

				if (rest.IndexOf("ExplicitCapture") != -1)
					this.ExplicitCapture.Checked = true;
			}

				// change any double "" to "
			RegexText.Text = value.Replace("\"\"", "\"");
		}

		private void copyAsCSharp_Click(object sender, System.EventArgs e)
		{
			string csharpSource = MakeCSharpString();
			Clipboard.SetDataObject(csharpSource);
			this.Output.Text = csharpSource;		
		}

		private void copyAsVB_Click(object sender, System.EventArgs e)
		{
			string vbSource = MakeVBString();
			Clipboard.SetDataObject(vbSource);
			this.Output.Text = vbSource;		
		}

		private void saveRegex_Click(object sender, System.EventArgs e)
		{
			Directory.CreateDirectory("library");
			SaveRegex saveRegexDialog = new SaveRegex();
			if (saveRegexDialog.ShowDialog() == DialogResult.OK)
			{
				SaveRegex(saveRegexDialog.filename.Text);
			}
		}

		private void libraryItem_Click(object sender, System.EventArgs e)
		{
			LibraryMenuItem menuItem = (LibraryMenuItem) sender;
			LoadRegex(menuItem.Filename);
		}
		
		private void CreateLibrary(DirectoryInfo dirInfo, Menu.MenuItemCollection collection)
		{
			foreach (DirectoryInfo subdir in dirInfo.GetDirectories())
			{
				MenuItem  subMenuItem = new MenuItem(subdir.Name);
				collection.Add(subMenuItem);
				CreateLibrary(subdir, subMenuItem.MenuItems);
			}

			foreach (FileInfo fileInfo in dirInfo.GetFiles())
			{
				if (fileInfo.Extension.ToLower() == ".regex")
				{
					LibraryMenuItem fileMenuItem = 
						new LibraryMenuItem(fileInfo.FullName,
											fileInfo.Name,
											new EventHandler(libraryItem_Click));
					collection.Add(fileMenuItem);
				}
			}
		}

		private void library_Popup(object sender, System.EventArgs e)
		{
			this.library.MenuItems.Clear();

			DirectoryInfo dirInfo = new DirectoryInfo(currentDirectory + @"\library");
			CreateLibrary(dirInfo, library.MenuItems);
		}

		private void contextMenu1_Popup(object sender, System.EventArgs e)
		{
		
		}

		private void undoMenuItem_Click(object sender, System.EventArgs e)
		{
			RegexText.Undo();
		}

		private void cutMenuItem_Click(object sender, System.EventArgs e)
		{
			RegexText.Cut();
		}

		private void copyMenuItem_Click(object sender, System.EventArgs e)
		{
			RegexText.Copy();
		}

		private void pasteMenuItem_Click(object sender, System.EventArgs e)
		{
			RegexText.Paste();
		}

		private void deleteMenuItem_Click(object sender, System.EventArgs e)
		{
			RegexText.Clear();
		}

		private void selectAllMenuItem_Click(object sender, System.EventArgs e)
		{
			RegexText.SelectAll();
		}

		private void addElement_Click(object sender, System.EventArgs e)
		{
			
		}

		private void MatchEvaluator_CheckedChanged(object sender, System.EventArgs e)
		{
			if (MatchEvaluator.Checked)
			{
				this.ReplaceString.Text = 
					"static public string Evaluator(Match match) {\r\n" +
					"    return \"Fred\";\r\n" +
					"}";
			}
		}

		private void menuItem71_Click(object sender, System.EventArgs e)
		{
			About about = new About();
			about.ShowDialog();
		}

		private void menuReleaseNotes_Click(object sender, System.EventArgs e)
		{
			ReleaseNotes releaseNotes = new ReleaseNotes();
			releaseNotes.ShowDialog();
		}
	}
}
