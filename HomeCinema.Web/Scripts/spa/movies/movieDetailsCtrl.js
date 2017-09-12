(function (app) {
    'use strict';

    app.controller('movieDetailsCtrl', movieDetailsCtrl);

    movieDetailsCtrl.$inject = ['$scope', '$location', '$routeParams', '$modal', 'apiService', 'notificationService'];

    function movieDetailsCtrl($scope, $location, $routeParams, $modal, apiService, notificationService) {
        $scope.pageClass = 'page-movies';
        $scope.movie = {};
        $scope.loadingMovie = true;
        $scope.loadingRentals = true;
        $scope.isReadOnly = true;
        $scope.getStatusColor = getStatusColor;
        $scope.clearSearch = clearSearch;
        $scope.isBorrowed = isBorrowed;

        function loadMovie() {

            $scope.loadingMovie = true;
            apiService.get('/api/movies/details/' + $routeParams.id, null, movieLoadCompleted, movieLoadFailed);
        }

        function movieLoadCompleted(result) {
            $scope.movie = result.data;
            $scope.loadingMovie = false;
        }

        function movieLoadFailed(response) {
            notificationService.displayError(response.data);
        }

    
        function loadMovieDetails() {
            loadMovie();
        }


        function clearSearch()
        {
            $scope.filterRentals = '';
        }


    }

})(angular.module('homeCinema'));