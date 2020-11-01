using System;
using System.Threading.Tasks;
using Seabattle;

namespace Seabattle_ServerTest {
	class Program {
		static void Main(string[] args) {
			Task.Run(()=> DAL.Registration("Vergilium", "Alex", "Maloivan", null, "Maloivan123"));
		}
	}
}
