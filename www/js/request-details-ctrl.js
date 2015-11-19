(function () {
    'use strict';

    angular.module('BloodDonationApp')
        .controller('RequestDetailsCtrl', ['BloodDonationApi', '$stateParams','$state', '$scope', RequestDetailsCtrl]);

    function RequestDetailsCtrl(BloodDonationApi, $stateParams,$state, $scope) {
        var vm = this;
        var data = BloodDonationApi.getRequests();
        console.log(data);
        vm.requestDetails = data;
        console.log("$stateParams", $stateParams.id);
        
        //end Data Binding//
        //  Get you request

        $scope.goToRegister = function () {
            $state.go('home.ClientRegister',{id:5});
        }
        console.log("$stateParams", $stateParams.id);


    };
})();