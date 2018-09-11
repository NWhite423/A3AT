using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3AT
{
    public class Server
    {
        public string Name { get; set; }
        public string IP { get; set; }
        public int Port { get; set; }
        public Server (string name, string ip, int port) {
            Name = name;
            IP = ip;
            Port = port;
        }
    }
}
