using System;
using System.Threading.Tasks;
using Treinamento.Negocio.Interfaces;
using Treinamento.Negocio.Models;

namespace Treinamento.Negocio.Services
{
    public class ProdutoService :  IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;
        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public async Task Adicionar(Produto produto)
        {
            await _produtoRepository.Adicionar(produto);
        }

        public async Task Atualizar(Produto produto)
        {
            await _produtoRepository.Atualizar(produto);
        }
        public async Task Remover(Guid Id)
        {
            await _produtoRepository.Remover(Id);
        }
        public void Dispose()
        {
            _produtoRepository?.Dispose();
        }
    }
}
