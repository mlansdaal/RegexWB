using System;
using System.Runtime.Serialization;

namespace RegexTest
{
	/// <summary>
	/// Summary description for Settings.
	/// </summary>
	[Serializable]
	public class Settings: ISerializable
	{
		public string RegexText;
		public string Strings;
		public bool IgnoreWhitespace;
		public bool IgnoreCase;
		public bool Compiled;
		public bool ExplicitCapture;
		public bool Multiline;
		public bool Singleline;
		public string Iterations;
		public bool OneString;
		public string Description;
		public string ReplaceString;
		public bool MatchEvaluator;
		public bool HideGroupZero;

		public Settings()
		{
		}

		public Settings(SerializationInfo info, StreamingContext context)
		{
			try
			{
				RegexText = info.GetString("RegexText");
				Strings = info.GetString("Strings");
				IgnoreWhitespace = info.GetBoolean("IgnoreWhitespace");
				IgnoreCase = info.GetBoolean("IgnoreCase");
				Compiled = info.GetBoolean("Compiled");
				ExplicitCapture = info.GetBoolean("ExplicitCapture");
				Multiline = info.GetBoolean("Multiline");
				Singleline = info.GetBoolean("Singleline");
				Iterations = info.GetString("Iterations");
				OneString = info.GetBoolean("OneString");
				Description = info.GetString("Description");
				ReplaceString = info.GetString("ReplaceString");
				MatchEvaluator = info.GetBoolean("MatchEvaluator");
				HideGroupZero = info.GetBoolean("HideGroupZero");
			}
			catch (Exception)
			{
			}
		}

		public void GetObjectData(SerializationInfo info,
			StreamingContext context)
		{
			info.AddValue("RegexText", RegexText);
			info.AddValue("Strings", Strings);
			info.AddValue("IgnoreWhitespace", IgnoreWhitespace);
			info.AddValue("IgnoreCase", IgnoreCase);
			info.AddValue("Compiled", Compiled);
			info.AddValue("ExplicitCapture", ExplicitCapture);
			info.AddValue("Multiline", Multiline);
			info.AddValue("Singleline", Singleline);
			info.AddValue("Iterations", Iterations);
			info.AddValue("OneString", OneString);
			info.AddValue("Description", Description);
			info.AddValue("ReplaceString", ReplaceString);
			info.AddValue("MatchEvaluator", MatchEvaluator);
			info.AddValue("HideGroupZero", HideGroupZero);
		}
	}
}
