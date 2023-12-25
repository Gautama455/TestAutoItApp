using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestAutoItApp
{
    internal class Repeater
    {
        public string MacAdress;
        public List<Repeater> Neibourhoods;
        public Gateway ParentGateway;
        public int LeaveTime;
        public int Pakeges;
        public int NeibourSignal;

        public Repeater(string macAdress)
        {
            MacAdress = macAdress;
        }

        public Gateway GetVersion()
        {
            return ParentGateway;
        }

        public int GetLeaveTime()
        {
            return LeaveTime;
        }

        public List<Repeater> GetListOfNeibourhoods()
        {
            return Neibourhoods;
        }
    }
}
