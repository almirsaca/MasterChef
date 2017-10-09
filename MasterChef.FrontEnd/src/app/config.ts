function makeAppConfig() {

    console.log('makeAppConfig');

    const date = new Date();
    const year = date.getFullYear();
    const WebApiServer = window.location.href.indexOf("localhost") > 1 ? 'http://localhost:58877' : '/service';
    const AppConfig = {
        brand: 'Visual SMS',
        Usuario: JSON.parse(localStorage.getItem('currentUser')),
        ApiUrl: WebApiServer + '/api/',
        TokenUrl: WebApiServer + '/token'
    };

    return AppConfig;
}

export const APPCONFIG = makeAppConfig();
