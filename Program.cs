using System;
using System.Collections.Generic;

namespace Dotnet {
	class Program {
		static void Main (string[] args) {

			List<string> listOfSpells = new List<string> () 
				{ "Accio", "Expecto Patronum", "Petrificus Totalus", "Muffliato" };
			string rememberSpell = "tr";
			List<string> returnedSpells = new List<string> ();
			listOfSpells.ForEach (element => {
				if (element.Contains (rememberSpell)) returnedSpells.Add (element);
			});
			returnedSpells.ForEach(element => Console.WriteLine(element));


			string message = "Have you finished your warewolves essay? ";
			string secretMessage = message
			.Replace('a','@')
			.Replace('e','#')
			.Replace('i','*')
			.Replace('o','?')
			.Replace('u','&');
			Console.WriteLine(secretMessage); 
		}


	}
}