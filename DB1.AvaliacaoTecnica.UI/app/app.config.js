angular.module('db1.avaliacao.tecnica')
    .config(function ($routeProvider) {
        $routeProvider
            .when('/userList', {
                templateUrl: 'app/controllers/userList/userList.html',
                controller: 'userList'
            })
            .when('/userDetail/:login', {
                templateUrl: 'app/controllers/userDetail/userDetail.html',
                controller: 'userDetail'
            })
            .otherwise({
                redirectTo: '/userList'
            });
    });