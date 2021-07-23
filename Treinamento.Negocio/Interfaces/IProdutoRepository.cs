using System.Collections.Generic;
using System.Threading.Tasks;
using Treinamento.Negocio.Models;

namespace Treinamento.Negocio.Interfaces
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        Task<IEnumerable<Produto>> ObterProdutos();
    }
}
