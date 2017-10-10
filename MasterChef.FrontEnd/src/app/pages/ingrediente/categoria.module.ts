import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from "@angular/router";
import { FormsModule } from "@angular/forms";
import { CategoriaComponent } from "./categoria.component";
import { CategoriaRoutes } from "./categoria.routes";


@NgModule({
    imports: [
        CommonModule,
        FormsModule,
        RouterModule.forChild(CategoriaRoutes)
    ],
    declarations: [
        CategoriaComponent
    ],
})
export class CategoriaModule { }
