using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;

namespace SocketServer {
	class Program {
		static void Main(string[] args) {
			Listener listener;
			var IPs = Listener.getSystemAdresses();

			Console.WriteLine("Выберите доступный ip адресс для сервера:");
			int counter = 1;
			foreach(var ip in IPs) {
				Console.WriteLine($"{counter++}: {ip.ToString()}");
			}

			Console.WriteLine("Введите номер: ");
			if(!Int32.TryParse(Console.ReadLine(), out counter)) {
				Console.WriteLine("Error enter numder. Good by!");
				return;
			} else {
				if(counter > IPs.Length) {
					Console.WriteLine("Введенное число больше чем колличество вариантов! ");
					return;
				}
			}
			try {
				listener = new Listener(IPs[counter - 1], 1024);

				listener.On(10);
				listener.BeginAcceptTcpClient(clientCallback, listener);
			} catch (Exception ex) {
				Console.WriteLine(ex.Message);
			}
			while (true);
		}

		private static void clientCallback(IAsyncResult ar) {
			TcpListener listener = ar.AsyncState as TcpListener;
			TcpClient client = listener.EndAcceptTcpClient(ar);

			StreamReader reader = new StreamReader(client.GetStream(), Encoding.UTF8);
			StreamWriter writer = new StreamWriter(client.GetStream(), Encoding.UTF8);


		}
	}
}
