app.controller("Home",function($scope,$http){
   $http.get("https://localhost:44322/api/Project/all").
   then(function(resp){
       $scope.Home=resp.data;
   });

    
});
