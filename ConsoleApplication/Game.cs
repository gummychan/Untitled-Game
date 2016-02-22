using System;
using System.Threading;
namespace UntitledGame
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Title = "Waiting for correct input";
			// Sets window title to anything inside the quotes.
			Console.Clear ();
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine ("The meaning of life is this game");
			Console.ForegroundColor = ConsoleColor.Gray;
			Thread.Sleep (3000);
			bool v1 = true;
			do {
				// Loops anything inside the do {} tags.
				Console.Clear ();
				Console.WriteLine ("What is the meaning of life?");
				string pass = Console.ReadLine ();
				if (pass == "this game") {
					Console.Clear ();
					Console.WriteLine ("Yes it is");
					Thread.Sleep (2000);
					v1 = false;
				} else {
					Console.Clear ();
					Console.WriteLine ("Incorrect answer");
					Thread.Sleep (2000);
					// If the input equals "this game", end the loop. If not, loop until correct input is given.
				}
			} while (v1 == true);
			Console.Title = "Untitled Game";
			Console.Clear ();
			Console.WriteLine ("Written by a faggot");
			Thread.Sleep (3000);
			bool v2 = true;
			do {
				Console.Clear ();
				Console.WriteLine ("Untitled Game");
				Console.WriteLine ("1. Start Game");
				Console.WriteLine ("2. Quit Game");
				// Main menu.
				string menuoption = Console.ReadLine ();
				if (menuoption == "1") {
					Console.Clear ();
					Console.WriteLine ("Starting Game...");
					Thread.Sleep (2000);
					v2 = false;
				}
				// If the user input is 1, start the game.
					else if (menuoption == "2") {
					Console.WriteLine ("Goodbye!");
					Thread.Sleep (2000);
					return;
				}
				// If the user input is 2, end the game.
				else {
					Console.Clear ();
					Console.WriteLine ("Please enter a valid option");
					Thread.Sleep (2000);
				}
				// If the user input is neither 1 or 2, loop the main menu.
			} while (v2 == true);
			Console.Clear ();
			Console.WriteLine ("Once upon a time");
			Thread.Sleep (3000);
			Console.Clear ();
			Console.WriteLine ("In the land of Autism");
			Thread.Sleep (3000);
			Console.Clear ();
			Console.WriteLine ("One boy, got fucked so hard");
			Thread.Sleep (3000);
			Console.Clear ();
			Console.WriteLine ("He died of autism. The End");
			Thread.Sleep (3000);
			Console.Clear ();
			return;
		}
	}
}
