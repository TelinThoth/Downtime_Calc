using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Downtime_Calculator.Interfaces;

namespace Downtime_Calculator.Classes
{
    public class Account : iXMLWritable, iXMLReadable<Account>
    {
        public int ID
        {
            get;
            private set;
        }

        public int accountType
        {
            get;
            private set;
        }

        public double investment
        {
            get;
            private set;
        }

        public string name
        {
            get;
            private set;
        }

        public int owner
        {
            get;
            private set;
        }

        public int returnAccount
        {
            get;
            private set;
        }

        public bool AddFund(double value)
        {
            if (value >= 0)
            {
                investment += value;
                return true;
            }
            else
                return false;
        }

        public bool RemoveFund(double value)
        {
            if (value <= 0)
            {
                investment += value;
                return true;
            }
            else
                return false;
        }

        //Constructors

        public Account() : this(0, 0, 0.0, "Account Name", 0, 0) { }

        public Account(int ID, int type, double investment, string nick, int owner, int returnAcc)
        {
            this.ID = ID;
            this.accountType = type;
            this.investment = investment;
            this.name = nick;
            this.owner = owner;
            this.returnAccount = returnAcc;
        }

        public Account(int ID, int type, double investment, int owner)
        {
            this.ID = ID;
            this.accountType = type;
            this.investment = investment;
            this.name = "Account" + this.ID;
            this.owner = owner;
            this.returnAccount = this.ID;
        }

        //iXMLWritable implementation
        public XElement GetAsElement()
        {
            return new XElement("Account",
                new XElement("ID", ID),
                new XElement("Type", accountType),
                new XElement("Investment", investment),
                new XElement("Name", name),
                new XElement("Owner", owner),
                new XElement("ReturnAccount", returnAccount));
        }

        //iXMLReadable implementation
        public string GetElementName()
        {
            return "Account";
        }

        public void PopulateFromElement(XElement xmlElement)
        {
            this.ID = int.Parse(xmlElement.Element("ID").Value);
            this.accountType = int.Parse(xmlElement.Element("Type").Value);
            this.investment = int.Parse(xmlElement.Element("Investment").Value);
            this.name = xmlElement.Element("Name").Value;
            this.owner = int.Parse(xmlElement.Element("Owner").Value);
            this.returnAccount = int.Parse(xmlElement.Element("ReturnAccount").Value);
        }
    }

}
