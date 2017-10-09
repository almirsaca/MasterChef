import { Injectable,Component, OnInit } from '@angular/core';
import { Usuario } from "../../models/usuario";
import { UsuarioService } from '../../services/usuarioService';


@Component({
    selector: 'app-usuario',
    templateUrl: './usuario.component.html',
})
export class UsuarioComponent implements OnInit {

    usuarios: any[];

    constructor(private UsuarioService: UsuarioService) { }

    ngOnInit() {

        this.UsuarioService.get('Usuario').subscribe(result => {
            this.usuarios = result;
        });
    }
}
