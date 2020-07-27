using System;
using System.Collections.Generic;

namespace Dotnet {
	class Program {
		static void Main (string[] args) {

			List<string> listOfSpells = new List<string> () { "Accio", "Expecto Patronum", "Petrificus Totalus", "Muffliato" };
			string rememberSpell = "tr";
			List<string> returnedSpells = new List<string> ();
			if(rememberSpell != ""){
				listOfSpells.ForEach (element => {
					if (element.Contains(rememberSpell) == true) returnedSpells.Add(element);
				});
				returnedSpells.ForEach (element => Console.WriteLine (element));
			}
			else{	Console.WriteLine ("Spell Does not Exist"); }

			string message = "Have you finished your warewolves essay? ";
			string secretMessage = message
				.Replace ('a', '@')
				.Replace ('e', '#')
				.Replace ('i', '*')
				.Replace ('o', '?')
				.Replace ('u', '&');
			Console.WriteLine (secretMessage);
	}

}
}