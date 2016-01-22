angular.module("BloodDonationApp", [
    "ionic",
    "angular-cache",
    "ngStorage",
    "toaster",
    "ngStorage"

    
 
])

.run(function ($ionicPlatform,  CacheFactory, $http, BloodDonationApi) {
    $ionicPlatform.ready(function () {
        if (window.cordova && window.cordova.plugins && window.cordova.plugins.keyboard) {
            cordova.plugins.keyboard.hidekeyboardAccessoryBar(true);
        }
        if (window.statusBar) {
            //org.apache.cordova.statusbar required
            statusbar.styleDefault();
        }
       
    });
})
/*.service(function(CacheFactory) {
    var FeedsCache;
    if (!CacheFactory.get("FeedsCache")) {
        CacheFactory.createCache("FeedsCache", { storageMode: "localStorage", maxAge: 5000000, deleteOnExpire: "aggressive" });
        var FeedsCache = CacheFactory.get("FeedsCache");
        return {
            findFeedsById: function(id) {
                return $http.get('/api/Feeds/' + id, { cache: FeedsCache });
            }
        }
    }
    })*/
    //****************ROUTES***************//
.config(function (CacheFactoryProvider, $stateProvider, $urlRouterProvider) {

        $stateProvider
            .state('home', {
                abstarct: true,
                url: "/home",
                templateUrl: "templates/home.html"
            })
            .state('home.feeds', {
                url: "/feeds",
                views: {
                    "tab-feeds": {
                        templateUrl: "templates/feeds.html"
                    }
                }
            })
            .state('home.settings', {
                url: "/settings",
                views: {
                    "tab-settings": {
                        templateUrl: "templates/settings.html"
                    }
                }
            })
            .state('home.request', {
                
               url: "/details/:id",  
              views: {  
                'tab-feeds' :{  
                   templateUrl: "templates/requestDetails.html"  


        }
        }
    })
        .state('home.ClientRegister', {
            url: "/register/:id",
            views: {
                "tab-feeds": {
                    templateUrl: "templates/ClientRegister.html"
                }
            }
        });

    //if name of the above states are matched, use this as the fallback
    $urlRouterProvider.otherwise('/home/feeds');
})