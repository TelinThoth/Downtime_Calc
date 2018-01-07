using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Downtime_Calculator.Interfaces
{
    interface iXMLReadable
    {
        void CreateFromElement(XElement xmlElement);
    }
}
