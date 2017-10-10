import { Injectable, Component, OnInit } from '@angular/core';
import { Usuario } from "../../models/usuario";
import { UsuarioService } from '../../services/usuarioService';


@Component({
    selector: 'app-usuario',
    templateUrl: './usuario.component.html',
})
export class UsuarioComponent implements OnInit {

    usuarios: any[];
    filtro: any = {};

    constructor(private UsuarioService: UsuarioService) { }

    ngOnInit() {
        this.listar();
    }

    listar() {
        this.UsuarioService.getFiltro('Usuario', this.filtro || {}, 1, 20).subscribe(result => {
            this.usuarios = result;
        });
    }
}
