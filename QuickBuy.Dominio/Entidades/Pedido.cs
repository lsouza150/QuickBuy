
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuickBuy.Dominio.ObjetodeValor;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido :Entidade
    {
        public int ID { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }

        public DateTime    DataPrevisaoEntrega { get; set; }
        public string Cep { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public int NumeroEndereco { get; set; }

        public int FormapagementoID { get; set; }
        public FormaPagamento FormaPagamento { get; set; }
        public ICollection<ItemPedido> ItensPedido { get; set; }

        public override void Validate()
        {

            LimparMensagemValidacao();

            if (!ItensPedido.Any())
            {
                AdicionarCritica("Critica.  Pedido não pode ficar sem item de pedido");
                
            }

            if (string.IsNullOrEmpty(Cep))
                AdicionarCritica("Critica. Cep deve estar preenchido");
        }
    }
}
