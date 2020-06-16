﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.ComponentModel;

namespace Organizer {
	public enum Signal : int { None = 0x00, MesssBox = 0x01, Song = 0x02};

	#region Organizer struct
	/// <summary>
	/// Structure of item organaizer collection
	/// </summary>
	public struct ORGANIZER_ITEM {
		public string sDescription;
		public DateTime dtStartTime;
		public DateTime dtEndTime;
		public Action<Signal> lpSignal;
		public bool isActive;

		public override string ToString() {
			return $"{sDescription} -> {dtStartTime} : {(dtEndTime!=default?dtEndTime:dtStartTime)} {(isActive?"Enable":"Disable")}";
		}
	}
	#endregion

	#region Organizer data binding class
	public class OrganizerDataBindingList<T> : BindingList<T> {
		private List<T> data;
		public OrganizerDataBindingList(int count = 0) {
			data = new List<T>(count);
		}

		public int RemoveAll(Predicate<T> match) {
			int cRemCount = data.RemoveAll(match);
			ResetBindings();
			return cRemCount;
		}

	}

	#endregion

	[Serializable]
	partial class Organizer : IDisposable {
		public OrganizerDataBindingList<ORGANIZER_ITEM> orgList { get; private set; }

		/// <summary>
		/// Organaizer collection constructor
		/// </summary>
		/// <param name="itemCount">Start initial lendth data</param>
		public Organizer(int itemCount = 0) {
			orgList = new OrganizerDataBindingList<ORGANIZER_ITEM>(itemCount);
			this.Add("Test", DateTime.Now, default);
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
		public bool Add(string descr, DateTime start, DateTime end, Action<Signal> sig = null, bool active = true) {
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
