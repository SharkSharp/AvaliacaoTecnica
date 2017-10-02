angular.module('db1.avaliacao.tecnica.rh').
    controller('job-oportunity-create', function ($window, $scope, $routeParams, $http) {

        $scope.create = function (jobOportunity) {
            var parameter = JSON.stringify({ Name: jobOportunity.name });

            $http.post("http://localhost:51608/api/JobOportunity/", parameter)
                .then(function (success) {
                    $window.location.href = '#!/JobOportunity/List';
                }, function (error) {
                    console.log(error);
                });;

        }
    });