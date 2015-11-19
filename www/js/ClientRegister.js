(function () {
    'use strict';

    angular.module('BloodDonationApp')
        .controller('ClientRegisterCtrl', ['BloodDonationApi', '$stateParams', '$state', '$scope', ClientRegisterCtrl]);

    function ClientRegisterCtrl(BloodDonationApi, $stateParams, $state, $scope) {
        var vm = this;
        var data = BloodDonationApi.getRequests();
        console.log(data);
        vm.requestDetails = data;
        console.log("$stateParams", $stateParams.id);

        //end Data Binding//
        //  Get you request

       
        console.log("$stateParams", $stateParams.id);


    };
})();