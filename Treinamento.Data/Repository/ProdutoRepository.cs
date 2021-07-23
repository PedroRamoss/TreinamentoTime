using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Treinamento.Data.Context;
using Treinamento.Negocio.Interfaces;
using Treinamento.Negocio.Models;

namespace Treinamento.Data.Repository
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(MeuDbContext context) : base(context) { }

        public async Task<IEnumerable<Produto>> ObterProdutos()
        {
            return await Db.Produtos.AsNoTracking().ToListAsync();
        }
    }
}
