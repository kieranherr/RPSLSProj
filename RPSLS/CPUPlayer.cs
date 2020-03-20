using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class CPUPlayer : PlayerParent
    {
        Random rnd = new Random();
        int num;
        string word;
        public string CPUChoice()
        {
               num = rnd.Next(5);
            string choice = moves[num];
            return choice;
            
        }
            
    
    }
}
