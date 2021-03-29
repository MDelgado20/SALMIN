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
            using (laboratorioDBEntities1 db= new laboratorioDBEntities1())
            {
                 lst = (from d in db.CITA
                           select new ListTablaViewModel
                           {
                               IdCita = d.ID_CITA,
                               //IdUser = (int)d.ID_USUARIO,
                               NamePacient = d.NOMBREPACIENTE,
                               ApellidoPacient = d.APELLIDO,
                               CedulaPacient = d.CEDULA,
                               DireccionPacient = d.DIRECCION,
                               TelefonoPacient = d.TELEFONO,
                               //FechaNac = (DateTime)d.FECHANACIMIENTO,
                               //FechaPrCita = (DateTime)d.FECHAPROGRAMADA

                           }).ToList();
            }
            return View(lst);
        }

       public ActionResult CrearCita()
        {
            return View();
        } 


        [HttpPost]
        public ActionResult CrearCita(CrearPacienteViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (laboratorioDBEntities1 db= new laboratorioDBEntities1())
                    {
                        var oCita = new CITA();
                        oCita.NOMBREPACIENTE = model.NamePacient;
                        oCita.APELLIDO = model.ApellidoPacient;
                        oCita.CEDULA = model.CedulaPacient;
                        oCita.DIRECCION = model.DireccionPacient;
                        oCita.TELEFONO = model.TelefonoPacient;
                        //oCita.FECHANACIMIENTO = model.FechaNac;
                        //oCita.FECHAPROGRAMADA = model.FechaPrCita;

                        db.CITA.Add(oCita);
                        db.SaveChanges();
                        
                        
                    }
                  return Redirect("/");
                }

                return View(model);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
       
    }
}