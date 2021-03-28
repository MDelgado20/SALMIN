using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc; 
using PFinalTeleinf.Models;
using PFinalTeleinf.Models.ViewModels;

namespace PFinalTeleinf.Controllers
{
    public class laboratorioDBController : Controller
    {
        // GET: laboratorioDB
        public ActionResult Index()
        {
            List<ListTablaViewModel> lst;
            using (laboratorioDBEntities db = new laboratorioDBEntities())
            {
                
                 lst = (from d in db.CITA
                           select new ListTablaViewModel
                           {
                                Id = d.ID_CITA,
                                IdUser = (int)d.ID_USUARIO,
                                NamePacient = d.NOMBREPACIENTE,
                                ApellidoPacient = d.APELLIDO,
                                CedulaPacient = d.CEDULA,
                                DireccionPacient = d.DIRECCION,
                                TelefonoPacient = d.TELEFONO,
                                FechaNac = (DateTime)d.FECHANACIMIENTO,
                                FechaPrCita = (DateTime) d.FECHAPROGRAMADA
                           }).ToList();
            }
            return View(lst);
        }
    }
}