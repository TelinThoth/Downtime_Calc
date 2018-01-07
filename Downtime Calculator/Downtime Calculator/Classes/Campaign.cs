using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Downtime_Calculator.Interfaces;

namespace Downtime_Calculator.Classes
{
    class Campaign : iXMLWritable
    {
        public string name
        {
            get;
            private set;
        }

        public int ID
        {
            get;
            private set;
        }

        public Campaign()
        {
            name = "Default Name";
            ID = 0;
        }

        public XElement GetAsElement()
        {
            return new XElement("Campaign",
                new XElement("ID", ID),
                new XElement("Name", name),
                new XElement("Players"),
                new XElement("Characters"),
                new XElement("Accounts"));
        }

        public void SaveToLocation(string path)
        {
            string fullPath = path + @"\" + name;
            XMLWriter.Instance.Write(this, fullPath);
        }
    }
}
