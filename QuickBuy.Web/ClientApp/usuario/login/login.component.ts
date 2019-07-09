import { Component, TemplateRef } from "@angular/Core";

@Component({
  selector: "api-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.css"]

})

export class LoginComponent {


  public email = "";
  public senha = "";

  entrar() {
    alert(this.email +" -"+this.senha);
  }

 

  
}
