using System;

namespace RegexTest
{
	/// <summary>
	/// Summary description for RegexItem.
	/// </summary>
	public abstract class RegexItem
	{
		public RegexItem()
		{
		}

		public void Parse(string expression)
		{

		}

		public abstract string ToString(int indent);
	}
}
