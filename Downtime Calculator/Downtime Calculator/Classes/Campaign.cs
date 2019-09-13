using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Downtime_Calculator.Interfaces;

namespace Downtime_Calculator.Classes
{
    class Campaign : iXMLWritable, iXMLReadable<Campaign>
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

        public List<Account> accounts;
        public List<Character> characters;
        public List<Player> players;

        public Campaign() : this(0, "Default Name")
        {
            accounts = new List<Account>();
            characters = new List<Character>();
            players = new List<Player>();
        }

        public Campaign(int ID, string name)
        {
            this.ID = ID;
            this.name = name;
            accounts = new List<Account>();
            characters = new List<Character>();
            players = new List<Player>();
        }

        public void SaveToLocation(string path)
        {
            XMLWriter.Instance.Write(this, path);
        }

        public static Campaign LoadFromLocation(string path)
        {
            return XMLReader.Instance.ReadSingle<Campaign>(path);
        }

        //iXMLWritable implementation
        public XElement GetAsElement()
        {
            return new XElement("Campaign",
                new XElement("ID", ID),
                new XElement("Name", name),
                new XElement("Players"),
                new XElement("Characters"),
                new XElement("Accounts"));
        }

        //iXMLReadable implementation
        public string GetElementName()
        {
            return "Campaign";
        }

        public void PopulateFromElement(XElement xmlElement)
        {
            this.ID = int.Parse(xmlElement.Element("ID").Value);
            this.name = xmlElement.Element("Name").Value;

            XElement[] pullData = xmlElement.Element("Players").Descendants("Player").ToArray();
            Player tempPlayer = new Player();
            foreach(XElement data in pullData)
            {
                tempPlayer.PopulateFromElement(data);
                players.Add(tempPlayer);
            }

            pullData = xmlElement.Element("Characters").Descendants("Character").ToArray();
            Character tempCharacter = new Character();
            foreach (XElement data in pullData)
            {
                tempCharacter.PopulateFromElement(data);
                characters.Add(tempCharacter);
            }

            pullData = xmlElement.Element("Accounts").Descendants("Account").ToArray();
            Account tempAccount = new Account();
            foreach(XElement data in pullData)
            {
                tempAccount.PopulateFromElement(data);
                accounts.Add(tempAccount);
            }
        }

        public void LoadConfigData(string path)
        {
            //To be filled in...
        }
    }
}
