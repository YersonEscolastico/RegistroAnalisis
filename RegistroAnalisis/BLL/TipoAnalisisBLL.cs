using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using RegistroAnalisis.DAL;
using RegistroAnalisis.Entidades;
using RegistroAnalisis.BLL;
using System.Windows.Forms;

namespace RegistroAnalisis.BLL
{
    public class TipoAnalalisisBLL
    {

        public static bool Guardar(TipoAnalisis tipoanalisis)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if (db.TipoAnalisis.Add(tipoanalisis) != null)

                    paso = db.SaveChanges() > 0;

            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo guardar");
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }


        public static bool Modificar(TipoAnalisis tipoanalisis)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                db.Entry(tipoanalisis).State = EntityState.Modified;
                paso = (db.SaveChanges() > 0);

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;

        }


        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                var eliminar = db.TipoAnalisis.Find(id);
                db.Entry(eliminar).State = EntityState.Deleted;
                paso = (db.SaveChanges() > 0);
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo eliminar");
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }


        public static TipoAnalisis Buscar(int id)
        {
            TipoAnalisis tipoanalisis = new TipoAnalisis();
            Contexto db = new Contexto();


            try
            {
                tipoanalisis = db.TipoAnalisis.Find(id);
                db.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo buscar");
            }
            finally
            {
                db.Dispose();
            }
            return tipoanalisis;

        }

        public static List<TipoAnalisis> GetList(Expression<Func<TipoAnalisis, bool>> tipoanalisis)
        {
            List<TipoAnalisis> Lista = new List<TipoAnalisis>();
            Contexto db = new Contexto();

            try
            {
                Lista = db.TipoAnalisis.Where(tipoanalisis).ToList();

            }
            catch
            {
                MessageBox.Show("No se pudo listar");
            }
            finally
            {
                db.Dispose();
            }
            return Lista;

        }
    }
}
