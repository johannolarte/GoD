(function () {
    var controllerId = 'Game'

    angular.module('app').controller(controllerId, [
        '$mdDialog',
        '$state',
        'PlayerDataSourceService',
        'GameDataSourceService',
        'Constants',
        Game])

    function Game($mdDialog,
        $state,
        PlayerDataSourceService,
        GameDataSourceService,
        Constants) {

        var vm = this
        var playersMoves
        var playerOneScore = 0
        var playerTwoScore = 0
        var moves = [
            { Id: 1, Name: "Rock" },
            { Id: 2, Name: "Paper" },
            { Id: 3, Name: "Scissors" }
        ]

        vm.roundCounter = 1
        vm.moveLabel = "Select Move:"
        vm.playerMoves = moves

        resetPlayerMoves()
        getPlayers()

        vm.selectPlayerMove = function () {
            vm.isPlayerOneTurn = vm.isPlayerTwoTurn
            vm.isPlayerTwoTurn = !vm.isPlayerOneTurn

            if (!vm.isPlayerOneTurn) {
                playersMoves.push({ Move: vm.selectedPlayerMove.Name , Player: vm.playerOne})
            } else {
                playersMoves.push({ Move: vm.selectedPlayerMove.Name, Player: vm.playerTwo })
            }

            if (playersMoves.length === 2) {
                GameDataSourceService.validateMoves(playersMoves)
                    .then(function (response) {
                        if(response.data == vm.playerOne.Name)
                            playerOneScore++

                        if (response.data == vm.playerTwo.Name)
                            playerTwoScore++

                        if (vm.roundCounter < 3) {
                            showDialog({
                                title: "Round #" + vm.roundCounter,
                                textContent: "Round winner: " + response.data,
                                okButton: "Continue"
                            })
                            vm.roundCounter++
                        } else {
                            validateScores({ playerOne: playerOneScore, playerTwo: playerTwoScore })
                        }

                        resetPlayerMoves()
                    })
            }

            resetSelectedMove()
        }

        function validateScores(playersScores) {
            if(playersScores.playerOne == playersScores.playerTwo)
                showDialog({
                    title: "We haven't a winner :(",
                    textContent: "Try again!",
                    okButton: "Play again"
                })

            if (playersScores.playerOne > playersScores.playerTwo)
                showDialog({
                    title: "We have a WINNER!!",
                    textContent: vm.playerOne.Name + " is the new EMPEROR!",
                    okButton: "Play again"
                })
            else
                showDialog({
                    title: "We have a WINNER!!",
                    textContent: vm.playerTwo.Name + " is the new EMPEROR!",
                    okButton: "Play again"
                })
        }

        function showDialog(dialogContent) {
            var buttonText = dialogContent.okButton

            $mdDialog.show(
              $mdDialog.alert()
                .parent(angular.element(document.querySelector('#popupContainer')))
                .clickOutsideToClose(true)
                .title(dialogContent.title)
                .textContent(dialogContent.textContent)
                .ariaLabel('Game of Drones')
                .ok(dialogContent.okButton)
            ).finally(function () {
                if (buttonText == "Play again")
                    $state.go(Constants.ROUTER.stateHome)
            });
        }

        function resetPlayerMoves() {
            playersMoves = []
        }

        function resetSelectedMove() {
            vm.selectedPlayerMove = { Id: 0, Name: "" }
        }

        function getPlayers() {
            PlayerDataSourceService.getPlayers()
                .then(function (response) {
                    vm.playerOne = response.data[1]
                    vm.playerTwo = response.data[0]

                    vm.isPlayerOneTurn = true
                })
        }
    }
})()