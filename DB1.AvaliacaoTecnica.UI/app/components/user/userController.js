angular.module('db1.avaliacao.tecnica').component('user',
{
    styleUrls: ['app/components/user/user.css'],
    templateUrl: 'app/components/user/user.html',
    controller: function ($scope, $http, $attrs) {

        $attrs.$observe('login', function (value) {
            $http({
                url: "https://api.github.com/users/" + value,
                method: "get"
            }).success(function (data, status, headers, config) {
                $scope.id = data.id;
                $scope.login = $attrs.login;
            }).error(function (data, status, headers, config) {
                $scope.login = 'ERROR';
                $scope.id = 'ERROR';
            });
        });
    }
});