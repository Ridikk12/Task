(function () {
	'use strict';

	angular
		.module('mediaApp')
		.service('dataService', dataService);

	dataService.$inject = ['$http','mediaAPI'];

	function dataService($http, mediaAPI) {

		var self = this;
		
		self.getElectricity = function () {
			return $http.get(mediaAPI.getElectricity);
		}

		self.getHeat = function () {
			return $http.get(mediaAPI.getHeat);
		}
	}
})();
