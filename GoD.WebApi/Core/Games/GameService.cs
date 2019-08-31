using GoD.WebApi.Core.Constants;
using GoD.WebApi.Core.ViewModels;
using System;
using System.Collections.Generic;

namespace GoD.WebApi.Core.Games
{
    public static class GameService
    {
        public static string ValidateMoves(IList<MovesViewModel> moves)
        {
            var playerOne = moves[0];
            var playerTwo = moves[1];

            if (playerOne.Move == playerTwo.Move)
                return GameServiceConstants.GameDraw;

            var playerOneMove = GetEnumPlayerMovement(playerOne.Move);
            var playerTwoMove = GetEnumPlayerMovement(playerTwo.Move);

            switch (playerOneMove)
            {
                case PlayerMovements.Rock:
                    return playerTwoMove == PlayerMovements.Scissors ?
                        GetPlayerName(playerOne) : GetPlayerName(playerTwo);
                case PlayerMovements.Scissors:
                    return playerTwoMove == PlayerMovements.Paper ?
                        GetPlayerName(playerOne) : GetPlayerName(playerTwo);
                default:
                    return playerTwoMove == PlayerMovements.Rock ?
                        GetPlayerName(playerOne) : GetPlayerName(playerTwo);
            }
        }

        private static PlayerMovements GetEnumPlayerMovement(string playerMovement) =>
            (PlayerMovements)Enum.Parse(typeof(PlayerMovements), playerMovement);

        private static string GetPlayerName(MovesViewModel movesViewModel) =>
            movesViewModel.Player.Name;
    }
}