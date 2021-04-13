using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PFinalTeleinf.Models.ViewModels
{
    public class ListDetallesResult
    {
        public int ID_RESULTADOEXAMEN { get; set; }
        public int ID_NOMBRE_EXAMEN { get; set; }
        public string RESULTADO { get; set; }
        public int ID_TIPOEXAMEN { get; set; }
        public int ID_RESULTADOPACIENTE { get; set;  }
    }
}