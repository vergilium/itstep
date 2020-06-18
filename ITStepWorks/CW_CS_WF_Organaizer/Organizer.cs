using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.ComponentModel;
using System.Collections;
using System.Windows.Forms;

namespace Organizer {
	public enum Signal : int { None = 0x00, MesssBox = 0x01, Song = 0x02};

	#region Organizer struct
	/// <summary>
	/// Structure of item organaizer collection
	/// </summary>
	public class ORGANIZER_ITEM : IComparer {
		public string sDescription;
		public DateTime dtStartTime;
		public DateTime dtEndTime;
		public Signal eSignal;
		public bool isActive;

		public int Compare(object x, object y) {
			return (x as ORGANIZER_ITEM).dtStartTime.CompareTo((y as ORGANIZER_ITEM).dtStartTime);
		}

		public override string ToString() {
			return $" {dtStartTime} : {sDescription} -> {(isActive?"Enable":"Disable")}";
		}
	}
	#endregion

	#region Organizer data binding class
	public class OrganizerDataBindingList<T> : BindingList<T> {
		private List<T> data;
		public OrganizerDataBindingList(List<T> list) : base(list) {
			data = list;
		}

		public int RemoveAll(Predicate<T> match) {
			int cRemCount = data.RemoveAll(match);
			ResetBindings();
			return cRemCount;
		}

		public void Sort() {
			data?.Sort();
			ResetBindings();
		}

		public void Sort(Comparison<T> comparison) {
			data?.Sort(comparison);
			ResetBindings();
		}
		public void Sort(IComparer<T> comparer) {
			data?.Sort(comparer);
			ResetBindings();
		}

		public void Sort(int index, int count, IComparer<T> comparer) {
			data.Sort(index, count, comparer);
			ResetBindings();
		}

	}

	#endregion

	[Serializable]
	public partial class Organizer : IDisposable {
		public OrganizerDataBindingList<ORGANIZER_ITEM> orgList { get; private set; }
		private bool _disposed = false;
		/// <summary>
		/// Organaizer collection constructor
		/// </summary>
		public Organizer() {
			orgnzr = new List<IObserver>();
			orgList = new OrganizerDataBindingList<ORGANIZER_ITEM>(new List<ORGANIZER_ITEM>());
		}
		/// <summary>
		/// Organaizer collection constructor
		/// </summary>
		/// <param name="obj">Type Organizer</param>
		public Organizer(Organizer obj) {
			orgList = obj.orgList;
			orgnzr = new List<IObserver>();
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
		public bool Add(string descr, DateTime start, DateTime end, Signal sig = Signal.None, bool active = true) {
			try {
				orgList.Add(new ORGANIZER_ITEM {
					sDescription = descr,
					dtStartTime = start,
					dtEndTime = end,
					eSignal = sig,
					isActive = active
				});
				return true;
			} catch {
				return false;
			}
		}
		/// <summary>
		/// Add new Item into collection
		/// </summary>
		/// <param name="item">ORGANIZER_ITEM structure</param>
		/// <returns>Bool value after end operation</returns>
		public bool Add(ORGANIZER_ITEM item) {
			try {
				orgList.Add(item);
				return true;
			} catch {
				return false;
			}
		}

		public bool SetListData(Organizer obj) {
			try {
				orgList = obj.orgList;
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
		/// Get array from planed date
		/// </summary>
		/// <returns>DateTime[] array dates</returns>
		public DateTime[] GetEventDates() {
			return orgList.Select(d => d.dtStartTime).ToArray();
		}
		public ORGANIZER_ITEM GetFirstDate() {
			DateTime dtNow = DateTime.Now;
			try {
				return orgList.First(delegate (ORGANIZER_ITEM o) { return o.dtStartTime >= dtNow.AddMinutes; });
			} catch { return null; }
		}

		public void SignalActive() {
			DateTime dtNow = DateTime.Now;
			ORGANIZER_ITEM first = GetFirstDate();
			if(first != null && first.isActive == true && first.dtStartTime >= dtNow && first.dtStartTime.AddMinutes(1) < dtNow) {
				switch (first.eSignal) {
					case Signal.MesssBox: MessageBox.Show(first.ToString(), "Alarm", MessageBoxButtons.OK, MessageBoxIcon.Information); break;
					case Signal.Song: break;
					default:break;
				}

			}
		}

		/// <summary>
		/// Dispose collection
		/// </summary>
		public void Dispose() => Dispose(true);

		protected virtual void Dispose(bool disposing) {
			if (_disposed) {
				return;
			}

			if (disposing) {
				// Dispose managed state (managed objects).
				orgList?.Clear();
				orgnzr?.Clear();
			}

			_disposed = true;
		}
	}
}
