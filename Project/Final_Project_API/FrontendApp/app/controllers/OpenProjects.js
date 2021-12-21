app.controller("OpenProjects",function($scope,$http,ajax){
  
     $http.get("https://localhost:44322/api/Project/open").
     then(function(resp){
         $scope.OpenProjects=resp.data;
     });
     
     $scope.apply=function(){
      var data={
        Proj_Id: $scope.Proj_Id,
        MemId: $scope.MemId,
        State: $scope.State="Open"

      };
      //console.log(data); 
      ajax.post("https://localhost:44322/api/Project/Apply", data, success, error);

      function success(res){
          console.log("Success Operation");
      }
      function error(res){
          console.log(res);
      }
  };
    

  });
  