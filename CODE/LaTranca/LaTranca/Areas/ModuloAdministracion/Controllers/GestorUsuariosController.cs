using LaTranca.Context.Helper;
using LaTranca.Dominio.DTO.LaTranca;
using LaTranca.ServicioAplicacion.LaTranca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LaTranca.Areas.MuduloAdministracion.Controllers
{
    [Authorize]
    public class GestorUsuariosController : Controller
    {
        GeneralAppService app = new GeneralAppService();

        // GET: MuduloAdministracion/GestorUsuarios
        public ActionResult Index()
        {
            var usuarios = app.GetListUsuariosTR();

            return View(usuarios);
        }

        public ActionResult SaveUpdateUsuario(int idUsuario = 0, int accion = 0)
        {
            TR_USUARIO usuario;

            if (idUsuario != 0)
            {
                usuario = app.GetUsuarioID(idUsuario);
            }
            else
            {
                usuario = new TR_USUARIO();
            }

            ViewBag.accion = accion;

            return View(usuario);
        }

        [HttpPost]
        public JsonResult SaveUpdateUsuario(TR_USUARIO model)
        {
            Notification notificacion = null;

            if (model.USER_ID == 0)
            {
                notificacion = app.SaveUpdateUsuario(model);
            }
            else
            {
                notificacion = app.SaveUpdateUsuario(model);
            }

            return Json(new
            {
                notificacion = notificacion
            });
        }
    }
}