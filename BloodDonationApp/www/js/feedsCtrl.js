var baseService = "http://localhost:21466/api";
(function () {
    'use strict';

    angular.module('BloodDonationApp')
        .controller('FeedsCtrl', ['BloodDonationApi', '$http','$window','$location','$scope', 'CacheFactory', FeedsCtrl]);

    function FeedsCtrl(BloodDonationApi, $http, $scope, $state, $window, $location, CacheFactory) {
        var vm = this;
       
            var cache = CacheFactory.get("RegisterCache");
             vm.loadList = function(forceRefresh) {
            BloodDonationApi.getfeeds(forceRefresh).then(function(data) {
                vm.feeds = data;
                if (cache == undefined) {
                    vm.isRegistered = false;
                 } else {
                     vm.isRegistered = true;
                  }
            }).finally(function() {
                $scope.$broadcast('scroll.refreshComplete');
            });
        }; 
        //};
             vm.loadList(false);

        $scope.donte= function(id) {
            $http.post(baseService + "Feeds/PutRegister/" + id)
                .sucess(function(data) {
                    $location.path("/feeds");
                    console.log("received one register via http", data, status);
                })
                .error(function() {
                    console.log("error get one register");
                });
        }

        //start Data Binding functions//
       //var data = BloodDonationApi.getfeeds();
    //   console.log(data);
    //    vm.feeds = data;
    //    //end Data Binding//

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