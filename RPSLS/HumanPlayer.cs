using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class HumanPlayer : PlayerParent
    {
        string choice;
        public void example()
        {
            Console.WriteLine(moves[1]);
            Console.ReadLine();
        }
        public string Choose()
        {
            Console.WriteLine("Which move would you like to perform Player Two?");
            choice = Console.ReadLine();
            return choice;
        }
        
    }
}
