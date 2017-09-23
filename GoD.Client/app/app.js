/*** Bootstrapping Modules ***/
angular.module('services.security', [])
angular.module('services.common', [])
angular.module('services.app', [])
//angular.module('employee.helpers', [])

var app = angular.module('app', [
    'ui.router',
    'http-auth-interceptor',
    'services.security',
    'services.common',
    'services.app'
])
