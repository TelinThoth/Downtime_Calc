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
    public class Player : iXMLWritable, iXMLReadable<Player>, IComparable<Player>
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
        public Player() : this(0, "Default Name")
        {
            characters = new List<int>();
        }

        public Player( int ID, string name)
        {
            this.ID = ID;
            this.name = name;
            characters = new List<int>();
        }

        //iXMLWritable implementation
        public XElement GetAsElement()
        {
            List<XElement> t_characters = new List<XElement>();
            foreach (int charID in characters)
                t_characters.Add(new XElement("Character", charID));
            return new XElement("Player",
                new XElement("ID", ID),
                new XElement("Name", name),
                new XElement("Characters",t_characters));
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
            XElement[] temp = xmlElement.Element("Characters").Descendants().ToArray();
            foreach(XElement t in temp)
            {
                characters.Add(int.Parse(t.Value));
            }
        }
        
        public static Player[] LoadFromLocation(string path)
        {
            return XMLReader.Instance.Read<Player>(path);
        }

        public int CompareTo(Player i_player)
        {
            if (i_player == null)
                return 1;
            else
                return this.ID.CompareTo(i_player.ID);
        }
    }

}