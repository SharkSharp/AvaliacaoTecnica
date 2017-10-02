angular.module('db1.avaliacao.tecnica').
    controller('userList', function ($scope) {
        $scope.users = [
            { login: "Trollencio" },
            { login: "SharkSharp" },
            { login: "edemilsongithub" }
        ];
    });