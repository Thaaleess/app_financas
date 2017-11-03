using app_financas.Models;
using Microsoft.AspNetCore.Mvc;

namespace app_financas.Controllers
{
    public class FinancasController : Controller
    {
        private IFinancasRepositorio iRepositorio;

        public FinancasController(IFinancasRepositorio repositorio)
        {
            iRepositorio = repositorio;
        }
        public IActionResult Index(){
            var financas = iRepositorio.GetAll();
            return View(financas);
        }

        [HttpGet]
        public IActionResult Create(){
            return View();
        }

        [HttpPost]
        public IActionResult Create(Financas financa){
            iRepositorio.Create(financa);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id){
            return View(iRepositorio.GetById(id));
        }

        [HttpPost]
        public IActionResult Edit(Financas financa){
            iRepositorio.Update(financa);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id){
            iRepositorio.Delete(id);
            return RedirectToAction("Index");
        }
    }
}