(function () {
    var controllerId = 'Round'

    angular.module('app').controller(controllerId,
        [Round])

    function Round() {

        var vm = this

        vm.roundCounter = 1
    }
})()