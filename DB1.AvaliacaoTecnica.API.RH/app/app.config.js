angular.module('db1.avaliacao.tecnica.rh')
    .config(function ($routeProvider) {
        $routeProvider
            .when('/Technology/List', {
                templateUrl: 'app/controllers/technology/list/technology-list.html',
                controller: 'technology-list'
            })
            .when('/Technology/Create', {
                templateUrl: 'app/controllers/technology/create/technology-create.html',
                controller: 'technology-create'
            })
            .when('/Technology/Edit/:id', {
                templateUrl: 'app/controllers/technology/edit/technology-edit.html',
                controller: 'technology-edit'
            })
            .when('/JobOportunity/List', {
                templateUrl: 'app/controllers/job-oportunity/list/job-oportunity-list.html',
                controller: 'job-oportunity-list'
            })
            .when('/JobOportunity/Create', {
                templateUrl: 'app/controllers/job-oportunity/create/job-oportunity-create.html',
                controller: 'job-oportunity-create'
            })
            .when('/JobOportunity/Edit/:id', {
                templateUrl: 'app/controllers/job-oportunity/edit/job-oportunity-edit.html',
                controller: 'job-oportunity-edit'
            })
            .when('/JobOportunity/Report/:id', {
                templateUrl: 'app/controllers/job-oportunity/report/job-oportunity-report.html',
                controller: 'job-oportunity-report'
            })
            .when('/Candidate/List', {
                templateUrl: 'app/controllers/candidate/list/candidate-list.html',
                controller: 'candidate-list'
            })
            .when('/Candidate/Create', {
                templateUrl: 'app/controllers/candidate/create/candidate-create.html',
                controller: 'candidate-create'
            })
            .when('/Candidate/Edit/:id', {
                templateUrl: 'app/controllers/candidate/edit/candidate-edit.html',
                controller: 'candidate-edit'
            })
            .when('/Interview/Create/:id', {
                templateUrl: 'app/controllers/interview/create/interview-create.html',
                controller: 'interview-create'
            })
            .otherwise({
                redirectTo: '/JobOportunity/List'
            });
    });