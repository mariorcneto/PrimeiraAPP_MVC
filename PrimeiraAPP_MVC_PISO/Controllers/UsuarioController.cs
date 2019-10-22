using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PrimeiraAPP_MVC_PISO.Models;

namespace PrimeiraAPP_MVC_PISO.Controllers
{
    public class UsuarioController : Controller
    {

        private static Usuarios _usuarios = new Usuarios();

        public ActionResult Index()
        {
            return View(_usuarios.listaUsuarios);
        }

        #region Adicionar
        public ActionResult AdicionaUsuario()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AdicionaUsuario(UsuarioModel _usuarioModel)
        {
            ViewBag.resultado = _usuarios.CriaUsuario(_usuarioModel);
            return View();
        }
        #endregion

        #region Deletar
        public ViewResult DeletaUsuario(string email)
        {
            return View(_usuarios.GetUsuario(email));
        }

        [HttpPost]
        public RedirectToRouteResult DeletaUsuario(string email, FormCollection collection)
        {
            _usuarios.DeletarUsuario(email);
            return RedirectToAction("Index");
        }
        #endregion

        #region Atualizar
        public ActionResult AtualizaUsuario(string email)
        {
            return View(_usuarios.GetUsuario(email));
        }

        [HttpPost]
        public ActionResult AtualizaUsuario(UsuarioModel _usuarioModel)
        {
            _usuarios.AtualizaUsuario(_usuarioModel);
            return RedirectToAction("Index");
        }
        #endregion

    }
}