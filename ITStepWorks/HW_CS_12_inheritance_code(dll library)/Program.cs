using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_CS_12_inheritance_code_dll_library_ {
	class Program {
		static void Main(string[] args) {
			WinApi.SetConsoleCtrlHandler(new WinApi.HandlerRoutine(WinApi.ConsoleCtrlCheck), true);
			#region Task 1 get diagonal
			using (System.Drawing.Graphics grfx = System.Drawing.Graphics.FromHwnd(IntPtr.Zero)) {
				var result = WinApi.GetDisplayInfo(grfx);
				Console.WriteLine($"Monitor driver: {result.drvVersion};\nWidth: {result.wSize} mm;\nHight: {result.hSize} mm;\nDiagonal: {result.diagonal/25,4:F2} inch;");
				Console.WriteLine($"dpi/inch: {grfx.DpiX} x {grfx.DpiY}");
			}
			#endregion

			#region Task 2 set resolution
			int w, h;
			Console.WriteLine("Enter display resolution");
			if(Int32.TryParse(Console.ReadLine(), out w)  && Int32.TryParse(Console.ReadLine(), out h))
				if(!WinApi.ChangeResolution(w, h)) Console.WriteLine("Error, resolution have not set!!!");
			#endregion

			#region Task 3 shutdown
			Console.WriteLine("Enter next key:\n[S] - to shutdown\n[R] - to reboot\n[L] - to logoff");
			switch (Console.ReadKey(false).Key) {
				case ConsoleKey.S: WinApi.Shutdown(); break;
				case ConsoleKey.R: WinApi.Reboot(); break;
				case ConsoleKey.L: WinApi.LogOff(); break;
				default: WinApi.Shutdown(); break;
			}
			#endregion
			
		}
	}
}
