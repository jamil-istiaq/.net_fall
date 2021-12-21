app.controller("TrainList",function($scope,$http){
    $http.get("https://localhost:44371/api/trainlist/all").
    then(function(resp){
        $scope.TrainList=resp.data;
    });
 
     
 });