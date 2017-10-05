import { Component, OnInit  } from '@angular/core';
import {Http, Response, RequestOptions, Headers} from '@angular/http';
import { Autor} from "../../models/autor";



@Component({
    selector: 'app-autor',
    templateUrl: './autor.component.html',
})
export class AutorComponent implements OnInit {
   
    autores: Autor[];
   
    constructor(private http: Http) { }

    ngOnInit() {
        var usuarioLogado = JSON.parse(localStorage.getItem("UsuarioLogado") || "{}");
 
        let headers = new Headers({ 'Authorization': 'Bearer ' + usuarioLogado.Token });
        let options = new RequestOptions({ headers: headers });

        this.http.get('http://localhost:58877/api/Autor',options).subscribe(data => {
            this.autores = data['results'];
        });

    }

}
