using LaTranca.Context.Helper;
using LaTranca.Dominio.DTO.LaTranca;
using LaTranca.ServicioAplicacion.LaTranca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LaTranca.Controllers
{
    public class ProductosController : Controller
    {
        GeneralAppService app = new GeneralAppService();

        // GET: Productos
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListProductos()
        {
            var productos = app.ListProducto();

            return View(productos);
        }

        public ActionResult SaveUpdateProducto(int idProducto = 0)
        {
            var pedido = app.GetIdProducto(idProducto);

            if (pedido == null)
            {
                pedido = new TR_PRODUCTO();
            }

            return View(pedido);
        }

        [HttpPost]
        public ActionResult SaveUpdateProducto(TR_PRODUCTO model)
        {
            Notification notification = null;

            if (model.PROD_ID == 0)
            {
                notification = app.SaveUpdateProducto(model);
            }
            else
            {
                var producto = app.GetIdProducto(model.PROD_ID);
                UpdateModel(producto);
                app.SaveUpdateProducto(producto);
            }
            return RedirectToAction("ListProductos");
        }
    }
}