window.app = angular.module 'app', []

app.controller 'CalculationController', ($scope, $http) ->
	$scope.numberType = ""
	$scope.generatedId = ""
	$scope.generate = ->
		promise = $http.get("/api/numbers/"+$scope.numberType)
		promise.success (data) ->
			$scope.generatedId = data
		promise.error ->
			$scope.generatedId = ''