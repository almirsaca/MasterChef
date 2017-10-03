import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {RouterModule} from "@angular/router";
import {FormsModule} from "@angular/forms";
import {AutorComponent} from "./autor.component";
import {AutorRoutes} from "./autor.routes";
import {Autor} from "../models/autor";

@NgModule({
  imports: [
      CommonModule,
      FormsModule,
      RouterModule.forChild(AutorRoutes)
  ],
  declarations: [
      AutorComponent
  ],
})
export class OthersModule { }
