// app.controller("Update", function($scope, $http, $location){
//     $scope.Update=function(){
//         $http.post("https://localhost:44371/api/user/update",$scope.data)
//     .then(function(resp){
//         console.log(resp.data);
//         alert("Done Update")
        
//     },
//     function(err){
//         console.log(err);

//     });
//     };
// });

app.controller('Update',function($scope,ajax)
{
    $scope.submit=function(){
        var data={
            //User_ID: $scope.User_ID="",
            Name: $scope.Name,
            Email: $scope.Email,
            Password: $scope.Password,
            Phone: $scope.Phone,
            NID: $scope.NID,
            Address: $scope.Address,
            Gender: $scope.Gender,
            Role: $scope.Role="User"
        };
        //console.log(data);
        ajax.post("https://localhost:44371/api/user/update", data, success, error);

        function success(res){
            console.log("Success Operation");
        }
        function error(res){
            console.log(res);
        }
    };

});