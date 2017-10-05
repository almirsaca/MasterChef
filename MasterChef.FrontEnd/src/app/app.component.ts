import {
  Component
} from '@angular/core';
import {
    UsuarioLogado
} from "./models/usuarioLogado";

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  loginInfo: UsuarioLogado = {
    Nome: "Wagner",
    Email: "wagnerdavanco@gmail.com",
    Avatar: "ay.jpeg"
  };
}
