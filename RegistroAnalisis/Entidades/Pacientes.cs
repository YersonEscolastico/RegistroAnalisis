using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAnalisis.Entidades
{
    public class Pacientes
    {
            [Key]
            public int PacienteId { get; set; }
            public string Nombre { get; set; }
            public string Cedula { get; set; }
            public string Sexo { get; set; }
            public int Edad { get; set; }
            public string Direccion { get; set; }

            public Pacientes()
            {
                PacienteId = 0;
                Nombre = string.Empty;
                Cedula = string.Empty;
                Sexo = string.Empty;
                Edad = 0;
                Direccion = string.Empty;
            }
        }
}
