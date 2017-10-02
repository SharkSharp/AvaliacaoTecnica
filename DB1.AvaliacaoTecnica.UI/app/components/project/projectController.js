angular.module('db1.avaliacao.tecnica').component('project',
{
    templateUrl: 'app/components/project/project.html',
    controller: function ($scope, $http, $attrs) {
        $attrs.$observe('id', value => $scope.id = value);
        $attrs.$observe('name', value => $scope.name = value);
        $attrs.$observe('url', value => $scope.url = value);
    }
});