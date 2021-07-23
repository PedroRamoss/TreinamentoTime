using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Treinamento.Negocio.Interfaces;
using Treinamento.Negocio.Models;

namespace Treinamento.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly IProdutoService _produtoService;
        public ProdutosController(IProdutoRepository produtoRepository, IProdutoService produtoService)
        {
            _produtoRepository = produtoRepository;
            _produtoService = produtoService;
        }

        [HttpGet]
        public async Task<IEnumerable<Produto>> ObterTodos()
        {
            return await _produtoRepository.ObterProdutos();
        }

        [HttpPost]
        public async Task<ActionResult<Produto>> Adicionar(Produto produto)
        {
            await _produtoRepository.Adicionar(produto);
            return Ok(produto);
        }
    }
}
