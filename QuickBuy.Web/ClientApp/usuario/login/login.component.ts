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
          console.log(data);

        },
        err => {
          console.log(err.error)

        }
    //PRogramação Reativa
    );
    

    
  }
 
}
