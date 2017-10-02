angular.module('db1.avaliacao.tecnica.rh').
    controller('candidate-list', function ($scope, $routeParams, $http) {
        $http({
            url: "http://localhost:51608/api/Candidate/",
            method: "get"
        }).then(function (success) {
            $scope.candidates = success.data;
            }, function (error) {
                console.log(error);
        });
    });