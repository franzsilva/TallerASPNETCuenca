using System;

namespace TallerASPNET.Models
{
    public class Participante {

        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int cedula { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }

}