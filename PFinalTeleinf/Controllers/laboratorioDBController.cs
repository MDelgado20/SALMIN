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
       
        public ActionResult MostrarCita()
        {
            List<ListTablaViewModel> lst;
            using (laboratorioDBEntities2 db = new laboratorioDBEntities2())
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
                               FechaNac =  d.FECHANACIMIENTO,
                               FechaPrCita = d.FECHAPROGRAMADA

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
                    using (laboratorioDBEntities2 db = new laboratorioDBEntities2())
                    {
                        var oCita = new CITA();
                        oCita.NOMBREPACIENTE = model.NamePacient;
                        oCita.APELLIDO = model.ApellidoPacient;
                        oCita.CEDULA = model.CedulaPacient;
                        oCita.DIRECCION = model.DireccionPacient;
                        oCita.TELEFONO = model.TelefonoPacient;
                        oCita.FECHANACIMIENTO = model.FechaNac;
                        oCita.FECHAPROGRAMADA = model.FechaPrCita;

                        db.CITA.Add(oCita);
                        db.SaveChanges();

                        
                        
                    }
                  return Redirect("/laboratorioDB/MostrarCita");
                }

                return View(model);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



        public ActionResult CrearResultadoPaciente()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CrearResultadoPaciente(CrearResultadoViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (laboratorioDBEntities2 db = new laboratorioDBEntities2())
                    {
                        var oResultado = new RESULTADO_PACIENTE();
                        oResultado.NOMBREPACIENTE = model.NOMBREPACIENTE;
                        oResultado.APELLIDO = model.APELLIDO;
                        oResultado.CEDULA = model.CEDULA;
                        oResultado.DIRECCION = model.DIRECCION;
                        oResultado.TELEFONO = model.TELEFONO;
                        oResultado.FECHANACIMIENTO = model.FECHANACIM;
                        //oResultado.FECHAPROGRAMADA = model.FECHAPROGRAMADA;
                        oResultado.FECHARESULTADO = model.FECHARESULTADO;


                        db.RESULTADO_PACIENTE.Add(oResultado);
                        db.SaveChanges();
                    }
                    return Redirect("/laboratorioDB/VerResultadoPaciente");
                }

                return View(model);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ActionResult VerResultadoPaciente()
        {
            List<ListTablaResult> lst;
            using (laboratorioDBEntities2 db = new laboratorioDBEntities2())
            {
                lst = (from d in db.RESULTADO_PACIENTE
                       select new ListTablaResult
                       {
                          ID_RESULTADOPACIENTE = d.ID_RESULTADOPACIENTE,
                          NOMBREPACIENTE = d.NOMBREPACIENTE,
                          APELLIDO = d.APELLIDO,
                          CEDULA = d.CEDULA,
                          DIRECCION = d.DIRECCION,
                          TELEFONO = d.TELEFONO,
                          FECHANACIMIENTO = d.FECHANACIMIENTO,
                          //FECHAPROGRAMADA = d.FECHAPROGRAMADA,
                          FECHARESULTADO = d.FECHARESULTADO,
                          //ID_CITA = (int)d.ID_CITA,
                          //ID_USUARIO = (int)d.ID_USUARIO

                       }).ToList();
            }
            return View(lst);
        }

     

        public ActionResult DetallesResultados() {
            return View();
        }

    }
}