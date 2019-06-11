using System;
using System.Collections.Generic;
using System.Text;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using QuickBuy.Dominio.Entidades;
using QuickBuy.Dominio.ObjetodeValor;

namespace QuickBuy.Repositorio.Contexto
{
    public class QuickBuyContexto : DbContext

    {
       

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemPedido> ItemPedidos { get; set; }
        public DbSet<FormaPagamento> FormaPagemento { get; set; }


        public QuickBuyContexto(DbContextOptions options) : base(options)
        {


        }


    }
}
