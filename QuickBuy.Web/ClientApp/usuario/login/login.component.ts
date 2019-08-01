import { Component } from "@angular/Core";
import { Usuario } from "../../src/app/modelo/usuario";

@Component({
  selector: "api-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.css"]

})

export class LoginComponent {

  public usuario ;
  public usuarioAutenticado: boolean;

  constructor() {
    this.usuario = new Usuario();
  }

 

  entrar() {
    if (this.usuario.email == "luis_csouza@uol.com.br" && this.usuario.senha == "123") {
      this.usuarioAutenticado = true;
    }
  }

 

  
}
