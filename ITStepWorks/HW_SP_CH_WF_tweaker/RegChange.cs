using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_SP_CH_WF_tweaker {

	public static class RegChange {
		public static Dictionary<string, PropertyChange> changeCollection = new Dictionary<string, PropertyChange>{
			{ "autorun_off", new PropertyChange(
					 Registry.LocalMachine,
					 @"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer\",
					 "NoDriveTypeAutoRun",
					 255
			)},
			{ "uac_off", new PropertyChange(
				Registry.LocalMachine,
				@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System\",
				"EnableLUA",
				0
			)},
			{
				"ramDiag_off", new PropertyChange(
				Registry.CurrentUser,
				@"Software\Microsoft\Windows\CurrentVersion\StorageSense\Parameters\StoragePolicy\",
				"01",
				0
			)}
		};
	}


	public class PropertyChange {
		private RegistryKey rootBranch { get; set; }
		private string someBranch { get; set; }
		private string branchKey { get; set; }
		private Object value { get; set; }

		public PropertyChange(RegistryKey root, string branch, string key, Object value) {
			rootBranch = root;
			someBranch = branch;
			branchKey = key;
			this.value = value;
		}
		public bool DoWork() {
			RegistryKey rkey = null;
			try {
				rkey = rootBranch.OpenSubKey(someBranch, true);
				rkey.SetValue(branchKey, value);
				return true;
#pragma warning disable CS0168 // Переменная объявлена, но не используется
			} catch (Exception ex) {
#pragma warning restore CS0168 // Переменная объявлена, но не используется
				return false;
			} finally {
				rkey.Close();
			}
		}
	}
}
