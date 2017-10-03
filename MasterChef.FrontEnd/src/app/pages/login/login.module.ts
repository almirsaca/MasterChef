import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {RouterModule} from "@angular/router";
import {FormsModule} from "@angular/forms";
import {loginComponent} from "./login.component";
import {loginRoutes} from "./login.routes";

@NgModule({
  imports: [
      CommonModule,
      FormsModule,
      RouterModule.forChild(loginRoutes)
  ],
  declarations: [
     loginComponent
  ],
})
export class loginModule { }
