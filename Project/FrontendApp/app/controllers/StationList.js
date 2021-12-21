app.controller("StationList",function($scope,$http){
    $http.get("https://localhost:44371/api/route/all").
    then(function(resp){
        $scope.StationList=resp.data;
    });
 
     
 });