using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuickBuy.Dominio.Contratos;
using QuickBuy.Repositorio.Contexto;

namespace QuickBuy.Repositorio.Repositorios
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {
        protected  readonly QuickBuyContexto QuickBuyContexto;
        public BaseRepositorio(QuickBuyContexto quickBuyContexto)
        {
            QuickBuyContexto = quickBuyContexto;
        }

        public void adicionar(TEntity entity)
        {
            QuickBuyContexto.Set<TEntity>().Add(entity);
            QuickBuyContexto.SaveChanges();
        }

        public void Atualizar(TEntity entity)
        {
            QuickBuyContexto.Set<TEntity>().Update(entity);
            QuickBuyContexto.SaveChanges();
        }

        public IEnumerable<TEntity> ObterTodos()
        {
           return  QuickBuyContexto.Set<TEntity>().ToList();
        }

        public TEntity ObterPorId(int id)
        {
            return QuickBuyContexto.Set<TEntity>().Find(id);
                
        }

        
        public void Remover(TEntity entity)
        {
            QuickBuyContexto.Remove(entity);
            QuickBuyContexto.SaveChanges();
        }

        public void Dispose()
        {
            QuickBuyContexto.Dispose();
        }

        
    }
}
