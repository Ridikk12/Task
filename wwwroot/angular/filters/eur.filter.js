
angular.module('mediaApp').filter('eur', function () {
	return function (input) {
		return input + ' eur';
	};
});