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
            int player1Score;
            int player2Score;
            
            Console.WriteLine("Would you like to play against a computer (1) or another person (2)?");
            int HvC = int.Parse(Console.ReadLine());
            if (HvC == 1)
            {
                do
                {
                    playerc = test.YouChoose();
                    player2c = test3.CPUChoice();
                    test.RunGame(playerc, player2c);
                    player1Score = test.ReturnPlayer1Score();
                    player2Score = test.ReturnPlayer2Score();
                }
                while (player1Score != 2 && player2Score != 2);
            }
            else
            {
                do
                {
                    playerc = test.YouChoose();
                    player2c = test2.Choose();
                    test.RunGame(playerc, player2c);
                    player1Score = test.ReturnPlayer1Score();
                    player2Score = test.ReturnPlayer2Score();
                }
                while (player1Score != 2 && player2Score != 2);
            }
            
            if(player1Score == 2)
            {
                Console.WriteLine("Player One won the game!");
            }
            else if(player2Score == 2)
            {
                Console.WriteLine("Player Two won the game!");
            }
            Console.ReadLine();
        }
    }
}
