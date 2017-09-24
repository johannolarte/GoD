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
        //_API.employeePersonalInfoUrl = _API.baseUrl + "/Employee/{0}/personalInfo" //{identification}
        //_API.employeesUrl = _API.baseUrl + "/Employee/{0}" //{identification}
        //_API.employeeFamilyInfoUrl = _API.baseUrl + "/Employee/{0}/familyInfo" //{identification}
        //_API.employeeMaritalStatusUrl = _API.baseUrl + "/MaritalStatus"
        //_API.employeeHomeTypesUrl = _API.baseUrl + "/HomeType"
        //_API.employeeSocialStratumUrl = _API.baseUrl + "/SocialStratum"
        //_API.gendersUrl = _API.baseUrl + "/Gender"
        //_API.employeeProfileImageUrl = _API.baseUrl + "/Employee/{0}/profileImage" //{identification}
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