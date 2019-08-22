"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var GuardaRotas = /** @class */ (function () {
    function GuardaRotas() {
    }
    GuardaRotas.prototype.canActivate = function (route, state) {
        //  Se usuario autenticado
        return true;
    };
    return GuardaRotas;
}());
exports.GuardaRotas = GuardaRotas;
//# sourceMappingURL=guarda.rotas.js.map

//<div class="alert alert-danger" * ngIf="email.invalid && (email.dirty || email.touched)" >
//  <div * ngIf="email.errors.requirid" >
 //   Email deve ser preenchido!!
//      </div >

//    </div >
