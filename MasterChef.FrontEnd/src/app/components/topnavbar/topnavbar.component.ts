import { Component } from '@angular/core';
import { smoothlyMenu } from "../../app.helpers";
import { Router } from '@angular/router';
import { AppModule } from "../../app.module";

@Component({
    selector: 'topnavbar',
    templateUrl: 'topnavbar.component.html'
})
export class Topnavbar {
    _router: Router;

    constructor() {
        this._router = AppModule.injector.get(Router);
    }

    ngOnInit() {

    }
    toggleNavigation(): void {
        jQuery("body").toggleClass("mini-navbar");
        smoothlyMenu();
    }
    logout() {
        localStorage.clear();
        this._router.navigate(['/login']);
    }
}
