
app.controller("Supervisor",function($scope,$http){
    $http.get("https://localhost:44322/api/Project/sup").
    then(function(resp){
        $scope.Supervisor=resp.data;
    });
 
     
 });
 