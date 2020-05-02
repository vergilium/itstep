using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_CS_9_Tamagochi {
	class Program {
		static void Main(string[] args) {
			GRFX.InitDefault();
			Game Tamagochi = new Game();
			SmartMenu.Menu mainMenu = new SmartMenu.Menu(Console.BufferWidth / 2, Console.BufferHeight / 2, fgColor: ConsoleColor.Green);
			mainMenu.Add("  NEW GAME  ", delegate { Tamagochi.Start(); });
			mainMenu.Add(" VIEW  INFO ", delegate { GRFX.ShowInfo(); }); 
			mainMenu.Add("    EXIT    ", delegate { Process.GetCurrentProcess().Kill(); });

			GRFX.WriteMenuBG();
			mainMenu.Show();



			Console.ReadKey(false);
		}
	}
}
