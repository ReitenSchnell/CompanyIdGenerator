window.app = angular.module 'app', []

app.controller 'CalculationController', ($scope) ->
    $scope.phones = ['1', '2', '3']
