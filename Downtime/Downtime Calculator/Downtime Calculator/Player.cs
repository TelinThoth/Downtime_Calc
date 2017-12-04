using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Downtime_Calculator
{
    class Player
    {
        [Flags]
        enum flags
        {
            none = 0x0,
            raise = 0x1,
            resurection = 0x2,
            trueRes = 0x4,
            activeRF = 0x8,
            monthly = 0x16,
            failsClears = 0x32,
            depToRF = 0x64,
            activeAcc = 0x128
        }

        string name;

        UInt32 bankAccount;
        UInt32 RFAccount;


    }
}