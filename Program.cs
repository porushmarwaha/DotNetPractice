using System;
using System.Collections.Generic;

namespace Dotnet {
	class Program {
		static void Main (string[] args) {

			char[] balanced = { '{', '[', ']', '{', '}', '(', '{', '}', ')', '}' };
			char[] unbalanced = { '{', '}', '(', '{', '(', '}', ')', ')' };
			char[] CaseOne = {'{', '[', ']', '{', '}', '(', '{', '}', ')', '}'};
			char[] CaseTwo = {'{', '}', '(', '{', '(', '}', ')', ')'};
			char[] CaseThree = {};
			char[] CaseFour = {'1','2','3'};
			char[] CaseFive = {'a','b'};
			char[] CaseSix = {']','['};
			char[] CaseSeven = {'[','{','('};
			char[] CaseEight = {'[','{','}'};

			Console.WriteLine ("Balanced -   {0}", CheckBalanceOrUnbalanceString (balanced));
			Console.WriteLine ("UnBalanced - {0}", CheckBalanceOrUnbalanceString (unbalanced));
			Console.WriteLine ("CaseOne -    {0}", CheckBalanceOrUnbalanceString (CaseOne));
			Console.WriteLine ("CaseTwo -    {0}", CheckBalanceOrUnbalanceString (CaseTwo));
			Console.WriteLine ("CaseThree -  {0}", CheckBalanceOrUnbalanceString (CaseThree));
			Console.WriteLine ("CaseFour -   {0}", CheckBalanceOrUnbalanceString (CaseFour));
			Console.WriteLine ("CaseFive -   {0}", CheckBalanceOrUnbalanceString (CaseFive));
			Console.WriteLine ("CaseSix -    {0}", CheckBalanceOrUnbalanceString (CaseSix));
			Console.WriteLine ("CaseSeven -  {0}", CheckBalanceOrUnbalanceString (CaseSeven));
			Console.WriteLine ("CaseEight -  {0}", CheckBalanceOrUnbalanceString (CaseEight));
		}
		private static string CheckBalanceOrUnbalanceString (char[] brackets) {
			if (brackets.Length == 0) return "No Elements in the array";
			char[] bracketIndex = { '[', ']', '{', '}', '(', ')' };
			Stack<char> bracketStack = new Stack<char> ();
			foreach (char bracket in brackets) {
				if ((bracketStack.Count == 0) && (
						bracket == bracketIndex[1] ||
						bracket == bracketIndex[3] ||
						bracket == bracketIndex[5]))
					return "UnBalanced";

				// Empty List and First Character
				if (bracketStack.Count == 0) { bracketStack.Push (bracket); continue; };

				// Empty List and First Character
				if (bracket == bracketIndex[0] ||
					bracket == bracketIndex[2] ||
					bracket == bracketIndex[4]) {
					bracketStack.Push (bracket);
					continue;
				}

				// Check this condition last open bracket '[' and next is closed ']'
				if (bracketStack.Peek () == bracketIndex[0] && bracket == bracketIndex[1] ||
					bracketStack.Peek () == bracketIndex[2] && bracket == bracketIndex[3] ||
					bracketStack.Peek () == bracketIndex[4] && bracket == bracketIndex[5])
					bracketStack.Pop ();
				else return "UnBalanced";
			}
			if (bracketStack.Count != 0) return "Unbalanced";
			return "Balanced";
		}
	}
}