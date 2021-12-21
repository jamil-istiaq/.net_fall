app.controller("Member",function($scope,$http){
    $http.get("https://localhost:44322/api/Project/mem").
    then(function(resp){
        $scope.Member=resp.data;
    });
 
     
 });
 