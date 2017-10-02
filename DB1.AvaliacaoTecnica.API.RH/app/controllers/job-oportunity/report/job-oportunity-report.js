angular.module('db1.avaliacao.tecnica.rh').
    controller('job-oportunity-report', function ($scope, $routeParams, $http) {

        $scope.dict = {}

        $http({
            url: "http://localhost:51608/api/Technology/",
            method: "get"
        }).then(function (success) {
            $scope.technologies = success.data;
        }, function (error) {
            console.log(error);
            });

        $scope.report = function (dict) {
            var parameter = JSON.stringify(Object.keys(dict).map(x => { return { Id: x, Grade: dict[x] } }));
            $http.post("http://localhost:51608/api/JobOportunity/Report/" + $routeParams.id, parameter)
                .then(function (success) {
                    $scope.results = success.data;
                }, function (error) {
                    
                });
        }
    });