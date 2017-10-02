angular.module('db1.avaliacao.tecnica.rh').
    controller('job-oportunity-list', function ($scope, $routeParams, $http) {
        $http({
            url: "http://localhost:51608/api/JobOportunity/",
            method: "get"
        }).then(function (success) {
            $scope.jobOportunities = success.data;
            }, function (error) {
                console.log(error);
        });
    });