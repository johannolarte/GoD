(function () {
    'use strict'

    var app = angular.module('app')

    app.config(function ($stateProvider, $urlRouterProvider) {

        $stateProvider

        .state('app', {
            url: '',
            abstract: true,
            templateUrl: 'app/modules/main/index-main.html',
            controller: 'IndexMain as vm'
        })

        .state('app.home', {
            url: '/home',
            views: {
                'view-content': {
                    templateUrl: 'app/modules/main/home.html',
                    controller: 'Home as vm'
                }
            }
        })

        .state('app.round', {
            url: '/round',
            views: {
                'view-content': {
                    templateUrl: 'app/modules/game/round.html',
                    controller: 'Round as vm',
                }
            }
        })

        $urlRouterProvider.otherwise('/home')

    })
})()