
#region Change History

// DATE------  CHANGED BY---  CHANGEID#  DESCRIPTION---------------------------
// 2015-05-17  M. Lansdaal    n/a        Initial version.
// 2015-06-13  M. Lansdaal    n/a        PlayerInfo deprecated. Replaced by PerformanceInfo
//

#endregion



using System;
using NUnit.Framework;

namespace RegexTest
{
	/// <summary>
	/// Summary description for TestInterpret.
	/// </summary>
	[TestFixture]
	public class TestInterpret
	{
		public TestInterpret()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		string Interpret(string regex)
		{
			RegexBuffer buffer = new RegexBuffer(regex);
			RegexExpression expression = new RegexExpression(buffer);
			string output = expression.ToString(0);
			return output;
		}

		[Test]
		public void TestNormalChars()
		{
			string output = Interpret("Test");
			Assert.AreEqual("Test\r\n", output);
		}


		[Test]
		public void TestCharacterShortcuts()
		{
			string output = Interpret(@"\a");
			Assert.AreEqual("A bell (alarm) \\u0007 \r\n", output);

			output = Interpret(@"\t");
			Assert.AreEqual("A tab \\u0009 \r\n", output);
			
			output = Interpret(@"\r");
			Assert.AreEqual("A carriage return \\u000D \r\n", output);
			
			output = Interpret(@"\v");
			Assert.AreEqual("A vertical tab \\u000B \r\n", output);
			
			output = Interpret(@"\f");
			Assert.AreEqual("A form feed \\u000C \r\n", output);
			
			output = Interpret(@"\n");
			Assert.AreEqual("A new line \\u000A \r\n", output);

			output = Interpret(@"\e");
			Assert.AreEqual("An escape \\u001B \r\n", output);

			output = Interpret(@"\xFF");
			Assert.AreEqual("Hex FF\r\n", output);

			output = Interpret(@"\cC");
			Assert.AreEqual("CTRL-C\r\n", output);

			output = Interpret(@"\u1234");
			Assert.AreEqual("Unicode 1234\r\n", output);
		}

		[Test]
		public void TestCharacterGroup()
		{
			string output = Interpret("[abcdef]");
			Assert.AreEqual("Any character in \"abcdef\"\r\n", output);
		}

		[Test]
		public void TestCharacterGroupNegated()
		{
			string output = Interpret("[^abcdef]");
			Assert.AreEqual("Any character not in \"abcdef\"\r\n", output);
		}

		[Test]
		public void TestCharacterPeriod()
		{
			string output = Interpret(".");
			Assert.AreEqual(". (any character)\r\n", output);
		}

		[Test]
		public void TestCharacterWord()
		{
			string output = Interpret(@"\w");
			Assert.AreEqual("Any word character \r\n", output);
		}

		[Test]
		public void TestCharacterNonWord()
		{
			string output = Interpret(@"\W");
			Assert.AreEqual("Any non-word character \r\n", output);
		}
		
		[Test]
		public void TestCharacterWhitespace()
		{
			string output = Interpret(@"\s");
			Assert.AreEqual("Any whitespace character \r\n", output);
		}

		
		[Test]
		public void TestCharacterNonWhitespace()
		{
			string output = Interpret(@"\S");
			Assert.AreEqual("Any non-whitespace character \r\n", output);
		}
		
		[Test]
		public void TestCharacterDigit()
		{
			string output = Interpret(@"\d");
			Assert.AreEqual("Any digit \r\n", output);
		}
		
		[Test]
		public void TestCharacterNonDigit()
		{
			string output = Interpret(@"\D");
			Assert.AreEqual("Any non-digit \r\n", output);
		}

		[Test]
		public void TestQuantifierPlus()
		{
			string output = Interpret(@"+");
			Assert.AreEqual("+ (one or more times)\r\n", output);
		}
		
		[Test]
		public void TestQuantifierStar()
		{
			string output = Interpret(@"*");
			Assert.AreEqual("* (zero or more times)\r\n", output);
		}
		
		[Test]
		public void TestQuantifierQuestion()
		{
			string output = Interpret(@"?");
			Assert.AreEqual("? (zero or one time)\r\n", output);
		}
		
		[Test]
		public void TestQuantifierFromNToM()
		{
			string output = Interpret(@"{1,2}");
			Assert.AreEqual("At least 1, but not more than 2 times\r\n", output);
		}
		
		[Test]
		public void TestQuantifierAtLeastN()
		{
			string output = Interpret(@"{5,}");
			Assert.AreEqual("At least 5 times\r\n", output);
		}		

		[Test]
		public void TestQuantifierExactlyN()
		{
			string output = Interpret(@"{12}");
			Assert.AreEqual("Exactly 12 times\r\n", output);
		}

		[Test]
		public void TestQuantifierPlusNonGreedy()
		{
			string output = Interpret(@"+?");
			Assert.AreEqual("+ (one or more times) (non-greedy)\r\n", output);
		}
		
		[Test]
		public void TestQuantifierStarNonGreedy()
		{
			string output = Interpret(@"*?");
			Assert.AreEqual("* (zero or more times) (non-greedy)\r\n", output);
		}
		
		[Test]
		public void TestQuantifierQuestionNonGreedy()
		{
			string output = Interpret(@"??");
			Assert.AreEqual("? (zero or one time) (non-greedy)\r\n", output);
		}
		
		[Test]
		public void TestQuantifierFromNToMNonGreedy()
		{
			string output = Interpret(@"{1,2}?");
			Assert.AreEqual("At least 1, but not more than 2 times (non-greedy)\r\n", output);
		}
		
		[Test]
		public void TestQuantifierAtLeastNNonGreedy()
		{
			string output = Interpret(@"{5,}?");
			Assert.AreEqual("At least 5 times (non-greedy)\r\n", output);
		}		

		[Test]
		public void TestQuantifierExactlyNNonGreedy()
		{
			string output = Interpret(@"{12}?");
			Assert.AreEqual("Exactly 12 times (non-greedy)\r\n", output);
		}
	}
}

#if fred


= "Beginning of string - ^";
= "Beginning, multiline - \\A";
= "End of string - $";
= "End, multiline - \\Z";
= "End, multiline -  \\z";
= "Word boundary - \\b";
= "Non-word boundary - \\B";
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
