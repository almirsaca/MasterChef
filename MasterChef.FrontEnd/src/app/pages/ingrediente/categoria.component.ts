import { Injectable,Component, OnInit } from '@angular/core';
import { Categoria } from "../../models/categoria";
import { CategoriaService } from '../../services/categoriaService';


@Component({
    selector: 'app-categoria',
    templateUrl: './categoria.component.html',
})
export class CategoriaComponent implements OnInit {

    categorias: any[];

    constructor(private CategoriaService: CategoriaService) { }

    ngOnInit() {

        this.CategoriaService.get('Categoria').subscribe(result => {
            this.categorias = result;
        });
    }
}
