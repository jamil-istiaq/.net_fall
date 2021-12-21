var app = angular.module("myApp", ["ngRoute"]);
app.config(["$routeProvider","$locationProvider",function($routeProvider,$locationProvider) {

    $routeProvider
    .when("/", {
        templateUrl : "views/pages/Login.html"
    })
    .when("/Login", {
        templateUrl : "views/pages/Login.html",
        controller: 'Login'
    })
    .when("/Logout", {
        templateUrl : "views/pages/Login.html",
        controller: 'Logout'
    })
    .when("/Signup", {
        templateUrl : "views/pages/Signup.html",
        controller: 'Signup'
    })
    .when("/Home", {
        templateUrl : "views/pages/Home.html",
        controller: 'Home'
    })
    .when("/Profile", {
        templateUrl : "views/pages/Profile.html",
        controller: 'Home'
    })
    .when("/Purchase", {
        templateUrl : "views/pages/Purchase.html",
        controller: 'Purchase'
    })

    .when("/Pendingticket", {
        templateUrl : "views/pages/PendlingTkt.html",
        controller: 'PendingTicket'
    })
    
    .when("/FairChart", {
        templateUrl : "views/pages/FairChart.html",
        controller: 'FairChart'
    })

    .when("/TrainList", {
        templateUrl : "views/pages/TrainList.html",
        controller: 'TrainList'
    })
    .when("/StationList", {
        templateUrl : "views/pages/StationList.html",
        controller: 'StationList'
    })

    .when("/Update", {
        
        controller: 'Update'
    })
    
    .otherwise({
        redirectTo:"/"
    });
      //$locationProvider.html5Mode(true);
      //$locationProvider.hashPrefix('');
      //if(window.history && window.history.pushState){
      //$locationProvider.html5Mode(true);
  //}

}]);

app.config(function($httpProvider){
    $httpProvider.interceptors.push('interCeptor');
});
