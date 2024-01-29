using Microsoft.AspNetCore.Mvc;
using PrimeiroApp.Models;

namespace PrimeiroApp.Controllers
{
    public class ModelController : Controller
    {
        public IActionResult Index()
        {
            //var aluno = new Aluno();

            var aluno = new Aluno()
            {
                Nome = "A",
                Email = "Bbruno@gmail.com",
                EmailConfirmacao = "bruno.com",
                Avaliacao = 4
            };

            if(TryValidateModel(aluno))
            {
                return View(aluno);
            }

            var ms = ModelState;

            var erros = ModelState.Select(x => x.Value.Errors)
                        .Where(y => y.Count > 0)
                        .ToList();

            erros.ForEach(r => Console.WriteLine(r.First().ErrorMessage));

            
            
            
            
            
            return View();
        }
    }
}
