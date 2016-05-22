using System;
using System.Collections;
using System.Windows.Forms;

namespace RegexTest
{
	/// <summary>
	/// Summary description for LibraryMenuItem.
	/// </summary>
	public class LibraryMenuItem: MenuItem
	{
		string filename;

		public LibraryMenuItem(string filename, string text, EventHandler handler):
				base(text, handler)
		{
			this.filename = filename;
		}

		public string Filename
		{
			get
			{
				return filename;
			}
		}	
	}
}
