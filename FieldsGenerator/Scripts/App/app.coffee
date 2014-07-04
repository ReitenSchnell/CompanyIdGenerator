window.app = angular.module 'app', []

app.controller 'CalculationController', ($scope, $http) ->
    $scope.phones = ['1', '2', '3']
