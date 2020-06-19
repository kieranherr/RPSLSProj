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
   
        public string CPUChoice()
        {
               int num = rnd.Next(5);
            Console.WriteLine(num);
            string choice = moves[num];
            return choice;
            
        }
            
    
    }
}
