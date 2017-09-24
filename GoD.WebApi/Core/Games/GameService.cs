using GoD.WebApi.Core.ViewModels;
using System.Collections.Generic;

namespace GoD.WebApi.Core.Games
{
    public class GameService
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
                case "Paper":
                    if (playerTwo.Move == "Rock")
                        roundWinner = playerOne.Player.Name;
                    else
                        roundWinner = playerTwo.Player.Name;
                    break;
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
                    break;
            }

            return roundWinner;
        }
    }
}