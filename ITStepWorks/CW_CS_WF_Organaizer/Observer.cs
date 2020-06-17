using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Organizer {
	public interface IObserver {
		void Update(object ob);
	}
	public interface IObservable {
		void AddObserver(IObserver o);
		void RemoveObserver(IObserver o);
		void NotifyObservers();
	}
    public partial class Organizer : IObservable {


        private List<IObserver> orgnzr = new List<IObserver>();
        /// <summary>
        /// Add class to observer list
        /// </summary>
        /// <param name="o">IObserver type class</param>
        public void AddObserver(IObserver o) {
            orgnzr.Add(o);
        }
        /// <summary>
        /// Remove from observer list
        /// </summary>
        /// <param name="o">IObserver type class</param>
        public void RemoveObserver(IObserver o) {
            orgnzr.Remove(o);
        }
        /// <summary>
        /// Updates obsrver values
        /// </summary>
        public void NotifyObservers() {
            foreach (IObserver o in orgnzr)
                o.Update(this);
        }
    }
}
