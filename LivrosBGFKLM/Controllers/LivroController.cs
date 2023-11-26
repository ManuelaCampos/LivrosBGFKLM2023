using LivrosBGFKLM.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace LivrosBGFKLM.Controllers
{
    public class LivroController : Controller
    {
        private static List<LivroFiccao> livrosFiccao = new List<LivroFiccao>();


        public ActionResult NovoLivro()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NovoLivro(LivroFiccao livro)
        {
            livro.Id = livrosFiccao.Count + 1;
            livrosFiccao.Add(livro);
            return RedirectToAction("Detalhes", new { id = livro.Id });
        }

        public ActionResult Detalhes(long id)
        {
            LivroFiccao livro = livrosFiccao.Find(l => l.Id == id);
            if (livro != null)
            {
                return View(livro);
            }
            return HttpNotFound();
        }

        private ActionResult HttpNotFound()
        {
            throw new NotImplementedException();
        }

        public ActionResult Index()
        {
            return View(livrosFiccao);
        }
    }
}
