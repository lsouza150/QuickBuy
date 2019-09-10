import { Injectable, Inject } from "@angular/core";
import { HttpClient,HttpHandler, HttpHeaders } from "@angular/common/http";
import { observable, Observable } from "rxjs";
import { Usuario } from "../../modelo/usuario";

@Injectable({
  providedIn: "root"
})
export class UsuarioServico {

  private baseURL: string;
  constructor(private http: HttpClient, @Inject('BASE_URL') BaseUrl: string) {
    this.baseURL = BaseUrl;
  }

  public verificaUsuario(usuario: Usuario): Observable<Usuario> {

    const headers = new HttpHeaders().set('content-type', 'appication/json');
    var body = {
      email: usuario.email,
      senha: usuario.senha
    }

    //this.baseUrl = raiz do  site que pode ser exemplo : wwww.quickbay.com.br
    return this.http.post<Usuario>(this.baseURL + "api/usuario/verificarUsuario", body, { headers });
  }

}
