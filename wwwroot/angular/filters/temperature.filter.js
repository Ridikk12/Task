
angular.module('mediaApp').filter('temperature', function() {
    return function(input) {
        return input+'℃';
    };
});