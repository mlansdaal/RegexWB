using System;
using NUnit.Framework;

namespace RegexTest
{
	/// <summary>
	/// Summary description for TestInterpretAnchor.
	/// </summary>
	[TestFixture]
	public class TestInterpretAnchor
	{
		public TestInterpretAnchor()
		{
		}

		string Interpret(string regex)
		{
			RegexBuffer buffer = new RegexBuffer(regex);
			RegexExpression expression = new RegexExpression(buffer);
			string output = expression.ToString(0);
			return output;
		}

		[Test]
		public void TestBegOfString()
		{
			string output = Interpret("^");
			Assert.AreEqual("^ (anchor to start of string)\r\n", output);
		}

		[Test]
		public void TestBegOfStringMultiline()
		{
			string output = Interpret("\\A");
			Assert.AreEqual("Anchor to start of string (ignore multiline)\r\n", output);
		}

		[Test]
		public void TestEndOfString()
		{
			string output = Interpret("$");
			Assert.AreEqual("$ (anchor to end of string)\r\n", output);
		}

		[Test]
		public void TestEndOfStringMultiline()
		{
			string output = Interpret("\\Z");
			Assert.AreEqual("Anchor to end of string or before \\n (ignore multiline)\r\n", output);
		}

		[Test]
		public void TestEndOfStringMultiline2()
		{
			string output = Interpret("\\z");
			Assert.AreEqual("Anchor to end of string (ignore multiline)\r\n", output);
		}

		public void TestWordBoundary()
		{
			string output = Interpret("\\b");
			Assert.AreEqual("Word boundary between //w and //W\r\n", output);
		}
		public void TestNonWordBoundary()
		{
			string output = Interpret("\\B");
			Assert.AreEqual("Not at a word boundary between //w and //W\r\n", output);
		}

	}
}

#if fred

= "Grouping";
= "Capture - (<exp>)";
= "Named capture - (?<<name>>x)";
= "Non-capture - (?:<exp>)";
= "Alternation - (<x>|<y>)";
= "Zero-Width";
= "Positive Lookahead - (?=<x>)";
= "Negative Lookahead - (?!<x>)";
= "Positive Lookbehind - (?<=<x>)";
= "Negative Lookbehind - (?<!<x>)";
= "Conditionals";
= "Expression - (?(<exp>)yes|no)";
= "Named - (?(<name>)yes|no)";
= "Options";
= "Ignore Case - (?i)";
= "Ignore Case off - (?-i)";
= "Multline - (?m)";
= "Multiline off - (?-m)";
= "Explicit Capture - (?c)";
= "Explicit Capture off - (?-c)";
= "Singleline - (?s)";
= "Singleline off - (?-s)";
= "Ignore Whitespace - (?x)";
= "Ignore Whitespace off - (?-x)";


#endif
