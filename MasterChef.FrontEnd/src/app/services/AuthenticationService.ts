import { Injectable } from '@angular/core';
import { Http, Response, RequestOptions, Headers, URLSearchParams } from '@angular/http';
import { Observable } from 'rxjs';


@Injectable()
export class AuthenticationService {

    public Token: any;
    public Nome: any;
    private UrlApi: any;

    constructor(private http: Http) {

        var currentUser = JSON.parse(localStorage.getItem('currentUser'));
        this.Token = currentUser && currentUser.Token;
        this.Nome = currentUser && currentUser.Nome;
        this.UrlApi = "http://localhost:58877/token";
    }

    login(email: string, senha: string): Observable<boolean> {
        var headers = new Headers();
        headers.append('Content-Type', 'application/x-www-form-urlencoded');

        let body = new URLSearchParams();
        body.append('email', email);
        body.append('password', senha);

        return this.http.post(this.UrlApi, body, {
            headers: headers
        }).map((response: Response) => {
          
            let json = response.json();

            if (json.Token) {
                this.Token = json.Token;

                localStorage.setItem('currentUser', JSON.stringify(json));
            }
            return true;
        });
    }
}
