using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace TestAutoItApp
{
    internal class Gateway
    {
        public string Imei;
        public int ChildDevices;
        public int NetworkChannel;
        public string PanId;
        public List<string> MacAdresesOfCoordinator;

        public Gateway(string imei)
        {
            Imei = imei;
        }

        public void GetNetworkInfo()
        {

        }

        public List<string> GetMacAddreses()
        {
            return MacAdresesOfCoordinator.ToList();
        }

        public int GetChildDevises()
        {
            return ChildDevices;
        }
    }
}
