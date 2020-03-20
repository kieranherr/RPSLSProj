using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerParent test = new PlayerParent();
            HumanPlayer test2 = new HumanPlayer();
            CPUPlayer test3 = new CPUPlayer();
            string playerc;
            string player2c;
            int HvC;
            Console.WriteLine("Would you like to play against a computer (1) or another person (2)?");
            HvC = int.Parse(Console.ReadLine());
            if(HvC == 1)
            {
                if(test3.CPUChoice() == )
                {
                    Console.WriteLine("niashd");
                }
            }
            playerc = test3.CPUChoice();
            Console.WriteLine(playerc);
            Console.ReadLine();
            //test2.example();
            //test2.Choose();
            //test.YouChoose();

            //string str1 = "yes";
            //string str2 = "no";
            //if(str1 == str2 || str1 == "Yes")
            //{
            //    Console.WriteLine("Logic failed");
            //}
            //else
            //{
            //    Console.WriteLine("Logic worked");
            //}
            //Console.ReadLine();

        }
    }
}
