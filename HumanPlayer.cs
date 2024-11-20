using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class HumanPlayer : IPlayer
    {
        public Choice GetChoice()
        {
            Choice P1;
            do
            {
                Console.Write("Enter Choice: (R)ock, (P)aper, (S)cissors: ");
                string input = Console.ReadLine().ToUpper();
                if (input == "R")
                {
                    P1 = Choice.Rock;
                    break;
                }
                else if (input == "P")
                {
                    P1 = Choice.Paper;
                    break;
                }
                else if (input == "S")
                {
                    P1 = Choice.Scissors;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Choice, try again");
                }
            }
            while (true);
            return P1;
        }
    }
}
