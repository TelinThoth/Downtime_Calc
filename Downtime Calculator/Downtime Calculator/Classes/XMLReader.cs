using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Downtime_Calculator.Interfaces;
using System.Xml.Linq;

namespace Downtime_Calculator.Classes
{
    class XMLReader
    {
        #region Singleton Implementation
        public static XMLReader Instance
        {
            get
            {
                if (instance == null)
                    instance = new XMLReader();
                return instance;
            }
        }
        private static XMLReader instance;

        public XMLReader()
        {
            //intentionally empty
        }
        #endregion
        
        //Returns array of T from available elements
        public T[] Read<T>(string path) where T : iXMLReadable<T>, new()
        {
            List<T> workingList = new List<T>();
            workingList.Add(new T());
            XDocument xDoc = XDocument.Load(path);
            XElement[] elements = xDoc.Elements(workingList[0].GetElementName()).ToArray<XElement>();

            for (int i = 0; i < elements.Length; i++)
            {
                workingList[i].PopulateFromElement(elements[i]);
                if(i + 1 < elements.Length)
                {
                    workingList.Add(new T());
                }
            }

            T[] finalArray = workingList.ToArray();

            return finalArray;
        }

        //Returns first instance of T from available elements.
        //If XML will only contain one element of this type the differnece is minimal.
        //May Rewrite for efficiency when many elements may exist.
        public T ReadSingle<T>(string path) where T : iXMLReadable<T>, new()
        {
            return Read<T>(path)[0];
        }
    }
}
