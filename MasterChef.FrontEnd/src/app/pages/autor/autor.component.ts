import { Component, OnInit } from '@angular/core';
import { Http, Response, RequestOptions, Headers } from '@angular/http';
import { Autor } from "../../models/autor";
import { AutorService } from '../../services/autorService';



@Component({
    selector: 'app-autor',
    templateUrl: './autor.component.html',
})
export class AutorComponent implements OnInit {

    autores: Autor[];

    constructor(private AutorService: AutorService) { }

    ngOnInit() {

        this.AutorService.get('Autor').subscribe(result => {
            this.autores = result.data;
        });


    }

}
