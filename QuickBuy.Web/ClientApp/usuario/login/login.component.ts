import { Component } from "@angular/Core";
import { Usuario } from "../../src/app/modelo/usuario";
import { Router } from "@angular/router";

@Component({
  selector: "api-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.css"]

})

export class LoginComponent {

  public usuario;
  
  
  constructor(private router:Router) {
    this.usuario = new Usuario();
  }

 

  entrar() {
    if (this.usuario.email == "luis_csouza@uol.com.br" && this.usuario.senha == "123") {
      localStorage.setItem("usuario-autenticado", "1");
     //this.router.navigate(['/'])
    
    }
  }

 

  
}
