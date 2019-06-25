using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;

namespace ClientConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpClient client = new TcpClient();

            client.Connect(IPAddress.Parse("127.0.0.1"), 12345);
            NetworkStream networkStream = new NetworkStream(client.Client);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            var UserList = binaryFormatter.Deserialize(networkStream);

            //List<string> User = (List<string>) binaryFormatter.Deserialize();
            //foreach ()
            //{
               //Console.WriteLine(item);
            //}
            foreach (var item in (List<string>)UserList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
