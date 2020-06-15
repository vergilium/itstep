using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Organizer {
	public delegate void SignalDelegate(int type);
	public struct ORGANIZER_ITEM {
		public string sDescription;
		public DateTime dtStartTime;
		public DateTime dtEndTime;
		public SignalDelegate lpSignal;
		public bool isActive;
	}
	class Organizer : IDisposable {
		public List<ORGANIZER_ITEM> orgList { get; private set; }

		/// <summary>
		/// Organaizer collection constructor
		/// </summary>
		/// <param name="itemCount">Start initial lendth data</param>
		public Organizer(int itemCount = 0) {
			orgList = new List<ORGANIZER_ITEM>(itemCount);
		}
		/// <summary>
		/// Add new Item into collection
		/// </summary>
		/// <param name="descr">Description of event</param>
		/// <param name="start">Date of start event</param>
		/// <param name="end">Date of End event</param>
		/// <param name="sig">Delegate for signal start event</param>
		/// <param name="active">Flag is active event</param>
		/// <returns>Bool value after end operation</returns>
		public bool Add(string descr, DateTime start, DateTime end, SignalDelegate sig = null, bool active = true) {
			try {
				orgList.Add(new ORGANIZER_ITEM {
					sDescription = descr,
					dtStartTime = start,
					dtEndTime = end,
					lpSignal = sig,
					isActive = active
				});
				return true;
			} catch {
				return false;
			}
		}
		/// <summary>
		/// Remove element at the index
		/// </summary>
		/// <param name="index">Current index at will be removed</param>
		/// <returns>Bool value after oparation</returns>
		public bool RemoveAt(int index) {
			try {
				orgList.RemoveAt(index);
				return true;
			} catch (IndexOutOfRangeException) {
				Debug.WriteLine($"index {index} out of range. Collection contained {orgList.Count} items!");
				return false;
			} catch (Exception e) {
				Debug.WriteLine(e);
				return false;
			}
		}
		/// <summary>
		/// Clear all old events from the collection
		/// </summary>
		/// <returns>Int count removed events</returns>
		public int ClearOldEvents() => orgList.RemoveAll(delegate (ORGANIZER_ITEM x) { return x.dtEndTime < DateTime.Now; });
		/// <summary>
		/// Dispose collection
		/// </summary>
		public void Dispose() {
			orgList.Clear();
		}
	}
}
