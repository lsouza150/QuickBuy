using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
     public abstract class Entidade
    {
        private List<string>  _mensagensValidacao { get; set; }

        private List <string> mensagemsValidacao
        {
            get { return _mensagensValidacao ?? (_mensagensValidacao = new List<string>()); }
        }

        protected void LimparMensagemValidacao()
        {

            mensagemsValidacao.Clear();
        }

        protected  void AdicionarCritica(string mensagem)
        {
            mensagemsValidacao.Add(mensagem);

        }

        public abstract void Validate();
        protected bool EhValidado
        {
            get { return mensagemsValidacao.Any(); }
        }

    }
}
