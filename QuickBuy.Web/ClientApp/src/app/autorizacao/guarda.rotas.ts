import { Injectable } from "@angular/core";
import { Router, CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot } from "@angular/router";

@Injectable({
  providedIn:'root'
})

export class GuardaRotas implements CanActivate {
  
  constructor(private router:Router) {

  }

  canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): boolean  {
   // var autenticado = localStorage.getItem("usuario-autenticado");
   // if (autenticado == '1') {
   //   return true;
  //  }

    this.router.navigate(['/entrar']);

     //  Se usuario autenticado
      return false;


    }
}