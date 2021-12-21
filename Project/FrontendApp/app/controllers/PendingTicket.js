app.controller("PendingTicket",function($scope,$http){

    UID=localStorage.getItem("UID");
    
    $http.get("https://localhost:44371/api/ticket/" + UID)

   .then(function(resp){
       $scope.PendingTicket=resp.data;
       console.log(resp);
   });

    
});