app.controller("FairChart",function($scope,$http){
    $http.get("https://localhost:44371/api/chart/all").
    then(function(resp){
        $scope.FairChart=resp.data;
    });
 
     
 });