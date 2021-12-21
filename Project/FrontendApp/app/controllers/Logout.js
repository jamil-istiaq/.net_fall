app.controller("Logout",function($http){

    $http.get("https://localhost:44371/api/logout")

    .then(function(rsp){

        localStorage.removeItem("token");

        localStorage.removeItem("UID");

        $location.path("/Login")

    },function(err){

        console.log(err);

    });



});