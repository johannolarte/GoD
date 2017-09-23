(function () {
    'use strict';

    var app = angular.module('app')

    app.run(function (
        $rootScope,
        $state,
        $timeout,
        //PopUps,
        //AuthenticationService,
        Constants,
        $window) {

        //AuthenticationService.init()

        $rootScope.$on('event:auth-logout-complete', function () {
            $state.go(Constants.ROUTER.stateAuth)
        })

        $rootScope.$on('event:auth-loginRequired', function () {
            //PopUps.hideLoading()
            //AuthenticationService.logout()
        })

        $rootScope.$on('event:auth-forbidden', function () {
            //PopUps.showMessage(Constants.MESSAGES.forbiddenError)
            $state.go(Constants.ROUTER.stateHome)
        })

        $rootScope.$on('event:notFound', function () {
            //PopUps.hideLoading()
            //PopUps.showError(Constants.MESSAGES.notFoundError)
        })

        $rootScope.$on('event:internalServerError', function () {
            //PopUps.hideLoading()
            //PopUps.showError(Constants.MESSAGES.unexpectedError)
        })

        // on state change you want to check whether or not the state.
        $rootScope.$on("$stateChangeStart", function (event, toState, toParams, fromState, fromParams) {

            if (toState.external) {
                event.preventDefault()
                $window.open(toState.url, '_blank')
                return
            }

            //toState.name
            //if (!toState.authenticatedAccess && AuthenticationService.isLoggedIn()) {
            //    event.preventDefault()
            //    return $state.go(Constants.ROUTER.stateHome)
            //}
            //else if (toState.authenticatedAccess && !AuthenticationService.isLoggedIn()) {
            //    event.preventDefault()
            //    return $state.go(Constants.ROUTER.stateAuth)
            //}
            //else if (toState.validateAccess !== false &&
            //    toState.authenticatedAccess &&
            //    AuthenticationService.isLoggedIn() &&
            //    !AuthenticationService.haveAccess(toState.name)) {

            //    event.preventDefault()
            //    return $state.go(Constants.ROUTER.stateHome)
            //}

            //if (AuthenticationService.identityData)
            //    setTitle(toState)

            return
        })

        $rootScope.$on("$stateChangeSuccess", function (event, toState, toParams, fromState, fromParams) {
            //PopUps.hideLoading()
        })

        function setTitle(toState) {
            //var resource = _(AuthenticationService.identityData.resources)
            //    .find((toState.data && toState.data.parentName) ?
            //    { Name: toState.data.parentName } : { StateOrUrl: toState.name })

            //if (resource.Parent) {
            //    $rootScope.subOptionDescription = resource.Description
            //    var parentResource = _(AuthenticationService.identityData.resources)
            //        .find({ Name: resource.Parent })
            //    $rootScope.optionDescription = parentResource ? parentResource.Description : ''
            //}
            //else {
            //    $rootScope.optionDescription = resource.Description
            //    $rootScope.subOptionDescription = ''
            //}
        }

        $("#appBody").addClass("loaded")
    })

})()