using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace RegexTest
{
	/// <summary>
	/// Summary description for MakeAssemblyDialog.
	/// </summary>
	public class MakeAssemblyDialog : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button OK;
		private System.Windows.Forms.Button Cancel;
		public System.Windows.Forms.CheckBox CreatePublic;
		public System.Windows.Forms.TextBox Namespace;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.TextBox TypeName;
		public System.Windows.Forms.TextBox AssemblyName;
		private System.Windows.Forms.Label label3;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public MakeAssemblyDialog()
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
			this.label1 = new System.Windows.Forms.Label();
			this.Namespace = new System.Windows.Forms.TextBox();
			this.OK = new System.Windows.Forms.Button();
			this.Cancel = new System.Windows.Forms.Button();
			this.CreatePublic = new System.Windows.Forms.CheckBox();
			this.TypeName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.AssemblyName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Namespace:";
			// 
			// Namespace
			// 
			this.Namespace.Location = new System.Drawing.Point(96, 56);
			this.Namespace.Name = "Namespace";
			this.Namespace.Size = new System.Drawing.Size(296, 20);
			this.Namespace.TabIndex = 1;
			this.Namespace.Text = "textBox1";
			// 
			// OK
			// 
			this.OK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.OK.Location = new System.Drawing.Point(120, 136);
			this.OK.Name = "OK";
			this.OK.TabIndex = 2;
			this.OK.Text = "OK";
			// 
			// Cancel
			// 
			this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Cancel.Location = new System.Drawing.Point(240, 136);
			this.Cancel.Name = "Cancel";
			this.Cancel.TabIndex = 3;
			this.Cancel.Text = "Cancel";
			// 
			// CreatePublic
			// 
			this.CreatePublic.Checked = true;
			this.CreatePublic.CheckState = System.Windows.Forms.CheckState.Checked;
			this.CreatePublic.Location = new System.Drawing.Point(24, 120);
			this.CreatePublic.Name = "CreatePublic";
			this.CreatePublic.TabIndex = 4;
			this.CreatePublic.Text = "Public";
			// 
			// TypeName
			// 
			this.TypeName.Location = new System.Drawing.Point(96, 88);
			this.TypeName.Name = "TypeName";
			this.TypeName.Size = new System.Drawing.Size(296, 20);
			this.TypeName.TabIndex = 6;
			this.TypeName.Text = "textBox1";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "Type Name:";
			// 
			// AssemblyName
			// 
			this.AssemblyName.Location = new System.Drawing.Point(96, 16);
			this.AssemblyName.Name = "AssemblyName";
			this.AssemblyName.Size = new System.Drawing.Size(296, 20);
			this.AssemblyName.TabIndex = 8;
			this.AssemblyName.Text = "Assembly";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 23);
			this.label3.TabIndex = 7;
			this.label3.Text = "Assembly";
			// 
			// MakeAssemblyDialog
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(400, 186);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.AssemblyName,
																		  this.label3,
																		  this.TypeName,
																		  this.label2,
																		  this.CreatePublic,
																		  this.Cancel,
																		  this.OK,
																		  this.Namespace,
																		  this.label1});
			this.Name = "MakeAssemblyDialog";
			this.Text = "MakeAssemblyDialog";
			this.ResumeLayout(false);

		}
		#endregion
	}
}
