angular.module('db1.avaliacao.tecnica.rh').
    controller('technology-edit', function ($window, $scope, $routeParams, $http) {

        $http({
            url: "http://localhost:51608/api/Technology/" + $routeParams.id,
            method: "get"
        }).then(function (success) {
            $scope.technology = { name: success.data.Name, id: success.data.Id };
        }, function (error) {
            console.log(error);
        });

        $scope.edit = function (technology) {
            var parameter = JSON.stringify({ Name: technology.name, Id: technology.id });
            $http.put("http://localhost:51608/api/Technology/", parameter)
                .then(function (success) {
                    $window.location.href = '#!/Technology/List';
                }, function (error) {
                    console.log(error);
                });
        }
    });