angular.module('db1.avaliacao.tecnica.rh').component('technology',
{
    templateUrl: 'app/components/technology/technology.html',
    controller: function ($window, $scope, $http, $attrs) {

        $attrs.$observe('id', value => $scope.id = value);
        $attrs.$observe('name', value => $scope.name = value);

        $scope.delete = function (id) {
            $http.delete("http://localhost:51608/api/Technology/" + id)
                .then(function (success) {
                    $window.location.href = '#!/Technology/List';
                }, function (error) {
                    console.log(error);
                });
        
        }
    }
});