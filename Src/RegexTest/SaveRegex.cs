using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;

namespace RegexTest
{
	/// <summary>
	/// Summary description for SaveRegex.
	/// </summary>
	public class SaveRegex : System.Windows.Forms.Form
	{
		private static string lastDirectory = "library";

		public System.Windows.Forms.TextBox filename;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Button browseButton;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public SaveRegex()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

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
			this.filename = new System.Windows.Forms.TextBox();
			this.okButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.browseButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// filename
			// 
			this.filename.Location = new System.Drawing.Point(88, 16);
			this.filename.Name = "filename";
			this.filename.Size = new System.Drawing.Size(328, 20);
			this.filename.TabIndex = 1;
			this.filename.Text = "Library\\";
			// 
			// okButton
			// 
			this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.okButton.Location = new System.Drawing.Point(136, 64);
			this.okButton.Name = "okButton";
			this.okButton.TabIndex = 2;
			this.okButton.Text = "OK";
			this.okButton.Click += new System.EventHandler(this.okButton_Click);
			// 
			// cancelButton
			// 
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Location = new System.Drawing.Point(272, 64);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.TabIndex = 3;
			this.cancelButton.Text = "Cancel";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "Filename:";
			// 
			// browseButton
			// 
			this.browseButton.Location = new System.Drawing.Point(432, 16);
			this.browseButton.Name = "browseButton";
			this.browseButton.TabIndex = 5;
			this.browseButton.Text = "Browse";
			this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
			// 
			// SaveRegex
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(528, 106);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.browseButton,
																		  this.label2,
																		  this.cancelButton,
																		  this.okButton,
																		  this.filename});
			this.Name = "SaveRegex";
			this.Text = "SaveRegex";
			this.ResumeLayout(false);

		}
		#endregion

		private void browseButton_Click(object sender, System.EventArgs e)
		{
			SaveFileDialog dialog = new SaveFileDialog();
			dialog.InitialDirectory = lastDirectory;
			dialog.DefaultExt = "Regex";
			dialog.AddExtension = true;
			dialog.Filter = "Regex files (*.regex)|*.regex";
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				filename.Text = dialog.FileName;
			}
		}

		private void okButton_Click(object sender, System.EventArgs e)
		{
			FileInfo fileInfo = new FileInfo(filename.Text);
			lastDirectory = fileInfo.DirectoryName;
		}
	}
}
