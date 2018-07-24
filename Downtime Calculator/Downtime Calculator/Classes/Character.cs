﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Downtime_Calculator.Interfaces;
using Downtime_Calculator.Classes;

namespace Downtime_Calculator.Classes
{
    public class Character
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

        public Character() : this(0, "Character Name") { };
        public Character(int ID, String name)
        {
            this.ID = ID;
            this.name = name;
        }

    }
}