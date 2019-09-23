using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Downtime_Calculator.Events
{
    public class NewCampaignCreatedEventArgs : EventArgs
    {
        public string fileName { get; set; }
    }

    public class NewPlayerCreatedArgs : EventArgs
    {
        public string playerName { get; set; }
    }

    public class NewCharacterCreatedArgs : EventArgs
    {

        public string characterName { get; set; }
        public int attachedPlayerID { get; set; }
    }

    public class NewAccountCreatedArgs : EventArgs
    {
        //If returnAcc is -1, set to this new account
        //If retrunAcc is -2, no return account
        public int type { get; set; }
        public double investment { get; set; }
        public string nick { get; set; }
        public int owner { get; set; }
        public int returnAcc { get; set; }
        public int[] accessGranted { get; set; }
    }

    public class ModifyAccountAccessArgs : EventArgs
    {
        public int[] charIDs { get; set; }
    }
}
