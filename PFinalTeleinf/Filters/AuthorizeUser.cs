using PFinalTeleinf.Controllers;
using PFinalTeleinf.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PFinalTeleinf.Filters
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class AuthorizeUser : AuthorizeAttribute
    {
        private USUARIO oUsuario;
        private laboratorioDBEntities2 db = new laboratorioDBEntities2();
        private int idOperacion;
    }
}