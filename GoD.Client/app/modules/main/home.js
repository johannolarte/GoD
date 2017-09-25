(function () {
    var controllerId = 'Home'

    angular.module('app').controller(controllerId, [
        '$state',
        'Constants',
        'PlayerDataSourceService',
        Home])

    function Home(
        $state,
        Constants,
        PlayerDataSourceService) {

        var vm = this

        vm.title = "Enter Player's Names"

        vm.playerOneLabel = "Player 1"
        vm.playerTwoLabel = "Player 2"

        vm.startGame = function () {
            var playersNames = []

            playersNames.push({ PlayerName: vm.playerOneName })
            playersNames.push({ PlayerName: vm.playerTwoName })

            PlayerDataSourceService.savePlayers(playersNames)
                .then(function (response) {
                    if (response.status === 200)
                        $state.go(Constants.ROUTER.stateRound)
                });
        }
    }
})()