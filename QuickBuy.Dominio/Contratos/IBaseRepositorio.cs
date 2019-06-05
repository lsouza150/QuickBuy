using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Contratos
{
    public interface IBaseRepositorio<TEntity> :IDisposable where TEntity :class 
    {
        void adicionar(TEntity entity);
        TEntity ObterTodos(int id);

        void Atualizar(TEntity entity);

        void Remover(TEntity entity);


    }
}
