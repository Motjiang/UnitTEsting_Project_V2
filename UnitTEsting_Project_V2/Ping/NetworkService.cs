using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace UnitTEsting_Project_V2.Ping
{
    public class NetworkService
    {
        // string method
        public string sendPing()
        {
            return "Success: Ping sent";
        }

        // integer method
        public int PingTimeout(int a, int b)
        {
            return a + b;
        }

        //DateTime method
        public DateTime LastPingDate()
        {
            return DateTime.Now;
        }

        //Object method
        public PingOptions GetPingOptions()
        {
            return new PingOptions()
            {
                DontFragment = true,
                Ttl = 1
            };
        }

        //IEnumerable method
        public IEnumerable<PingOptions> MostRecentPings()
        {
            IEnumerable<PingOptions> pingOptions = new[]
            {
                new PingOptions()
                {
                    DontFragment = true,
                    Ttl = 1
                },
                new PingOptions()
                {
                    DontFragment = true,
                    Ttl = 1
                },
                new PingOptions()
                {
                    DontFragment = true,
                    Ttl = 1
                },
            };
            return pingOptions;
        }
    }
}
