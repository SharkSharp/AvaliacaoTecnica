angular.module('db1.avaliacao.tecnica.rh').component('oportunity',
{
    templateUrl: 'app/components/job-oportunity/job-oportunity.html',
    controller: function ($window, $scope, $http, $attrs) {

        $attrs.$observe('id', value => $scope.id = value);
        $attrs.$observe('name', value => $scope.name = value);

        $scope.delete = function (id) {
            $http.delete("http://localhost:51608/api/JobOportunity/" + id)
                .then(function (success) {
                    $window.location.href = '#!/JobOportunity/List';
                }, function (error) {
                    console.log(error);
                });
        
        }
    }
});