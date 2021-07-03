/// <reference path="../scripts/angular.js" />

var app = angular.module("module", []);
app.controller("myController", function ($scope, $http) {
    $scope.EmployeeList = [];
    $scope.GetEmployee = function() {

        $http({
            method: 'get',
            url: "/Employee/GetEmployee"
        }).then(function(response) {
            $scope.EmployeeList = response.data;
            console.log(response);
        });
    };
})