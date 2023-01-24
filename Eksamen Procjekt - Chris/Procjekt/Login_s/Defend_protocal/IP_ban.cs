using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Eksamen_Procjekt___Chris.Procjekt.Login_s.Defend_protocal
{
    internal class IP_ban
    {
        public void ban_or_not()
        {
            typeof(IP_ban).GetMethod("ip", BindingFlags.NonPublic | BindingFlags.Instance).Invoke(new IP_ban(), null);
        }

        private void ip(bool password, bool username) // her laver jeg en private void til personlige informationer
        {
            // skolen ip 10.29.130.67
            List<string> ip_bans = new List<string>(

            ); // her er listen til ip adresser som er bannet
            string hostName = Dns.GetHostName();
            string ip_tjek = Dns.GetHostByName(hostName).AddressList[0].ToString();
            foreach (string ban in ip_bans)
            {
                if (ip_tjek == ban)
                {
                    return; 
                   // return login_fail;
                }
                else
                {

                    // så her kommer man forbi det her foreach tjek af ipadresser
                }
            }

            if (username == false)
            {
                hostName = Dns.GetHostName();
                ip_tjek = Dns.GetHostByName(hostName).AddressList[0].ToString();
                ip_bans.Add(ip_tjek);
                return;

            }
            else
            {
                if (password == false)
                {
                    hostName = Dns.GetHostName();
                    ip_tjek = Dns.GetHostByName(hostName).AddressList[0].ToString();
                    ip_bans.Add(ip_tjek);
                    return;
                }
                else
                {
                    // så kommer man igennem defends protocal
                }
            }

        }
    }
}
