using System;
using NUnit.Framework;

namespace RegexTest
{
	/// <summary>
	/// Summary description for TestInterpretOptions
	/// </summary>
	[TestFixture]
	public class TestInterpretOptions
	{
		public TestInterpretOptions()
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
		public void TestIgnoreCase()
		{
			string output = Interpret("(?i:)");
			Assert.AreEqual("Set options to Ignore Case\r\n", output);
		}

		public void TestIgnoreCaseOff()
		{
			string output = Interpret("(?-i:)");
			Assert.AreEqual("Set options to Ignore Case Off\r\n", output);
		}

		public void TestMultiline()
		{
			string output = Interpret("(?m:)");
			Assert.AreEqual("Set options to Multiline\r\n", output);
		}

		public void TestMultilineOff()
		{
			string output = Interpret("(?-m:)");
			Assert.AreEqual("Set options to Multiline Off\r\n", output);
		}

		public void TestExplicitCapture()
		{
			string output = Interpret("(?n:)");
			Assert.AreEqual("Set options to Explicit Capture\r\n", output);
		}

		public void TestExplicitCaptureOff()
		{
			string output = Interpret("(?-n:)");
			Assert.AreEqual("Set options to Explicit Capture Off\r\n", output);
		}

		public void TestSingleline()
		{
			string output = Interpret("(?s:)");
			Assert.AreEqual("Set options to Singleline\r\n", output);
		}

		public void TestSinglelineOff()
		{
			string output = Interpret("(?-s:)");
			Assert.AreEqual("Set options to Singleline Off\r\n", output);
		}

		public void TestIgnoreWhitespace()
		{
			string output = Interpret("(?x:)");
			Assert.AreEqual("Set options to Ignore Whitespace\r\n", output);
		}

		public void TestIgnoreWhitespaceOff()
		{
			string output = Interpret("(?-x:)");
			Assert.AreEqual("Set options to Ignore Whitespace Off\r\n", output);
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
