using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Downtime_Calculator.Interfaces
{
    interface iXMLReadable<T> where T : new()
    {
        string GetElementName();
        void PopulateFromElement(XElement xmlElement);
    }
}
