(function () {
    var controllerId = 'IndexMain'

    angular.module('app').controller(controllerId, [
        '$state',
        'Constants', IndexMain])

    function IndexMain(
        $state,
        Constants) {

        var vm = this
    }
})()