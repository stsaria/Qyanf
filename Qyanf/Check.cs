using System.Net;

namespace Qyanf
{
    internal class Check
    {
        public (bool, string, string) CheckNetwork(string globalIpCheckUrl)
        {
            var privateIp = "";
            var globalIp = "";
            bool successGlobalIpCheck = false;
            bool successPrivateIpCheck = false;
            bool successAll = false;
            //Get private-ip
            try
            {
                IPAddress[] adrList = Dns.GetHostAddresses(Dns.GetHostName());
                foreach (IPAddress address in adrList)
                {
                    privateIp = address.ToString();
                }
                successPrivateIpCheck = true;
            }
            catch
            {
                successPrivateIpCheck = false;
            }

            //Get global-ip
            try
            {
                string globalIpString = new HttpClient().GetStringAsync(globalIpCheckUrl).Result;
                globalIp = IPAddress.Parse(globalIpString).ToString();
                successGlobalIpCheck = true;
            }
            catch
            {
                successGlobalIpCheck = false;
            }

            // どっちかが成功（取得の）していない場合は、成功としない(変数:successAllへ)
            if (!successGlobalIpCheck || !successPrivateIpCheck)
            {
                successAll = false;
            }
            else
            {
                successAll = true;
            }

            return (successAll, privateIp, globalIp);
        }
        public void CheckAuto()
        {
            Console.WriteLine(CheckNetwork("https://ipinfo.io/ip"));
        }

    }
}
