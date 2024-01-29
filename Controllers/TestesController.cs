using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PrimeiroApp.Controllers
{
    [Route("/", Order = 0)] //rota padrão pela Order = 0
    [Route("minha-conta", Order = 1)] //rota alternativas
    [Route("gestao-da-conta", Order = 2)]  //rota alternativas 
    public class TestesController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet("detalhes/{id:int}/{id2?}")] 
        public ActionResult Details(int id, int id2 = 0)
        {
            return View();
        }

        [HttpGet("novo")]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost("novo")]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm] IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [HttpGet("editar/{id:int}")]
        public ActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost("editar/{id:int}")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [HttpGet("excluir/{id:int}")]
        public ActionResult Delete(int id)
        {
            return View();
        }

        [HttpPost("excluir/{id:int}")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
