using System;

namespace HW_CS_9_Tamagochi {
	static class GRFX {
		private static readonly int m_windowWidth = 80;
		private static readonly int m_windowHeight = 25;

		public static void InitDefault() {
			Console.SetWindowSize(m_windowWidth, m_windowHeight);
			Console.SetBufferSize(m_windowWidth, m_windowHeight);
			Console.CursorVisible = false;
			Console.SetCursorPosition(0, 0);
			Console.Clear();
			Console.BackgroundColor = ConsoleColor.Black;
			Console.ForegroundColor = ConsoleColor.Green;
		}

		//public static void TimeCounterShow(int x, int y) {
		//	DateTime timer = new DateTime(1,1,1,0,0,0);
		//	timer.AddSeconds(1);
		//	Console.BackgroundColor = ConsoleColor.Black;
		//	Console.ForegroundColor = ConsoleColor.Green;
		//	Console.SetCursorPosition(x,y);
		//	Console.Write(timer.ToString("hh:mm:ss"));
		//}

		private static void Clear() {
			Console.Clear();
			Console.BackgroundColor = ConsoleColor.Black;
			Console.ForegroundColor = ConsoleColor.Green;
		}
		public static void WriteMenuBG() {
			Clear();
			Console.SetCursorPosition(0, m_windowHeight/2-3);
			Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════╗");
			Console.WriteLine("║                                                                             ║");
			Console.WriteLine("║                                                                             ║");
			Console.WriteLine("║                                                                             ║");
			Console.WriteLine("║                                                                             ║");
			Console.WriteLine("║                                                                             ║");
			Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════╝");
		}

		public static void WriteGameCanvas() {
			Clear();
			Console.SetCursorPosition(0,0);
			Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════╗");
			Console.WriteLine("║                                                                             ║");
			Console.WriteLine("║                                                                             ║");
			Console.WriteLine("║                                                                             ║");
			Console.WriteLine("║                                                                             ║");
			Console.WriteLine("║                                                                             ║");
			Console.WriteLine("║                                                                             ║");
			Console.WriteLine("║                                                                             ║");
			Console.WriteLine("║                                                                             ║");
			Console.WriteLine("║                                                                             ║");
			Console.WriteLine("║                                                                             ║");
			Console.WriteLine("║                                                                             ║");
			Console.WriteLine("║                                                                             ║");
			Console.WriteLine("║                                                                             ║");
			Console.WriteLine("║                                                                             ║");
			Console.WriteLine("║                                                                             ║");
			Console.WriteLine("║                                                                             ║");
			Console.WriteLine("║                                                                             ║");
			Console.WriteLine("║                                                                             ║");
			Console.WriteLine("║                                                                             ║");
			Console.WriteLine("║                                                                             ║");
			Console.WriteLine("║                                                                             ║");
			Console.WriteLine("║                                                                             ║");
			Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════╝");
		}

		public static void ShowPet(int x, int y) {
			Console.ForegroundColor = ConsoleColor.Gray;
			Console.SetCursorPosition(x, y);   Console.Write(@"  .--,       .--,  ");
			Console.SetCursorPosition(x, y+1); Console.Write(@" ((   \.---./   )) ");
			Console.SetCursorPosition(x, y+2); Console.Write(@"  '.__/o   o\__.'  ");
			Console.SetCursorPosition(x, y+3); Console.Write(@"     {=  ^  =}     ");
			Console.SetCursorPosition(x, y+4); Console.Write(@"      >  -  <      ");
			Console.SetCursorPosition(x, y+5); Console.Write(@"     /       \     ");
			Console.SetCursorPosition(x, y+6); Console.Write(@"    //        \\   ");
			Console.SetCursorPosition(x, y+7); Console.Write(@"   //|   .    |\\  ");
			Console.SetCursorPosition(x, y+8); Console.Write(@"  '''\        /'''_.- ~^`'-.");
			Console.SetCursorPosition(x, y+9); Console.Write(@"      \   _  / --' ");
			Console.SetCursorPosition(x, y+10);Console.Write(@"    ___) ( )(___   ");
			Console.SetCursorPosition(x, y+11);Console.Write(@"   (((__)   (__))) ");
		}

