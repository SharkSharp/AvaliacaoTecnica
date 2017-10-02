angular.module('db1.avaliacao.tecnica.rh').
    controller('interview-create', function ($window, $scope, $routeParams, $http) {

        $http({
            url: "http://localhost:51608/api/Candidate/" + $routeParams.id,
            method: "get"
        }).then(function (success) {
            $scope.candidate = { name: success.data.Name, id: success.data.Id };
        }, function (error) {
            console.log(error);
        });

        $http({
            url: "http://localhost:51608/api/JobOportunity/",
            method: "get"
        }).then(function (success) {
            $scope.jobOportunities = success.data;
        }, function (error) {
            console.log(error);
        });

        $http({
            url: "http://localhost:51608/api/Technology/",
            method: "get"
        }).then(function (success) {
            $scope.technologies = success.data;
        }, function (error) {
            console.log(error);
        });


        $scope.create = function (candidate, jobOportunity, technology) {
            var parameter = JSON.stringify({ Candidate: { Id: candidate.id }, JobOportunity: { Id: jobOportunity.selected }, Technologies: technology.selected.map(x => { return { Technology: { Id: x } } }) });

            $http.post("http://localhost:51608/api/Interview/", parameter)
                .then(function (success) {
                    $window.location.href = '#!/Candidate/List';
                }, function (error) {
                    console.log(error);
                });;

        }
    });