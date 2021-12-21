var app = angular.module("myApp", ["ngRoute"]);
app.config(["$routeProvider","$locationProvider",function($routeProvider,$locationProvider) {

    $routeProvider
    .when("/", {
        templateUrl : "views/pages/demopage.html"
    })
    .when("/Home", {
        templateUrl : "views/pages/Home.html",
        controller: 'Home'
    })
    .when("/OpenProject", {
        templateUrl : "views/pages/OpenProject.html",
        controller: 'OpenProjects'
    })
     .when("/ComProjects", {
         templateUrl : "views/pages/ComProjects.html",
           controller: 'ComProjects'
    })
     .when("/InProjects", {
         templateUrl : "views/pages/InProjects.html",
         controller: 'InProjects'
     })
     .when("/CreateProject", {
        templateUrl : "views/pages/CreateProject.html",
        controller: 'CreateProject'
    })
    .when("/Apply", {
        templateUrl : "views/pages/CreateProject.html",
        controller: 'Apply'
    })
    .when("/Supervisor", {
        templateUrl : "views/pages/Supervisor.html",
        controller: 'Supervisor'
    })
    .when("/Member", {
        templateUrl : "views/pages/Member.html",
        controller: 'Member'
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
