using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ejercicio.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Index()
        {
            return View();

        }
        public ActionResult procesar(String usuario, String DUI)
        {
            if (usuario.Equals("Katerine") && DUI.Equals("12345678"))
            ViewBag.total = usuario;
            ViewBag.total = DUI;
            {
                return Redirect("/Persona/segundavista");
            }
            return Redirect("/Persona/Index");
        }

        public ActionResult segundavista()
        {
            return View();
        }

        public ActionResult MostrarDatosProcesados(String nombre, String hrstrab, String antiguedad, String valorH)
        {   

            ViewBag.nombre = nombre;
            ViewBag.antiguedad = antiguedad;
            ViewBag.hrstrab = hrstrab;
            ViewBag.valorH = valorH;

            float totalacobrar = (float.Parse(valorH) * float.Parse(hrstrab)) + float.Parse(antiguedad) * 30;
            ViewBag.total = totalacobrar;
   
            return View();
        }
    }
}