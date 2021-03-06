import { Component, OnInit } from '@angular/core';
import { Http, Response, RequestOptions, Headers } from '@angular/http';
import { Autor } from "../../models/autor";
import { AutorService } from '../../services/autorService';



@Component({
    selector: 'app-autor',
    templateUrl: './autor.component.html',
})
export class AutorComponent implements OnInit {

    autores: any[];
    filtro: any = {};

    constructor(private AutorService: AutorService) { }

    ngOnInit() {
        this.listar();
    }

    listar() {
        this.AutorService.getFiltro('Autor', this.filtro || {}, 1, 20).subscribe(result => {
            this.autores = result;
        });
    }

}
