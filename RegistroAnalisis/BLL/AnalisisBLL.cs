﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using RegistroAnalisis.DAL;
using RegistroAnalisis.Entidades;

namespace RegistroAnalisis.BLL
{
    public class AnalisisBLL
    {

        public static bool Guardar(Analisis analisis)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if (db.Analisis.Add(analisis) != null)

                    paso = db.SaveChanges() > 0;

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


        public static bool Modificar(Analisis analisis)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                var Anterior = db.Analisis.Find(analisis.AnalisisId);
                foreach (var item in Anterior.detalle)
                {
                    if (!analisis.detalle.Exists(d => d.AnalisisDetalleId == item.AnalisisDetalleId))
                        db.Entry(item).State = EntityState.Deleted;
                }
                db.Entry(analisis).State = EntityState.Modified;
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
                var eliminar = db.Analisis.Find(id);
                db.Entry(eliminar).State = EntityState.Deleted;
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


        public static Analisis Buscar(int id)
        {
            Analisis analisis = new Analisis();
            Contexto db = new Contexto();


            try
            {
                analisis = db.Analisis.Find(id);
                analisis.detalle.Count();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return analisis;

        }

        public static List<Analisis> GetList(Expression<Func<Analisis, bool>> analisis)
        {
            List<Analisis> Lista = new List<Analisis>();
            Contexto db = new Contexto();

            try
            {
                Lista = db.Analisis.Where(analisis).ToList();

            }
            catch
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return Lista;
        }
    }
}
