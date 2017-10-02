angular.module('db1.avaliacao.tecnica.rh').
    controller('technology-list', function ($scope, $routeParams, $http) {
        $http({
            url: "http://localhost:51608/api/Technology/",
            method: "get"
        }).then(function (success) {
            $scope.technologies = success.data;
            }, function (error) {
                console.log(error);
        });
    });