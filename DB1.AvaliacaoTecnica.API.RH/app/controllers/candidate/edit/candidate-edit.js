angular.module('db1.avaliacao.tecnica.rh').
    controller('candidate-edit', function ($window, $scope, $routeParams, $http) {

        $http({
            url: "http://localhost:51608/api/Candidate/" + $routeParams.id,
            method: "get"
        }).then(function (success) {
            $scope.candidate = { name: success.data.Name, id: success.data.Id };
        }, function (error) {
            console.log(error);
        });

        $scope.edit = function (candidate) {
            var parameter = JSON.stringify({ Name: candidate.name, Id: candidate.id });
            $http.put("http://localhost:51608/api/Candidate/", parameter)
                .then(function (success) {
                    $window.location.href = '#!/Candidate/List';
                }, function (error) {
                    console.log(error);
                });
        }
    });