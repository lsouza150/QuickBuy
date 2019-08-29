import { Component, OnInit } from "@angular/Core";
import { Usuario } from "../../src/app/modelo/usuario";
import { Router, ActivatedRoute } from "@angular/router";
import { UsuarioServico } from "../../src/app/servicos/usuario/usuario.servico";

@Component({
  selector: "api-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.css"]

})

export class LoginComponent  implements OnInit {
   
  public usuario;
  public returnUrl: String;
   
  constructor(private router: Router, private activatedRouter: ActivatedRoute,
              private usuarioServico: UsuarioServico) {
       
  }

  ngOnInit(): void {
    this.returnUrl = this.activatedRouter.snapshot.queryParams['returnUrl'];
    this.usuario = new Usuario();
  }
  entrar() {
     
    this.usuarioServico.verificaUsuario(this.usuario)
      .subscribe(
   
        data => {

        },
        err => {

        }
    //PRogramação Reativa
    );
    

    //if (this.usuario.email == "luis_csouza@uol.com.br" && this.usuario.senha == "123") {
    //  sessionStorage.setItem("usuario-autenticado", "1");
    //  this.router.navigate([this.returnUrl]);
     // }
  }
 
}
