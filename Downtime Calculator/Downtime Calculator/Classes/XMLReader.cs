using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        private XMLReader()
        {
            //intentionally empty
        }
        #endregion
    }
}
