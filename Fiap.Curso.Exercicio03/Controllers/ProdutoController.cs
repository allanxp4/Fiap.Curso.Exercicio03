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
        Entidades _context = new Entidades();
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
            _context.Produto.Add(p);
            _context.SaveChanges();
            return View();
        }

        [HttpGet]
        public ActionResult Listar()
        {
            List<Produto> _lista = _context.Produto.ToList();
            return View();
        }
    }
}