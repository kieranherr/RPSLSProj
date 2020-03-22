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
        string HumanChoice;
        string CPUChoice;
        public int player1score = 0;
        public int player2score = 0;
        public PlayerParent()
        {
            moves.Add("Rock");
            moves.Add("Paper");
            moves.Add("Scissors");
            moves.Add("Lizard");
            moves.Add("Spock");
            player1score = 0;
            player2score = 0;
        }
        public void test()
        {
            moves.ForEach(Console.WriteLine);
            Console.ReadLine();
            
        }
        
        public string YouChoose()
        {
            Console.WriteLine("Which move would you like to perform Player One?");
            yourChoice = Console.ReadLine();
            return yourChoice;
        }
        public void RunGame(string player1, string player2)
        {
          
            
                if(player1 == player2)
                {
                    Console.WriteLine("This is a tie!");
                }
                else if (player1 == "Rock" && (player2 == "Scissors" || player2 == "Lizard"))
                {
                    Console.WriteLine("Player One wins this round!");
                    player1score++;
            
            }
                else if (player1 == "Paper" && (player2 == "Rock") || (player2 == "Spock"))
                {
                    Console.WriteLine("Player One wins this round!");
                    player1score++;
            
            }
                else if (player1 == "Scissors" & (player2 == "Paper" || player2 == "Lizard"))
                {
                    Console.WriteLine("Player One wins this round!");
                    player1score++;
             
            }
                else if (player1 == "Lizard" && (player2 == "Spock" || player2 == "Paper"))
                {
                    Console.WriteLine("Player One wins this round!");
                    player1score++;
              
            }
                else if (player1 == "Spock" && (player2 == "Rock" || player2 == "Scissors"))
                {
                    Console.WriteLine("Player One wins this round!");
                    player1score++;
            
            }
                else
                {
                    Console.WriteLine("Player Two wins this round!");
                    player2score++;
               
                }
        }
        public int ReturnPlayer1Score()
        {
            return player1score;
        }
        public int ReturnPlayer2Score()
        {
            return player2score;
        }
        

    }
}
