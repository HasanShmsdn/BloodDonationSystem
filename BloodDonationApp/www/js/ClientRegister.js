var baseService = "http://localhost:21466/api";
(function () {
    'use strict';

    angular.module('BloodDonationApp')
        .controller('ClientRegisterCtrl', ['$http','BloodDonationApi','$scope','$localStorage','$window','toaster','$location', '$stateParams','CacheFactory', ClientRegisterCtrl]);

    function ClientRegisterCtrl($http, BloodDonationApi, $scope, $localStorage, $window, toaster, $location, CacheFactory, $stateParams) {
        CacheFactory("ClientRegisterCache", { storageMode: "localStorage", maxAge: 5000000, deleteOnExpire: "aggressive" });
        self.ClientRegisterCache = CacheFactory.get("ClientRegisterCache");
        /*---------------SubmitRegister---------------*/
        var cachekey = "ClientRegisterCache";
        $scope.user = {};
        $scope.BloodRequestId = $stateParams.id;
        $scope.submit = function() {
            $http({
                method: 'POST',
                url: baseService + 'ClientRegister/ClientRegister',
                headers: { 'Content-Type': 'application/x-www-form-urlencoded' },
                transformRequest: function(obj) {
                    var str = [];
                    for (var p in obj)
                        str.push(encodeURIComponent(p) + "=" + encodeURIComponent(obj[p]));
                    return str.join("&");
                },
                data: {
                    ClientName: $scope.user.ClientName,
                    ClientPhoneNb: $scope.user.ClientPhoneNb,
                    ClientBloodType: $scope.user.ClientBloodType
                }
            }).success(function(data) {
                self.ClientRegisterCache.put(cachekey, data);
                $location.Path("/feeds");
            });
        };
        var myObj = {
            ClientName: $scope.user.ClientName,
            ClientPhoneNb: $scope.user.ClientPhoneNb,
            ClientBloodType: $scope.user.ClientBloodType
        }
        $scope.popsuccess = function() {
            toaster.pop('alert', "Registration Completed", "");
        };
        $scope.popsuccess();
        $scope.GetPreviousPage = function() {
            $window.history.back();
        };
        //var data = BloodDonationApi.getRequests();
        //console.log(data);
        //vm.requestDetails = data;
        //console.log("$stateParams", $stateParams.id);

        //end Data Binding//
        //  Get you request
       // console.log("$stateParams", $stateParams.id);


    };
})();