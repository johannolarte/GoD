(function () {
    'use strict'

    var serviceId = 'Constants'

    angular.module('services.common').service(serviceId, [Constants])

    function Constants() {

        var _API = {}

        _API.baseUrl = "http://localhost:59095"

        // Players
        _API.playersUrl = _API.baseUrl + "/Players"
        //

        // Games
        _API.gamesUrl = _API.baseUrl + "/Games"
        //

        var _router = {
            stateRound: 'app.game',
            stateHome: 'app.home',
            urlHome: '/home'
        }

        return {
            API: _API,
            ROUTER: _router,
        }
    }
})()