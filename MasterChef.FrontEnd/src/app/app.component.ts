import { Component } from '@angular/core';
import { UsuarioLogado } from "./models/usuarioLogado";
import { AuthenticationService } from './services/authenticationService';
import { AppModule } from "./app.module";

@Component({
    selector: 'app-root',
    templateUrl: './app.component.html',
    styleUrls: ['./app.component.css']
})
export class AppComponent {

    _userService: AuthenticationService;

    loginInfo: UsuarioLogado = {
        Nome: "Sistema",
    };

    constructor() {

        this._userService = AppModule.injector.get(AuthenticationService);

        this.loginInfo.Nome = this._userService.Nome;

    }






}
