using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace ServerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> user = new List<string>();

            TcpListener server = new TcpListener(IPAddress.Parse("0.0.0.0"), 12345);

            server.Start(100);
            //TcpClient client = server.AcceptTcpClient();
            //Работа с подключенным клиентом
            Socket client = server.AcceptSocket();

            NetworkStream networkStream = new NetworkStream(client);
            BinaryFormatter binaryFormatter = new BinaryFormatter();

            user.Add("User 1");
            user.Add("User 2");
            user.Add("User 3");
            binaryFormatter.Serialize(networkStream, user);
            //networkStream.Flush();
            Thread.Sleep(2000);
            //client.Client.Send();
        }
    }
}
