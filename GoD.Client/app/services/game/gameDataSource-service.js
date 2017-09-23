(function () {
    var serviceId = 'GameDataSourceService'

    angular.module('services.app')
        .factory(serviceId, [
            '$http',
            '$q',
            'Constants',
            GameDataSourceService
        ])

    function GameDataSourceService($http, $q, Constants) {
        return {
            savePlayers: savePlayers,
        }

        function savePlayers(players) {
            return $http.post(Constants.API.playersUrl, players)
        }

        //function getPersonalInfo(identification) {
        //    return $http.get(Constants.API.employeePersonalInfoUrl.format(identification))
        //}

        //function getEmergencyContact(identification) {
        //    return $http.get(Constants.API.emergencyContactUrlDetail.format(identification))
        //}
    }
})()