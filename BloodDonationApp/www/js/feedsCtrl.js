(function () {
    'use strict';

    angular.module('BloodDonationApp')
        .controller('FeedsCtrl', ['BloodDonationApi', '$scope', '$state', FeedsCtrl]);

    function FeedsCtrl(BloodDonationApi, $scope, $state) {
        var vm = this;
        //start Data Binding functions//
        var data = BloodDonationApi.getRequests();
        console.log(data);
        vm.feeds = data;
        //end Data Binding//



        //start Accordion function//

        $scope.toggleGroup = function (requests) {
            if ($scope.isGroupShown(requests)) {
                $scope.shownGroup = null;
            } else {
                $scope.shownGroup = requests;
            }
         
        }

        $scope.isGroupShown = function (requests) {
            return $scope.shownGroup === requests;
        }
        $scope.goToDetails = function() {
            $state.go('home.request', {id : 5});
        }
       

        //end Accordion function//

    };
})();