using System;
using System.Collections.Generic;

namespace Dotnet {
	class Program {
		static void Main (string[] args) {

			//Problem 3
			List<string> listOfSpells = new List<string> () { "Accio", "Expecto Patronum", "Petrificus Totalus", "Muffliato" };
			string rememberSpell = Console.ReadLine();
			List<string> returnedSpells = new List<string> ();
			if (rememberSpell != "") {
				listOfSpells.ForEach (element => {
					if (element.Contains (rememberSpell)) returnedSpells.Add (element);
				});
				if(returnedSpells.Count == 0 ) returnedSpells.Add("Mischief Mangaed");
				returnedSpells.ForEach (element => Console.WriteLine (element));
			} else {	Console.WriteLine("Empty String");	}

			//Problrem 4
			string secretMessage = Console.ReadLine ()
				.Replace ('a', '@').Replace ('A', '@')
				.Replace ('e', '#').Replace ('E', '#')
				.Replace ('i', '*').Replace ('I', '*')
				.Replace ('u', '&').Replace ('U', '&')
				.Replace ('o', '?').Replace ('O', '?');

			Console.WriteLine (secretMessage);
		}

	}
}