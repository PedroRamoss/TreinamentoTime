using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Treinamento.Business.Interfaces;
using Treinamento.Business.Models;
using Treinamento.Infra.Context;

namespace Treinamento.Infra.Repository
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(MeuDbContext context) : base(context) { }

    }
}
