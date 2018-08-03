using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace Dysoft.Utils.Communicator
{
    public class TcpState
    {
        public NetworkStream Stream { get; set; }
        public byte[] Buffer { get; set; }
        public string ID { get; set; }
        public TcpClient Client { get; set; }

        public TcpState(TcpClient client)
        {
            this.Client = client;
            this.Buffer = new byte[client.ReceiveBufferSize];
            this.Stream = client.GetStream();
            this.ID = client.Client.RemoteEndPoint.ToString();
        }
    }
}
