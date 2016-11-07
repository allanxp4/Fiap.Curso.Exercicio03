using Fiap.Curso.Exercicio03.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Curso.Exercicio03.Controllers
{
    public class ProdutoController : Controller
    {
        // GET: Produto
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Produto p)
        {
            Entidades context = new Entidades();
            context.Produto.Add(p);
            context.SaveChanges();
            TempData["success"] = true;
            return View();
        }

        [HttpGet]
        public ActionResult Listar()
        {
            Entidades context = new Entidades();
            List<Produto> _lista = context.Produto.ToList();
            return View(_lista);
        }
    }
}