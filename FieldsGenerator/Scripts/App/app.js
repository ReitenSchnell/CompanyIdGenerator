(function() {

  window.app = angular.module('app', []);

  app.controller('CalculationController', function($scope, $http) {
    $scope.numberType = "";
    $scope.generatedId = "";
    return $scope.generate = function() {
      var promise;
      promise = $http.get("/api/numbers/" + $scope.numberType);
      promise.success(function(data) {
        return $scope.generatedId = data;
      });
      return promise.error(function() {
        return $scope.generatedId = '';
      });
    };
  });

}).call(this);
