import { BrowserModule } from '@angular/platform-browser';
import { NgModule, Injector } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';

import { AppComponent } from './app.component';
import { Topnavbar } from "./components/topnavbar/topnavbar.component";
import { Navigation } from "./components/navigation/navigation.component";
import { RouterModule } from "@angular/router";
import { appRoutes } from "./app.routes";
import { HomeComponent } from "./pages/home/home.component";
import { LoginComponent } from "./pages/login/login.component";
import { AutorComponent } from "./pages/autor/autor.component";
import { UsuarioComponent } from "./pages/usuario/usuario.component";
import { CategoriaComponent } from "./pages/categoria/categoria.component";

/* Services */
import { HttpClient, } from './services/httpClient';
import { AuthenticationService, } from './services/authenticationService';
import { BaseService } from './services/baseService';
import { UsuarioService } from './services/usuarioService';
import { AutorService } from './services/autorService';
import { CategoriaService } from './services/categoriaService';

@NgModule({
    declarations: [
        AppComponent,
        Navigation,
        Topnavbar,
        HomeComponent,
        LoginComponent,
        AutorComponent,
        UsuarioComponent,
        CategoriaComponent
    ],
    imports: [
        HttpModule,
        BrowserModule,
        FormsModule,
        RouterModule.forRoot(appRoutes)
    ],
    providers: [
        HttpClient,
        AuthenticationService,
        BaseService,
        UsuarioService,
        AutorService,
        CategoriaService
    ],
    bootstrap: [AppComponent]
})
export class AppModule {
    static injector: Injector;

    constructor(injector: Injector) {
        AppModule.injector = injector;
    }
}
