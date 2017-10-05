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

        var usuarioLogado = JSON.parse(localStorage.getItem("UsuarioLogado") || "{}");
        
        let headers = new Headers({ 'Authorization': 'Bearer ' + usuarioLogado.Token });
        let options = new RequestOptions({ headers: headers });

        this.http.get('http://localhost:58877/api/Usuario',options).subscribe(data => {
            this.usuarios = data['results'];
        });

    }
}
