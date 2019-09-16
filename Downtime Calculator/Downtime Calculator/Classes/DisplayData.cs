using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Downtime_Calculator.Classes
{
    class DisplayData
    {
        public Player[] displayPlayers;
        public Character[] displayCharacters;
        public Account[] displayAcounts;            

        public List<string> GetDisplayCharName()
        {
            List<string> displayCharName = new List<string>();
            foreach(Character chara in displayCharacters)
            {
                displayCharName.Add(chara.name);
            }

            return displayCharName;
        }

        public List<string> GetDisplayAccName()
        {
            List<string> displayAccName = new List<string>();
            foreach(Account acct in displayAcounts)
            {
                if(acct.name.Trim() == "")
                {
                    displayAccName.Add("Account #:" + acct.ID);
                }
                else
                {
                    displayAccName.Add(acct.name);
                }
            }

            return displayAccName;
        }

        public List<string> GetDisplayPlayName()
        {
            List<string> displayPlayName = new List<string>();
            foreach(Player play in displayPlayers)
            {
                displayPlayName.Add(play.name);
            }

            return displayPlayName;
        }
        public int PullPlayerID(int index)
        {
            return displayPlayers[index].ID;
        }

        public int PullCharaID(int index)
        {
            return displayCharacters[index].ID;
        }

    }
}
