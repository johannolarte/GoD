(function () {
    'use strict'

    var app = angular.module('app')

    app.config(['$logProvider', AppConfig])

    function AppConfig($logProvider) {
        // turn debugging off/on (no info or warn)
        if ($logProvider.debugEnabled) {
            $logProvider.debugEnabled(true)
        }
    }

})()