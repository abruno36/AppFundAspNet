using Microsoft.AspNetCore.Mvc;
using PrimeiroApp.Models;

namespace PrimeiroApp.ViewComponents
{
    public class SaudacaoAlunoViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            //pegar o aluno na base de dados
            //ou o dado do aluno que está logado
            var aluno = new Aluno() { Nome = "Bruno" };

            return View(aluno);
        }
    }
}
