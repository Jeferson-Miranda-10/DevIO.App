using DevIO.Business.Interfaces;
using DevIO.Business.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace DevIO.Data.Repository
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(MeuDbContext context) : base(context)
        {

        }
        public async Task<Produto> ObterProdutosFornecedoresAsync(Guid id)
        {
            return await Db.Produtos.AsNoTracking()
                .Include(f => f.Fornecedor)
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IEnumerable<Produto>> ObterProdutosFornecedoresAsync()
        {
            return await Db.Produtos.AsNoTracking()
                .Include(f => f.Fornecedor)
                .OrderBy(p => p.Nome).ToListAsync();
        }
             
        public async Task<IEnumerable<Produto>> ObterProdutosPorFornecedoresAsync(Guid fornecedorId)
        {
            return await Buscar(p=> p.FornecedorId == fornecedorId);
        }
    }
}

//public async Task<IEnumerable<Produto>> ObterProdutosFornecedores(Guid Id)
//{
//    return await Db.Produtos.AsNoTracking().Include(f => f.Fornecedor)
//        .FirstOrDefaultAsync(p => p.Id == id);
//}

//public Task<Produto> ObterProdutosFornecedores()
//{
//    throw new NotImplementedException();
//}

//public Task<IEnumerable<Produto>> ObterProdutosPorFornecedores(Guid fornecedorId)
//{
//    throw new NotImplementedException();
//}
