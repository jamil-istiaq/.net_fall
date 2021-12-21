app.controller("InProjects",function($scope,$http){
  //    $scope.fname="";
     $http.get("https://localhost:44322/api/Project/inprocess").
     then(function(resp){
         $scope.InProjects=resp.data;
     });   
  });
  