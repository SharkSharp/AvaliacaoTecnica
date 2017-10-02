angular.module('db1.avaliacao.tecnica.rh').component('candidate',
{
    templateUrl: 'app/components/candidate/candidate.html',
    controller: function ($window, $scope, $http, $attrs) {

        $attrs.$observe('id', value => $scope.id = value);
        $attrs.$observe('name', value => $scope.name = value);

        $scope.delete = function (id) {
            $http.delete("http://localhost:51608/api/Candidate/" + id)
                .then(function (success) {
                    $window.location.href = '#!/Candidate/List';
                }, function (error) {
                    console.log(error);
                });
        
        }
    }
});