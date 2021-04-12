using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PFinalTeleinf.Models.ViewModels
{
    public class ListTablaResult
    {
        public int ID_RESULTADOPACIENTE { get; set; }
        public string NOMBREPACIENTE { get; set; }
        public string APELLIDO { get; set;  }
        public string CEDULA { get; set; }
        public string DIRECCION { get; set; }
        public string TELEFONO { get; set; }
        public string FECHANACIMIENTO { get; set; }
        public string FECHAPROGRAMADA { get; set; }
        public string FECHARESULTADO { get; set; }
        public int ID_CITA { get; set;  }
        public int ID_USUARIO { get; set; }
    }
}