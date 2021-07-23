using System;
using System.Threading.Tasks;
using Treinamento.Negocio.Models;

namespace Treinamento.Negocio.Interfaces
{
    public interface IProdutoService : IDisposable
    {
        Task Adicionar(Produto produto);
        Task Atualizar(Produto produto);
        Task Remover(Guid Id);
    }
}
