using System.Net;
      
namespace StatsDClient
{
    public class StatsD
    {
        private StatsD()
        {
            
        }

        private string host = "";

        public StatsD(string _host)

        {
            host = _host;
        }

		public void Send(string dataGram)
		{
            using (var socket = new System.Net.Sockets.Socket(System.Net.Sockets.AddressFamily.InterNetwork, System.Net.Sockets.SocketType.Dgram, System.Net.Sockets.ProtocolType.Udp)) 
            {
                var serverAddress = Dns.GetHostEntry(host);
                var endPoint = new IPEndPoint(serverAddress.AddressList[0], 8125);
                var bytes = System.Text.Encoding.UTF8.GetBytes(dataGram);
                socket.SendTo(bytes, endPoint);
            }
		}
    }
}
