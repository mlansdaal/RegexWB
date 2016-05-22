using System;
using NUnit.Framework;

namespace RegexTest
{
	/// <summary>
	/// Summary description for TestInterpretAnchor.
	/// </summary>
	[TestFixture]
	public class TestInterpretGrouping
	{
		public TestInterpretGrouping()
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
		public void TestCapture()
		{
			string output = Interpret("(abc)");
			Assert.AreEqual("Capture\r\n  abc\r\nEnd Capture\r\n", output);
		}

		[Test]
		public void TestNamedCapture()
		{
			string output = Interpret("(?<L>abc)");
			Assert.AreEqual("Capture to <L>\r\n  abc\r\nEnd Capture\r\n", output);
		}

		[Test]
		public void TestNonCapture()
		{
			string output = Interpret("(?:abc)");
			Assert.AreEqual("Non-capturing Group\r\n  abc\r\nEnd Capture\r\n", output);
		}

		[Test]
		public void TestAlternation()
		{
			string output = Interpret("(a|b)");
			Assert.AreEqual("Capture\r\n  a\r\n    or\r\n  b\r\nEnd Capture\r\n", output);
		}

			// lookahead/lookbehind

		[Test]
		public void TestPositiveLookahead()
		{
			string output = Interpret("(?=a)");
			Assert.AreEqual("zero-width positive lookahead\r\n  a\r\nEnd Capture\r\n", output);
		}

		[Test]
		public void TestNegativeLookahead()
		{
			string output = Interpret("(?!b)");
			Assert.AreEqual("zero-width negative lookahead\r\n  b\r\nEnd Capture\r\n", output);
		}

		[Test]
		public void TestPositiveLookbehind()
		{
			string output = Interpret("(?<=c)");
			Assert.AreEqual("zero-width positive lookbehind\r\n  c\r\nEnd Capture\r\n", output);
		}

		[Test]
		public void TestNegativeLookbehind()
		{
			string output = Interpret("(?<!d)");
			Assert.AreEqual("zero-width negative lookbehind\r\n  d\r\nEnd Capture\r\n", output);
		}

			// Conditionals
		[Test]
		public void TestConditionalExpression()
		{
			string output = Interpret("(?(abc)yes|no)");
			Assert.AreEqual("Conditional Subexpression\r\n  if: abc\r\n  match: yes\r\n  else match: no\r\nEnd Capture\r\n", output);
		}

		[Test]
		public void TestConditionalNamed()
		{
			string output = Interpret("(?(<V>)yes|no)");
			Assert.AreEqual("Conditional Subexpression\r\n  if: <V>\r\n  match: yes\r\n  else match: no\r\nEnd Capture\r\n", output);
		}
	}
}

#if fred

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
