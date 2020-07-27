using System;
using System.Collections.Generic;

namespace Dotnet {
	class Program {
		static void Main (string[] args) {

			char[] balanced = { '{', '[', ']', '{', '}', '(', '{', '}', ')', '}' };
			char[] unbalanced = { '{', '}', '(', '{', '(', '}', ')', ')' };
			char[] test = {};
			// Console.WriteLine ("String - {0}" ,CheckBalanceOrUnbalanceString (balanced));
			// Console.WriteLine ("String - {0}" ,CheckBalanceOrUnbalanceString (unbalanced));
			Console.WriteLine(CheckBalanceOrUnbalanceString(test));

		}
		private static string CheckBalanceOrUnbalanceString (char[] brackets) {
			char[] bracketIndex = { '[', ']', '{', '}', '(', ')' };
			Stack<char> bracketStack = new Stack<char> ();
			foreach (char bracket in brackets) {
				
				if ((bracketStack.Count == 0) && (
					bracket == bracketIndex[1] ||
					bracket == bracketIndex[3] ||
					bracket == bracketIndex[5]))
					return "UnBalanced";
			
				// Empty List and First Character
				if(bracketStack.Count == 0){ bracketStack.Push(bracket); continue;};
				
				// Empty List and First Character
				if (bracket == bracketIndex[0] ||
					bracket == bracketIndex[2] ||
					bracket == bracketIndex[4]){
					bracketStack.Push(bracket);
					continue;
					}

				// Check this condition last open bracket '[' and next is closed ']'
				if (bracketStack.Peek () == bracketIndex[0] && bracket == bracketIndex[1] ||
					bracketStack.Peek () == bracketIndex[2] && bracket == bracketIndex[3] ||
					bracketStack.Peek () == bracketIndex[4] && bracket == bracketIndex[5] )
					bracketStack.Pop(); 
				else return "UnBalanced";

			}
			if(bracketStack.Count != 0) return "Unbalanced";
		return "Balanced";
		}

	}
}