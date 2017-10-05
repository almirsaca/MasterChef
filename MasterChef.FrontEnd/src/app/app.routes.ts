import {HomeComponent} from "./pages/home/home.component";
import {loginComponent} from "./pages/login/login.component";
import { AutorComponent } from "./pages/autor/autor.component";
import { UsuarioComponent } from "./pages/usuario/usuario.component";

export const appRoutes=[
    {
        path:'',
        redirectTo:'home',
        pathMatch:'full'
    },
    {
        path: 'home',
        component: HomeComponent
    },
    {
        path: 'others',
        loadChildren:'./pages/others/others.module#OthersModule',
    },
    {
        path: 'login',
        component: loginComponent
    },
    {
        path: 'autor',
        component: AutorComponent
    },
    {
        path: 'usuario',
        component: UsuarioComponent
    }
];
