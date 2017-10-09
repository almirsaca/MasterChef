import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AuthenticationService } from '../../services/authenticationService';


@Component({
    selector: 'app-login',
    templateUrl: './login.component.html',
})
export class LoginComponent implements OnInit {
    constructor(
        private router: Router,
        private authenticationService: AuthenticationService) { }

    model: any = {};
    loading = false;
    error = '';

    ngOnInit() { }

    autenticar() {
        this.loading = true;
        this.authenticationService.login(this.model.Email, this.model.Senha).subscribe(() => {
            this.router.navigate(['/']);
        },
            err => {
                console.log(err);
                this.error = 'Usuário e/ou senha incorretos';
                this.loading = false;
            });
    }
}
