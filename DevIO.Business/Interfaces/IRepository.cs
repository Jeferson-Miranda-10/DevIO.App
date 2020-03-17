using DevIO.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DevIO.Business.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : Entity
    {
        //Quando se tem somente uma Task é um metodo Void não retorna nada
        Task Adicionar(TEntity entity);
        //QUando retorna algo , esta retornado a propria entidade ou uma lista dessa entidade.
        Task<TEntity> ObterPorId(Guid id);
        Task<List<TEntity>> ObterTodos();
        Task Atualizar(TEntity obj);
        Task Remover(Guid id);
        //Buscar vai ter um metodo buscar onde vai passar um expressar lamina , que vai ter uma func sua entidade com alguma coisa, que precisa retornar um bool, 
        Task<IEnumerable<TEntity>> Buscar(Expression<Func<TEntity, bool>> predicate);

        Task<int> SaveChanges();

    }
}
