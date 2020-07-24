using System;

namespace Dotnet {
	class Program {
		static void Main (string[] args) {

			Console.Write ("Please type number: ");
			Console.WriteLine ("The Number is - {0}", EvenOddFunction (int.Parse (Console.ReadLine ())));

			Console.Write("Plese Type String: ");
			Console.WriteLine ("The Sum is - {0}", CalculateCommaSeperatedValues (Console.ReadLine()));

		}
		private static int CalculateCommaSeperatedValues (string commaSeperatedString) {
			int sum = 0;
			foreach (string item in commaSeperatedString.Split (',')) {
				if (int.Parse (item) < 0) continue;
				sum += int.Parse (item);
			}
			return sum;
		}
		private static string EvenOddFunction (int number) { return (number % 2 == 0) ? "Even" : "Odd"; }

	}
}
