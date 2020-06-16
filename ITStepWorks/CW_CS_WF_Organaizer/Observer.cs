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

        public void AddObserver(IObserver o) {
            orgnzr.Add(o);
        }

        public void RemoveObserver(IObserver o) {
            orgnzr.Remove(o);
        }

        public void NotifyObservers() {
            foreach (IObserver o in orgnzr)
                o.Update(this);
        }
    }
}
