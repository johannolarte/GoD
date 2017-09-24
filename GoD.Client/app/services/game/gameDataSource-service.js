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
            validateMoves: validateMoves
        }

        function validateMoves(moves) {
            return $http.post(Constants.API.gamesUrl, moves)
        }

        //function getEmergencyContact(identification) {
        //    return $http.get(Constants.API.emergencyContactUrlDetail.format(identification))
        //}
    }
})()