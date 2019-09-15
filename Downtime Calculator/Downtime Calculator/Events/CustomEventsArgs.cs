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
}
