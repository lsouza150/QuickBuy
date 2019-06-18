﻿using Microsoft.EntityFrameworkCore;
using QuickBuy.Dominio.Entidades;
using QuickBuy.Dominio.ObjetodeValor;
using QuickBuy.Repositorio.Config;

namespace QuickBuy.Repositorio.Contexto
{
    public class QuickBuyContexto : DbContext

    {     
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemPedido> ItemPedidos { get; set; }
        public DbSet<FormaPagamento> 
            FormaPagamento { get; set; }

        public QuickBuyContexto(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Classe de mapeadmento aqui...
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoConfigutarion());
            modelBuilder.ApplyConfiguration(new ItemPedidoConfiguration());
            modelBuilder.ApplyConfiguration(new FormaPagamentoConfiguration());

            modelBuilder.Entity<FormaPagamento>().HasData(
                      new FormaPagamento()
                      {
                          Id = 1,
                          Nome = "Boleto",
                          Descricao = "Forma de Pagamento Boleto"
                      },

                      new FormaPagamento()
                      {
                          Id = 2,
                          Nome = "Cartão de Crédito",
                          Descricao = "Forma de Pagamento Cartão de Crédito"
                      },
                      new FormaPagamento()
                      {
                          Id = 3,
                          Nome = "Depósito",
                          Descricao = "Forma de Pagamento Depósito"
                      });

            base.OnModelCreating(modelBuilder);
        }

    }
}
