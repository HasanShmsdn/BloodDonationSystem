var local = "http://localhost:21466/api/";
(function () {
    'use strict';

    angular.module('BloodDonationApp').factory('BloodDonationApi', ['$http','$ionicLoading','$stateParams','$q','CacheFactory',BloodDonationApi]);

    function BloodDonationApi($http,$ionicLoading,$stateParams,$q,CacheFactory) {
        self.FeedsCache = CacheFactory.get("FeedsCache");
        self.FeedsCache.setOptions({
            onExpire: function (key, value) {
                getfeeds()
                    .then(function () {
                    console.log("Feeds cache was  refreshed");
                }, function () {
                    console.log("Error getting data putting expire data item back into the Feedscache");
                    self.FeedsCache.put(key, value);
                });
            }
        });
        /*GetAllFeeds*/
        function getfeeds(forceRefresh) {
            if (typeof forceRefresh === "undefined") {
                forceRefresh = false;
            }
            var cacheKey = "Feeds";
            var feedsdata = null;
            var deferred = $q.defer();
            if (!forceRefresh) {
                var feedsdata = self.FeedsCache.get(cacheKey);
            };
            if (feedsdata) {
                console.log("found data inside the cache", feedsdata);
                deferred.resolve(feedsdata);
            } else {
                $ionicLoading.show({
                    template: '...Loading'
                });
                $http.get(local + "Feeds/Getall").success(function(data) {
                        self.FeedsCache.put(cacheKey, data);
                        $ionicLoading.hide();
                        deferred.resolve(data);
                        console.log("received feedsdata via http", data, status);
                    })
                    .error(function() {
                        $ionicLoading.hide();
                        console.log("error http");
                        deferred.reject();
                    });
            }
            return deferred.promise;
        }

/*END GetAllFeeds*/


// var requests = JSON.parse('[{"id":1,"unitNb":5,"Hosplocation":"beirut","HospName":"Shkieh rageb hareb","type":"A+"},{"id":2,"unitNb":8,"Hosplocation":"beirut","HospName":"Shkieh rageb hareb","type":"O+"},{"id":3,"unitNb":3,"Hosplocation":"beirut","HospName":"Shkieh rageb hareb","type":"B+"},{"id":4,"unitNb":6,"Hosplocation":"beirut","HospName":"Shkieh rageb hareb","type":"AB+"},{"id":5,"unitNb":2,"Hosplocation":"beirut","HospName":"Shkieh rageb hareb","type":"AB-"}]');
        //    function getRequests() {
        //    return requests;
        //  }
        //   return {
        //  getRequests: getRequests
        return {
            getfeeds: getfeeds
        };
    };
})();