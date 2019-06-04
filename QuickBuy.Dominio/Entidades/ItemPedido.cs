using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class ItemPedido
    {
        public int Id { get; set; }
        public int produtodId { get; set; }
        public decimal Quantidade { get; set; }
    }
}
