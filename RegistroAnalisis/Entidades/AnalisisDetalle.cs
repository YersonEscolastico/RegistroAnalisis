using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAnalisis.Entidades
{
    public class AnalisisDetalle
    {
        [Key]
        public int AnalisisDetalleId { get; set; }
        public int AnalisisId { get; set; }
        public int TipoId { get; set; }
        public string Resultado { get; set; }

        public AnalisisDetalle()
        {
            AnalisisDetalleId = 0;
            AnalisisId = 0;
            TipoId = 0;
            Resultado = string.Empty;
        }

        public AnalisisDetalle(int id, int analisisID, int tipoID, string resultado)
        {
            AnalisisDetalleId = id;
            AnalisisId = analisisID;
            TipoId = tipoID;
            Resultado = resultado;
        }
    }
}
