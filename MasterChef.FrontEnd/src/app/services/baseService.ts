import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { Headers, RequestOptions, Response, ResponseContentType } from '@angular/http';
import { Observable } from 'rxjs';
import 'rxjs/add/operator/map'
import { HttpClient } from '../services/httpClient';
import { APPCONFIG } from '../config';
import { AppModule } from "../app.module";

@Injectable()
export class BaseService {

    _router: Router;
    _http: HttpClient;

    constructor() {
        this._http = AppModule.injector.get(HttpClient);
        this._router = AppModule.injector.get(Router);
    }

   get(path: string, params: string = ''): any {
        return this._http.get(APPCONFIG.ApiUrl + path + params)
            .map((response: Response) => response.json())
            .catch(err => {
                return this.handleError(err);
            });
    }

    downloadFile(path: string): Observable<Blob> {
        return this._http.getFile(APPCONFIG.ApiUrl + path)
            .map(res => res.blob())
            .catch(this.handleError)
    }

    getFiltro(path: string, model: any, pagina: number, tamanho: number): any {
        return this._http.get(APPCONFIG.ApiUrl + path + '/?' + this.modelToQueryString(model) + 'pageIndex=' + pagina + '&pageSize=' + tamanho)
            .map((response: Response) => response.json())
            .catch(err => {
                return this.handleError(err);
            });
    }

    post(path: string, model: any) {
        return this._http.post(APPCONFIG.ApiUrl + path, JSON.stringify(model))
            .map((response: Response) => response.json())
            .catch(err => {
                return this.handleError(err);
            });
    }

    put(path: string, model: any) {
        return this._http.put(APPCONFIG.ApiUrl + path, JSON.stringify(model))
            .map((response: Response) => response.json())
            .catch(err => {
                return this.handleError(err);
            });
    }

    putId(path: string, id: number, model: any) {
        return this.put(path + id, model);
    }

    inativar(path, id) {
        return this._http.put(APPCONFIG.ApiUrl + path + '/inativar/' + id, "")
            .map((response: Response) => response)
            .catch(err => {
                return this.handleError(err);
            });
    }

    ativar(path, id) {
        return this._http.put(APPCONFIG.ApiUrl + path + '/ativar/' + id, "")
            .map((response: Response) => response)
            .catch(err => {
                return this.handleError(err);
            });
    }

    private handleError(error: any) {
        if (error.status == 401) {
            // this._authenticationService.token = null;
            localStorage.removeItem('currentUser');
            this._router.navigate(['/login']);
        }
        else if (error.status == 400) {
            console.log(error);
        }
        else if (error.status == 0) {
            console.log(error);
            //this._notificacaoService.Erro("Ocorreu um erro", e.message);
        }
        else {
            let erro = error.json();
            if (erro.hasErrors) {
                erro.errors.forEach(e => {
                    //this._notificacaoService.Erro("Ocorreu um erro", e.message);
                    console.log(error);
                });
            }
        }

        //this._loading.fechar();

        return Observable.throw(error);
    }

    modelToQueryString(model) {
        let queryString: string = "";
        Object.keys(model).map((key) => {
            if (model[key] != undefined) {
                let prop = model[key];
                //if (prop instanceof Date)
                //    prop = moment(prop).format('MM/DD/YYYY')
                queryString += key + "=" + prop + "&"
            }
        });
        return queryString;
    }
}
