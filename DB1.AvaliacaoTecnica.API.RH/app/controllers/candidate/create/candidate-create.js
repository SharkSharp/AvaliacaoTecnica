angular.module('db1.avaliacao.tecnica.rh').
    controller('candidate-create', function ($window, $scope, $routeParams, $http) {

        $scope.create = function (candidate) {
            var parameter = JSON.stringify({ Name: candidate.name });

            $http.post("http://localhost:51608/api/Candidate/", parameter)
                .then(function (success) {
                    $window.location.href = '#!/Candidate/List';
                }, function (error) {
                    console.log(error);
                });;

        }
    });