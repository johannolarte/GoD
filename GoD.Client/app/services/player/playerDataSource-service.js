(function () {
    var serviceId = 'PlayerDataSourceService'

    angular.module('services.app')
        .factory(serviceId, [
            '$http',
            '$q',
            'Constants',
            PlayerDataSourceService
        ])

    function PlayerDataSourceService($http, $q, Constants) {
        return {
            savePlayers: savePlayers,
            getPlayers: getPlayers
        }

        function savePlayers(players) {
            return $http.post(Constants.API.playersUrl, players)
        }

        function getPlayers() {
            return $http.get(Constants.API.playersUrl)
        }
    }
})()