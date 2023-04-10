using Alura.LeilaoOnline.WebApp.Dados;
using Alura.LeilaoOnline.WebApp.Models;
using System;
using System.Collections.Generic;

namespace Alura.LeilaoOnline.WebApp.Services.Handlers
{
    public class DefaultProdutoService : IProdutoServices
    {
        ILeilaoDao _leilaoDao;
        ICategoriaDao _categoriaDao;

        public DefaultProdutoService(ILeilaoDao leilaoDao, 
            ICategoriaDao categoriaDao)
        {
            _leilaoDao = leilaoDao;
            _categoriaDao = categoriaDao;
            
        }

        public Categoria ConsultaCategoriaPorIdComLeiloesEmPregao(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CategoriaComInfoLeilao> ConsultaCategoriasComTotalDeLeiloesEmPregao()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Leilao> PesquisaLeiloesEmPregaoPorTermo(string termo)
        {
            throw new NotImplementedException();
        }
    }
}