		public static void ShowInfo() {
			Clear();
			Console.Write(@"  
    ██╗   ██╗██████╗  ██████╗  ██╗ █████╗       ██╗   ██╗██████╗ 
    ██║   ██║██╔══██╗██╔═══██╗███║██╔══██╗      ██║   ██║╚════██╗
    ██║   ██║██████╔╝██║   ██║╚██║╚██████║█████╗██║   ██║ █████╔╝
    ╚██╗ ██╔╝██╔═══╝ ██║   ██║ ██║ ╚═══██║╚════╝╚██╗ ██╔╝██╔═══╝ 
     ╚████╔╝ ██║     ╚██████╔╝ ██║ █████╔╝       ╚████╔╝ ███████╗
      ╚═══╝  ╚═╝      ╚═════╝  ╚═╝ ╚════╝         ╚═══╝  ╚══════╝  

 Develope by Maloivan Oleksii Oleksandrovich for IT STEP Academy


▄▄▄█████▓ ▄▄▄       ███▄ ▄███▓ ▄▄▄        ▄████  ▒█████   ▄████▄   ██░ ██  ██▓
▓  ██▒ ▓▒▒████▄    ▓██▒▀█▀ ██▒▒████▄     ██▒ ▀█▒▒██▒  ██▒▒██▀ ▀█  ▓██░ ██▒▓██▒
▒ ▓██░ ▒░▒██  ▀█▄  ▓██    ▓██░▒██  ▀█▄  ▒██░▄▄▄░▒██░  ██▒▒▓█    ▄ ▒██▀▀██░▒██▒
░ ▓██▓ ░ ░██▄▄▄▄██ ▒██    ▒██ ░██▄▄▄▄██ ░▓█  ██▓▒██   ██░▒▓▓▄ ▄██▒░▓█ ░██ ░██░
  ▒██▒ ░  ▓█   ▓██▒▒██▒   ░██▒ ▓█   ▓██▒░▒▓███▀▒░ ████▓▒░▒ ▓███▀ ░░▓█▒░██▓░██░
  ▒ ░░    ▒▒   ▓▒█░░ ▒░   ░  ░ ▒▒   ▓▒█░ ░▒   ▒ ░ ▒░▒░▒░ ░ ░▒ ▒  ░ ▒ ░░▒░▒░▓  
    ░      ▒   ▒▒ ░░  ░      ░  ▒   ▒▒ ░  ░   ░   ░ ▒ ▒░   ░  ▒    ▒ ░▒░ ░ ▒ ░
  ░        ░   ▒   ░      ░     ░   ▒   ░ ░   ░ ░ ░ ░ ▒  ░         ░  ░░ ░ ▒ ░
               ░  ░       ░         ░  ░      ░     ░ ░  ░ ░       ░  ░  ░ ░  
                                                         ░                    
");
			Console.ReadKey(false);
		}

		public static void ShowDead() {
			Clear();
			Console.ForegroundColor = ConsoleColor.Red;
			Console.Write(@"


                             TAMAGOCHI IS
                   		
                   ▓█████▄ ▓█████ ▄▄▄      ▓█████▄ 
                   ▒██▀ ██▌▓█   ▀▒████▄    ▒██▀ ██▌
                   ░██   █▌▒███  ▒██  ▀█▄  ░██   █▌
                   ░▓█▄   ▌▒▓█  ▄░██▄▄▄▄██ ░▓█▄   ▌
                   ░▒████▓ ░▒████▒▓█   ▓██▒░▒████▓ 
                    ▒▒▓  ▒ ░░ ▒░ ░▒▒   ▓▒█░ ▒▒▓  ▒ 
                    ░ ▒  ▒  ░ ░  ░ ▒   ▒▒ ░ ░ ▒  ▒ 
                    ░ ░  ░    ░    ░   ▒    ░ ░  ░ 
                      ░       ░  ░     ░  ░   ░    
                    ░                       ░      
");
		}
	}
}
