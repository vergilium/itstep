using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace HW_NP_CS_Socket_chat_Client.Models {
    public class SocketClient : Socket {
        private EndPoint ipPoint;
        private byte[] Buffer = new byte[1024];
        public BindingList<byte[]> messages;
        public SocketClient(IPAddress ip, int port = 1024): base(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp) {
            ipPoint = new IPEndPoint(ip, port);
            messages = new BindingList<byte[]>();
            base.Connect(ipPoint);
            base.BeginReceiveFrom(Buffer, 0, 1024, SocketFlags.None, ref ipPoint, DoReceive, this);
        }

		private void DoReceive(IAsyncResult ar) {
			try {
                Socket recvSock = ar.AsyncState as Socket;
                int msgLen = recvSock.EndReceiveFrom(ar, ref ipPoint);
                byte[] localMsg = new byte[msgLen];
                Array.Copy(Buffer, localMsg, msgLen);

                //Start listening for a new message.
                base.BeginReceiveFrom(Buffer, 0, Buffer.Length, SocketFlags.None, ref ipPoint, DoReceive, this);

                //Handle the received message
                Console.WriteLine("Recieved {0} bytes from {1}:{2}",
                                  msgLen,
                                  ((IPEndPoint)ipPoint).Address,
                                  ((IPEndPoint)ipPoint).Port);
				//Do other, more interesting, things with the received message.
#pragma warning disable CS0168 // Variable is declared but never used
			} catch (Exception ex) {
#pragma warning restore CS0168 // Variable is declared but never used
				return;
			}
        }

		public void Connect() => base.Connect(ipPoint);
    
    }
}
