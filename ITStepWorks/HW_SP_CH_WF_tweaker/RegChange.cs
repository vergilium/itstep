using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_SP_CH_WF_tweaker {

	public static class RegChange {
		public static bool Autorun_off() {
			RegistryKey autorun = null;
			try {
				RegistryKey regLocalMachine = Registry.LocalMachine;
				autorun = regLocalMachine.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer\", true);
				autorun.SetValue("NoDriveTypeAutoRun", 255);
				return true;
#pragma warning disable CS0168 // Переменная объявлена, но не используется
			} catch(Exception ex) {
#pragma warning restore CS0168 // Переменная объявлена, но не используется
				return false;
			} finally {
				autorun.Close();
			}
		}
	}
}
