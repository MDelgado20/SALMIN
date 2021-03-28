using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PFinalTeleinf.Models.ViewModels
{
    public class ListTablaViewModel
    {
        public int Id { get; set; } 
        public int IdUser { get; set; }

        public string NamePacient { get; set; }

        public string ApellidoPacient { get; set; }

        public string CedulaPacient { get; set; }

        public string DireccionPacient { get; set; }

        public string TelefonoPacient { get; set; }

        public DateTime FechaNac { get; set; }

        public DateTime FechaPrCita { get; set; }
         
    }
}