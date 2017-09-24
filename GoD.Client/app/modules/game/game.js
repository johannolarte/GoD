(function () {
    var controllerId = 'Game'

    angular.module('app').controller(controllerId,
        [Game])

    function Game() {

        var vm = this

        vm.roundCounter = 1
        vm.moveLabel = "Select Move:"

        // Get from the backend
        vm.playerMoves = [
            { Id: 1, Name: "Rock" },
            { Id: 1, Name: "Paper" },
            { Id: 1, Name: "Scissors" }
        ]

        // Remove this!!!
        vm.playerName = "Oelo"
        //

        vm.selectPlayerMove = function () {

        }
    }
})()