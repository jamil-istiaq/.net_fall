app.controller("Login", function($scope, $http, $location){
    $scope.login=function(){
        $http.post("https://localhost:44371/api/login",$scope.data)
    .then(function(resp){
        console.log(resp.data);
        
        localStorage.setItem("token", resp.data.AccessToken);
        
        localStorage.setItem("UID", resp.data.User_ID);
        //$location.path("/index");
    },
    function(err){
        console.log(err);

    });
    };
});