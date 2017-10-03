import { Component, OnInit  } from '@angular/core';
import {Http, Response, RequestOptions, Headers} from '@angular/http';
import { Usuario} from "../../models/usuario";



@Component({
    selector: 'app-usuario',
    templateUrl: './usuario.component.html',
})
export class UsuarioComponent implements OnInit {
   
    usuarios: Usuario[];
   
    constructor(private http: Http) { }

    ngOnInit() {

        this.http.get('http://localhost:58877/api/Usuario').subscribe(data => {
            this.usuarios = data['results'];
        });

    }
}
