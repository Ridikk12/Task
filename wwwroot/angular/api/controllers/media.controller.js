(function () {
	'use strict';

	angular
		.module('mediaApp')
		.controller('mediaController', mediaController);

	mediaController.$inject = ['$scope', 'dataService'];

	function mediaController($scope, dataService) {
		$scope.electricityData  = {};
		$scope.heatData = {};

		dataService.getElectricity().then(function (result) {
			$scope.electricityData = result.data;
		});

		dataService.getHeat().then(function (result) {
			$scope.heatData = result.data;
		});
	}


})();
