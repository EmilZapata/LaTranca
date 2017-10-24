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
                pedido = new Producto();
            }

            return View(pedido);
        }

        [HttpPost]
        public ActionResult SaveUpdateProducto(Producto model)
        {
            Notification notification = null;

            if (model.idProducto == 0)
            {
                notification = app.SaveUpdateProducto(model);
            }
            else
            {
                var producto = app.GetIdProducto(model.idProducto);
                UpdateModel(producto);
                app.SaveUpdateProducto(producto);
            }
            return RedirectToAction("ListProductos");
        }
    }
}