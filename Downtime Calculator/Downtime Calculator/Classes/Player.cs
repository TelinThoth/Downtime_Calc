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
    public class Player
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

        public List<int> characters
        {
            get;
        }
        public bool AddCharacter(Character added)
        {
            if (added != null)
            {
                characters.Add(added.ID);
                return true;
            }
            else
                return false;
        }

        public bool RemoveCharacter(Character removed)
        {
            if (removed != null)
            {
                characters.Remove(removed.ID);
                return true;
            }
            else
                return false;
        }

        // Constructors
        public Player() : this(0, "Default Name") { }

        public Player( int ID, string name)
        {
            this.ID = ID;
            this.name = name;
        }

        //iXMLWritable implementation
        public XElement GetAsElement()
        {
            return new XElement("Player",
                new XElement("ID", ID),
                new XElement("Name", name),
                new XElement("Characters"));
        }

        //iXMLReadable implementation
        public string GetElementName()
        {
            return "Player";
        }

        public void PopulateFromElement(XElement xmlElement)
        {
            this.ID = int.Parse(xmlElement.Element("ID").Value);
            this.name = xmlElement.Element("Name").Value;
            string temp = xmlElement.Element("Characters").Value;            
        }
    }

}