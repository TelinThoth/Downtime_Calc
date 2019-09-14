using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Downtime_Calculator.Interfaces;
using Downtime_Calculator.Classes;

namespace Downtime_Calculator.Classes
{
    public class Character : iXMLWritable, iXMLReadable<Character>
    {
        public int ID
        {
            get;
            private set;
        }

        public string name
        {
            get;
            private set;
        }

        public List<int> accountAccess;

        public bool AddAccountAccess(Account acc)
        {
            if (acc != null)
            {
                accountAccess.Add(acc.ID);
                return true;
            }
            else
                return false;
        }

        public bool RemoveAccountAccess(Account acc)
        {
            if (acc != null)
            {
                accountAccess.Remove(acc.ID);
                return true;
            }
            else
                return false;
        }

        //Constructors

        public Character() : this(0, "Character Name")
        {
            accountAccess = new List<int>();
        }
        public Character(int ID, String name)
        {
            this.ID = ID;
            this.name = name;
            accountAccess = new List<int>();
        }


        //iXMLWritable implementation
        public XElement GetAsElement()
        {
            List<XElement> x_acct = new List<XElement>();
            foreach (int t_acct in accountAccess)
                x_acct.Add(new XElement("ID", t_acct));
            return new XElement("Character",
                new XElement("ID", ID),
                new XElement("Name", name),
                new XElement("AccountAccess", x_acct));
        }

        //iXMLReadable implementation
        public string GetElementName()
        {
            return "Character";
        }

        public void PopulateFromElement(XElement xmlElement)
        {
            this.ID = int.Parse(xmlElement.Element("ID").Value);
            this.name = xmlElement.Element("Name").Value;
            XElement[] temp = xmlElement.Element("AccountAccess").Descendants().ToArray();
            foreach (XElement t in temp)
            {
                accountAccess.Add(int.Parse(t.Value));
            }
        }
    }
}
