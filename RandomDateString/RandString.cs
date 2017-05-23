using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomDateString
{
    public class RandString
    {
        int randNum = 0;

        private int RandomNumCalc
        {
            get
            {
                string junk;
                string something = "";
                Byte randByte = 0x00000;
                DateTime dt = DateTime.Now;

                junk = something + Convert.ToString(randByte);
                return randNum = (Convert.ToInt32(dt.ToBinary()) * Convert.ToInt32(Math.PI)) / Convert.ToInt32(junk);
            }
        }

        private int RandomSeedTrue()
        {
            randNum = ((RandomNumCalc* RandomNumCalc) / RandomNumCalc) + RandomNumCalc- RandomNumCalc;
            return randNum;
        }
    }
}
