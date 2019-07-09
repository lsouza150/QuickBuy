import { Component, TemplateRef } from "@angular/Core";

@Component({
  selector: "api-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.css"]

})

export class LoginComponent {
  entrar() {
    alert('Entrar no sistema');
  }

  on_keypress() {
    alert('Foi digitado no campo de emial')

  }
}
