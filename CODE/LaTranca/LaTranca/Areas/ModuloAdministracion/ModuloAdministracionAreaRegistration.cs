using System.Web.Mvc;

namespace LaTranca.Areas.MuduloAdministracion
{
    public class MuduloAdministracionAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "ModuloAdministracion";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "ModuloAdministracion_default",
                "ModuloAdministracion/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}