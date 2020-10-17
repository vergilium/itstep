using Newtonsoft.Json;
using SocketServer.Commands;
using SocketServer.Models;
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
			Console.ReadKey();
		}

		private static void clientCallback(IAsyncResult ar) {
			TcpListener listener = ar.AsyncState as TcpListener;
			TcpClient client = listener.EndAcceptTcpClient(ar);
			listener.BeginAcceptTcpClient(clientCallback, listener);
			try {
				StreamReader reader = new StreamReader(client.GetStream(), Encoding.UTF8);
				StreamWriter writer = new StreamWriter(client.GetStream(), Encoding.UTF8) { AutoFlush = true };

				MSG message = null;

				IPAddress remoteAddr = (client.Client.RemoteEndPoint as IPEndPoint).Address;
				Console.WriteLine($"Connect from {remoteAddr}");

				do {
					message = JsonConvert.DeserializeObject<MSG>(reader.ReadLine());
					switch (message.command) {
						case "Autorization": break;
						case "Register": RegistrationCommand.GoRegistration(message).Wait(); break;
						case "SendMessage": break;
						case "Disconnect": break;
						default: break;
					}

				}
				while (message.command != "Disconnect");

			}
#pragma warning disable CS0168 // Variable is declared but never used
				catch (Exception e)
#pragma warning restore CS0168 // Variable is declared but never used
            {

            } finally {
				client.Close();
			}
			

		}
	}
}
