import { HomeComponent } from "./pages/home/home.component";
import { LoginComponent } from "./pages/login/login.component";
import { AutorComponent } from "./pages/autor/autor.component";
import { UsuarioComponent } from "./pages/usuario/usuario.component";
import { CategoriaComponent } from "./pages/categoria/categoria.component";

export const appRoutes = [
    {
        path: '',
        redirectTo: 'home',
        pathMatch: 'full'
    },
    {
        path: 'home',
        component: HomeComponent
    },
    {
        path: 'others',
        loadChildren: './pages/others/others.module#OthersModule',
    },
    {
        path: 'login',
        component: LoginComponent
    },
    {
        path: 'autor',
        component: AutorComponent
    },
    {
        path: 'usuario',
        component: UsuarioComponent
    },
    {
        path: 'categoria',
        component: CategoriaComponent
    }
];
