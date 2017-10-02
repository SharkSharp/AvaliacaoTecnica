angular.module('db1.avaliacao.tecnica').
    controller('userDetail', function ($scope, $routeParams, $http) {
        $http({
            url: "https://api.github.com/users/" + $routeParams.login,
            method: "get"
        }).success(function (data, status, headers, config) {
            $scope.id = data.id;
            $scope.login = $routeParams.login;
            $scope.url = data.html_url;
            $scope.createdAt = data.created_at;
        }).error(function (data, status, headers, config) {
            $scope.login = data;
            $scope.id = 'ERROR';
            $scope.createdAt = 'ERROR';
            $scope.url = '#';
            });

        $http({
            url: "https://api.github.com/users/" + $routeParams.login + "/repos",
            method: "get"
        }).success(function (data, status, headers, config) {
            $scope.projects = data;
        });
    });

// /users/:username / repos