using DevIO.Business.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DevIO.Business.Interfaces
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        Task<IEnumerable<Produto>> ObterProdutosPorFornecedoresAsync(Guid fornecedorId);
        Task<IEnumerable<Produto>> ObterProdutosFornecedoresAsync();
        Task<Produto> ObterProdutosFornecedoresAsync(Guid Id);
    }
}
