using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class PlayerParent
    {
        public List<string> moves = new List<string>();
        string yourChoice;
        public PlayerParent()
        {
            moves.Add("Rock");
            moves.Add("Paper");
            moves.Add("Scissors");
            moves.Add("Lizard");
            moves.Add("Spock");
        }
        public void test()
        {
            moves.ForEach(Console.WriteLine);
            Console.ReadLine();
        }

        public void YouChoose()
        {
            Console.WriteLine("Which move would you like to perform?");
            yourChoice = Console.ReadLine();
            Console.WriteLine(yourChoice);
            Console.ReadLine();
        }
        
    }
}
