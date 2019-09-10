using Microsoft.AspNetCore.Mvc;
using QuickBuy.Dominio.Entidades;
using System;

namespace QuickBuy.Web.Controllers
{
    public class UsuarioController :Controller
    {
        [Route("api/[Controller]")]

        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }

        }


        [HttpPost("VerificarUsuario")]
        public ActionResult VerificarUsuario([FromBody] Usuario usuario)
        {
            try
            {
                if (usuario.Email == "luis_csouza@uol.com.br" && usuario.Senha == "123")
                    return Ok(usuario);
                
                return BadRequest("Usuário ou senha inválido");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }

        }

        [HttpPost]
        public ActionResult Post()
        {
          try
            {
                return Ok();
            }catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
            
        }

        
    }

    
    
}
