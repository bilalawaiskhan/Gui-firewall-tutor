using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    internal class Rule
{
    public string SourceIP;
    public string DestinationIP;
    public int SourcePort;
    public int DestinationPort;
    public string Protocol;
    public string Data;
    public string Action;

    public static int Rulecount;

    public Rule( string sourceIP, string destinationIP, int sourcePort, int destinationPort, string protocol, string data, string action, RuleType ruleType)
    {
        
        SourceIP = sourceIP;
        DestinationIP = destinationIP;
        SourcePort = sourcePort;
        DestinationPort = destinationPort;
        Protocol = protocol;
        Data = data;
        Action = action;
        RuleType = ruleType;
        
    }



        public bool checkIp(string ip)
        {
            string[] parts = ip.Split('.');
            if (parts.Length != 4)
            {
                return false;
            }

            foreach (string part in parts)
            {
                if (!int.TryParse(part, out int value) || value < 0 || value > 255)
                {
                    return false;
                }
            }
            return true;
        }


        public RuleType RuleType;
   
}

public enum RuleType
{
    SourceIP,
    DestinationIP,
    SourcePort,
    DestinationPort,
    Protocol,
    Data
}


}
//Writing a function to convert IP Address to integer



