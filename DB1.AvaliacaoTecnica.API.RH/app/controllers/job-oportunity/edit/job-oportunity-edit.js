angular.module('db1.avaliacao.tecnica.rh').
    controller('job-oportunity-edit', function ($window, $scope, $routeParams, $http) {

        $http({
            url: "http://localhost:51608/api/JobOportunity/" + $routeParams.id,
            method: "get"
        }).then(function (success) {
            $scope.jobOportunity = { name: success.data.Name, id: success.data.Id };
        }, function (error) {
            console.log(error);
        });

        $scope.edit = function (jobOportunity) {
            var parameter = JSON.stringify({ Name: jobOportunity.name, Id: jobOportunity.id });
            $http.put("http://localhost:51608/api/JobOportunity/", parameter)
                .then(function (success) {
                    $window.location.href = '#!/JobOportunity/List';
                }, function (error) {
                    console.log(error);
                });
        }
    });