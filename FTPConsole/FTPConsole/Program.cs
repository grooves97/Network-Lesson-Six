using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FTPConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri url = new Uri("http://google.com");
            HttpWebRequest httpWebRequest = (HttpWebRequest)HttpWebRequest.Create(url);


        }
    }
}
