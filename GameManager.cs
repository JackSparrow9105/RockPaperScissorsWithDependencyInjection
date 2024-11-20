using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class GameManager
    {
        private IPlayer _player1;
        private IPlayer _player2;

        public GameManager(IPlayer player1, IPlayer player2)
        {
            _player1 = player1;
            _player2 = player2;
        }

        public RoundResult PlayRound()
        {
            Choice P1 = _player1.GetChoice();
            Choice P2 = _player2.GetChoice();
            Console.WriteLine($"Player 1 Picks {P1.ToString()} and Player 2 Picks {P2.ToString()}");

            if (P1 == P2)
            {
                return RoundResult.Draw;
            }
            if (P1 == Choice.Rock && P2 == Choice.Scissors ||
                P1 == Choice.Paper && P2 == Choice.Rock ||
                P1 == Choice.Scissors && P2 == Choice.Paper)
            {
                return RoundResult.Player1Win;
            }
            return RoundResult.Player2Win;

        }
    }
    public enum Choice
    {
        Rock,
        Paper,
        Scissors
    }
    public enum RoundResult
    {
        Player1Win,
        Player2Win,
        Draw
    }
}
