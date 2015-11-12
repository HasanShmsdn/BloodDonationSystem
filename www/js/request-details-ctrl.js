(function () {
    'use strict';

    angular.module('BloodDonationApp')
        .controller('RequestDetailsCtrl', ['BloodDonationApi', '$stateParams', '$scope', RequestDetailsCtrl]);

    function RequestDetailsCtrl(BloodDonationApi, $stateParams, $scope) {
        var vm = this;
        var data = BloodDonationApi.getRequests();
        console.log(data);
        vm.requestDetails = data;
        console.log("$stateParams", $stateParams.id);
        
        //end Data Binding//
        //  Get you request


    };
})();