import {
  Component,
  OnInit
} from '@angular/core';
import {
  Http,
  Response,
  RequestOptions,
  Headers,
  URLSearchParams
} from '@angular/http';
import {
  Login
} from "../../models/login";


@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
})
export class loginComponent implements OnInit {
  constructor(private http: Http) {}

  model: any = {};

  ngOnInit() {}

  autenticar() {

    console.log(this.model);

    let data = new URLSearchParams();
    data.append('email', this.model.Email);
    data.append('password', this.model.Senha);

    this.http
      .post('http://localhost:58877/token', data)
      .subscribe(data => {      

        var item = data.json();

        localStorage.setItem('usuarioLogado',  JSON.stringify(item));
      }, error => {
        console.log(error.json());
      });
  }
}
