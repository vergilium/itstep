using System;
using System.Collections.Generic;

namespace HW_CS_ADO_Connection_HR_base_ {
	public interface IObserver {
		void Update(object ob);
	}
	public interface IObservable {
		void AddObserver(IObserver o);
		void RemoveObserver(IObserver o);
		void NotifyObservers();
	}
	public partial class DAL : IObservable {
		[NonSerialized]
		private List<IObserver> dbdata;

		/// <summary>
		/// Add class to observer list
		/// </summary>
		/// <param name="o">IObserver type class</param>
		public void AddObserver(IObserver o) {
			dbdata.Add(o);
		}
		/// <summary>
		/// Remove from observer list
		/// </summary>
		/// <param name="o">IObserver type class</param>
		public void RemoveObserver(IObserver o) {
			dbdata.Remove(o);
		}
		/// <summary>
		/// Updates obsrver values
		/// </summary>
		public void NotifyObservers() {
			foreach (IObserver o in dbdata)
				o.Update(this);
		}

	}
}
