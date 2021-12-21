app.controller("Home",function($scope,$http){

    UID=localStorage.getItem("UID");
    
    $http.get("https://localhost:44371/api/users/" + UID)

   .then(function(resp){
       $scope.Home=resp.data;
       console.log(resp);
   });

    
});