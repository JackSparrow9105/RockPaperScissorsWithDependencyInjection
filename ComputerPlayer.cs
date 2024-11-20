using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class ComputerPlayer:IPlayer
    {
        public Choice GetChoice()
        {
            Random _rng = new Random();
            Choice P2 = (Choice)_rng.Next(0, 3);
           return P2;
        }
    }
}
