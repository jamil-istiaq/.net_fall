app.controller('Signup',function($scope,ajax)
{
    $scope.submit=function(){
        var data={
            User_ID: $scope.User_ID="",
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
        ajax.post("https://localhost:44371/api/user/signup", data, success, error);

        function success(res){
            console.log("Success Operation");
        }
        function error(res){
            console.log(res);
        }
    };

});