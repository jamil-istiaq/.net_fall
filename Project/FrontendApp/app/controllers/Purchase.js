app.controller("Purchase",function($scope,$http){
    $http.get("https://localhost:44371/api/ticket/purchase").
    then(function(resp){
        $scope.Purchase=resp.data;
    });
 
     
 });