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

        this.http.get('http://localhost:58877/api/Autor').subscribe(data => {
            this.autores = data['results'];
        });

    }

}
