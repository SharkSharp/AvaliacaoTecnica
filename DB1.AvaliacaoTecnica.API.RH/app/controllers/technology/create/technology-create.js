angular.module('db1.avaliacao.tecnica.rh').
    controller('technology-create', function ($window, $scope, $routeParams, $http) {

        $scope.create = function (technology) {
            var parameter = JSON.stringify({ Name: technology.name });

            $http.post("http://localhost:51608/api/Technology/", parameter)
                .then(function (success) {
                    $window.location.href = '#!/Technology/List';
                }, function (error) {
                    console.log(error);
                });;

        }
    });