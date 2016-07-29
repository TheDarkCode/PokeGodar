angular.module('html', [])
          .directive('anchorBottom', function () {
              return {
                  restrict: 'A',
                  priority: 999,
                  scope: {},
                  link: function (scope, element, attr) {
                      function resize() {
                          element.height($(window).height() - element.parent().position().top);
                          element.show();
                      }

                      element.css({
                          width: '100%',
                          position: 'fixed',
                          bottom: 0,
                          display: 'none'
                      });

                      $(window).on('resize', resize);
                      setTimeout(resize, 200);
                  }
              };
          });