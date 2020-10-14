using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace SocketServer {
	public class Listener: TcpListener {
		public Listener(IPAddress ip, int port):base(new IPEndPoint(ip, port)) {
		}
		public static IPAddress[] getSystemAdresses() => Dns.GetHostAddresses(Environment.MachineName);

		public void On(int cntClients) {
			this.Start(cntClients);
			Console.WriteLine($"Server started on {this.LocalEndpoint.ToString()}");
		}
	}
}
