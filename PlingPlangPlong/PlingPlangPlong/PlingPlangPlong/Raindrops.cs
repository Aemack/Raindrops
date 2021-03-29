using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlingPlangPlong
{
    public class Raindrops
    {
        private static int _plingNum;
        private static int _plangNum;
        private static int _plongNum;

        public Raindrops()
        {
            _plingNum = 3;
            _plangNum = 5;
            _plongNum = 7;
        }

        public Raindrops(int plingNum=3, int plangNum=5, int plongNum=7)
        {
            _plingNum = plingNum == 0 ? 1 : plingNum;
            _plangNum = plangNum == 0 ? 1 : plangNum;
            _plongNum = plongNum == 0 ? 1 : plongNum;
        }

        public string GetPlingPlangPlong(int num)
        {
            string returnString = "";
            if (num == 0) return "0";
            if (num % _plingNum == 0) returnString += "Pling";
            if (num % _plangNum == 0) returnString += "Plang";
            if (num % _plongNum == 0) returnString += "Plong";
            if (returnString == "") returnString += num;
            return returnString;
        }

    }
}
