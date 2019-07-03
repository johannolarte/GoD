using GoD.WebApi.Core.ViewModels;
using System.Collections.Generic;

namespace GoD.WebApi.Core.Games
{
    public static class GameService
    {
        public static string ValidateMoves(IList<MovesViewModel> moves)
        {
            var playerOne = moves[0];
            var playerTwo = moves[1];
            string roundWinner = "";

            if (playerOne.Move == playerTwo.Move)
            {
                return "Draw";
            }

            switch (playerOne.Move)
            {
                case "Rock":
                    if (playerTwo.Move == "Scissors")
                        roundWinner = playerOne.Player.Name;
                    else
                        roundWinner = playerTwo.Player.Name;
                    break;
                case "Scissors":
                    if (playerTwo.Move == "Paper")
                        roundWinner = playerOne.Player.Name;
                    else
                        roundWinner = playerTwo.Player.Name;
                    break;
                default:
                    if (playerTwo.Move == "Rock")
                        roundWinner = playerOne.Player.Name;
                    else
                        roundWinner = playerTwo.Player.Name;
                    break;
            }

            return roundWinner;
        }
    }
}