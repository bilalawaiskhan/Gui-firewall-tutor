using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    internal class Packet
    {
        public string sourceIP;
        public string destinationIP;
        public int SourcePort;
        public int DestinationPort;
        public string Protocol;
        public string Data;
        public DateTime Timestamp; // to save Timestamp

        public static int PacketCount = 0;

        public Packet(string sourceIpAddress, string destinationIpAddress, int sourcePort, int destinationPort, string protocol, string data)
        {
            sourceIP = sourceIpAddress;
            destinationIP = destinationIpAddress;
            SourcePort = sourcePort;
            DestinationPort = destinationPort;
            Protocol = protocol;
            Data = data;
         
           
        }

     
    }

   
}
