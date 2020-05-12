using System;
using System.Diagnostics;

namespace HW_CS_9_Tamagochi {
	class Program {
		static void Main(string[] args) {
			GRFX.InitDefault();
			Game Tamagochi = new Game();
			SmartMenu.Menu mainMenu = new SmartMenu.Menu(Console.BufferWidth / 2, Console.BufferHeight / 2, fgColor: ConsoleColor.Green);
			mainMenu.Add("  NEW GAME  ", obj => Tamagochi.Start());
			mainMenu.Add(" VIEW  INFO ", obj => GRFX.ShowInfo()); 
			mainMenu.Add("    EXIT    ", obj => Process.GetCurrentProcess().Kill());

			mainMenu.Show(() => GRFX.WriteMenuBG());

		}
	}
}
