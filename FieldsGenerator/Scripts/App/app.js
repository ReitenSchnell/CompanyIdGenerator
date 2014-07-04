(function() {

  window.app = angular.module('app', []);

  app.controller('CalculationController', function($scope, $http) {
    return $scope.phones = ['1', '2', '3'];
  });

}).call(this);
