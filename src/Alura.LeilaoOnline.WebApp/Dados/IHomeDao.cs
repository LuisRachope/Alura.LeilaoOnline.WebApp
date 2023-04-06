using Alura.LeilaoOnline.WebApp.Models;
using System.Collections.Generic;

namespace Alura.LeilaoOnline.WebApp.Dados
{
    public interface IHomeDao
    {
        IEnumerable<Categoria> BuscarCategorias();
        Categoria BuscarPorId(int id);
        IEnumerable<Leilao> Pesquisar(string termo);
    }
}
