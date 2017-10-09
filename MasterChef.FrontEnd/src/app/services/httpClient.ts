import { Injectable } from "@angular/core";
import { Http, Headers, Response, Request, BaseRequestOptions, RequestMethod, ResponseContentType } from "@angular/http";
import { Observable } from "rxjs";
import { Router } from '@angular/router';
import 'rxjs/add/operator/map'

@Injectable()
export class HttpClient {

    constructor(private http: Http, private _router: Router) { }

    get(url: string) {
       return this.request(url, RequestMethod.Get);
    }

    getFile(url: string) {
       return this.request(url, RequestMethod.Get, null, ResponseContentType.Blob);
    }

    post(url: string, body: any) {
        return this.request(url, RequestMethod.Post, body);
    }

    put(url: string, body: any) {
        return this.request(url, RequestMethod.Put, body);
    }

    delete(url: string, body: any) {
        return this.request(url, RequestMethod.Delete, body);
    }

    private request(url: string, method: RequestMethod, body?: any, responseType: ResponseContentType = ResponseContentType.Json): Observable<Response> {

        let headers = new Headers();
        var currentUser = JSON.parse(localStorage.getItem('currentUser'));
        let token = currentUser && currentUser.Token;

        this.createAuthorizationHeader(headers, token);

        let options = new BaseRequestOptions();
        options.headers = headers;
        options.url = url;
        options.method = method;

        if (body != null)
            options.body = body;

        options.responseType = responseType;
        options.withCredentials = true;

        let request = new Request(options);

        return this.http.request(request);
    }

    private createAuthorizationHeader(headers: Headers, token) {
        headers.append('Content-Type', 'application/json');
        headers.append('Authorization', 'Bearer ' + token);
    }
}
