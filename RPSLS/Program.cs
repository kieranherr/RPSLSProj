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
            test2.example();
            test2.Choose();
            test.YouChoose();

        }
    }
}
