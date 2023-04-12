using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Alura.LeilaoOnline.WebApp.Services;

namespace Alura.LeilaoOnline.WebApp.Controllers
{
    public class HomeController : Controller
    {
        IProdutoService _service;

        public HomeController(IProdutoService service)
        {
            _service = service;
        }

        public IActionResult Index() => View(_service.ConsultaCategoriasComTotalDeLeiloesEmPregao());

        [Route("[controller]/StatusCode/{statusCode}")]
        public IActionResult StatusCodeError(int statusCode)
        {
            if (statusCode == 404) return View("404");
            return View(statusCode);
        }

        [Route("[controller]/Categoria/{categoria}")]
        public IActionResult Categoria(int categoria) => View(_service.ConsultaCategoriaPorIdComLeiloesEmPregao(categoria));

        [HttpPost]
        [Route("[controller]/Busca")]
        public IActionResult Busca(string termo)
        {
            ViewData["termo"] = termo;
            return View(_service.PesquisaLeiloesEmPregaoPorTermo(termo));
        }
    }
}
