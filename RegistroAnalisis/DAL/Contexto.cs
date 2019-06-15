using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistroAnalisis.Entidades;
namespace RegistroAnalisis.DAL
{
    public class Contexto: DbContext
    {
        public DbSet<Analisis> Analisis { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<TipoAnalisis> TipoAnalisis { get; set; }

        public Contexto() : base("Constr") { }
    }
}