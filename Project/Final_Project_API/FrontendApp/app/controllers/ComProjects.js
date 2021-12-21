app.controller("ComProjects",function($scope,$http){
  //    $scope.fname="";
     $http.get("https://localhost:44322/api/Project/complete").
     then(function(resp){
         $scope.ComProjects=resp.data;
     });   
  });
  