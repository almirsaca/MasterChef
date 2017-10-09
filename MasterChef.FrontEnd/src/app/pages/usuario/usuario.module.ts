import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from "@angular/router";
import { FormsModule } from "@angular/forms";
import { UsuarioComponent } from "./usuario.component";
import { UsuarioRoutes } from "./usuario.routes";


@NgModule({
    imports: [
        CommonModule,
        FormsModule,
        RouterModule.forChild(UsuarioRoutes)
    ],
    declarations: [
        UsuarioComponent
    ],
})
export class UsuarioModule { }
