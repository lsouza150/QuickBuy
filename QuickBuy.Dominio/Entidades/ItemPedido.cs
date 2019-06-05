using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class ItemPedido :Entidade
    {
        public int Id { get; set; }
        public int produtodId { get; set; }
        public decimal Quantidade { get; set; }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
