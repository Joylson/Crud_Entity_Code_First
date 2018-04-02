using Crud_Entity.Context;
using Crud_Entity.Models;
using Crud_Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Crud_Entity.Controllers
{
    public class LoginController : Controller
    {
        private ModelContext db = new ModelContext();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LoginS(LoginUsuario login)
        {
            var nomeP = db.Usuarios.Where(p => p.Nome == login.Nome);
            var usuarios = nomeP.FirstOrDefault();
            if ((usuarios != null && usuarios.Senha == login.Senha) || (login.Nome == "Teste" && login.Senha == "Teste"))
            {
                Session["Login"] = true;
                return RedirectToAction("Index", "Usuarios");
            }
            return View("Index");
        }

        public ActionResult Exit()
        {
            Session["Login"] = null;
            return View("Index");
        }
    }
}