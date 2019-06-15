﻿using RegistroAnalisis.BLL;
using RegistroAnalisis.DAL;
using RegistroAnalisis.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegistroAnalisis.UI.Registro;

namespace RegistroAnalisis.UI.Registro
{
    public partial class rTiposAnalisis : Form
    {
        public rTiposAnalisis()
        {
            InitializeComponent();
        }



        private void Limpiar()
        {
            IdnumericUpDown.Value = 0;
            DescripciontextBox.Text = string.Empty;

        }

        public TipoAnalisis LlenaClase()
        {
            TipoAnalisis tipoanalisis = new TipoAnalisis();
            tipoanalisis.TipoId = Convert.ToInt32(IdnumericUpDown.Value);
            tipoanalisis.Descripcion = DescripciontextBox.Text;

            return tipoanalisis;
        }

        private void LlenaCampo(TipoAnalisis tipoanalisis)
        {
            IdnumericUpDown.Value = tipoanalisis.TipoId;
            DescripciontextBox.Text = tipoanalisis.Descripcion;

        }

        private bool ExisteEnLaBaseDeDatos()
        {
            TipoAnalisis tipoanalisis = TipoAnalalisisBLL.Buscar((int)IdnumericUpDown.Value);
            return (tipoanalisis != null);

        }

        public static bool NoRepetido(string descripcion)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if (db.TipoAnalisis.Any(p => p.Descripcion.Equals(descripcion)))
                {
                    paso = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        private bool ValidarCampos()
        {
            bool paso = true;
            if (DescripciontextBox.Text == string.Empty)
            {
                MessageBox.Show("Este campo no puede estar vacio");
                DescripciontextBox.Focus();
                paso = false;
            }
            if (NoRepetido(DescripciontextBox.Text))
            {
                MessageBox.Show("Este campo no puede estar vacio");
                DescripciontextBox.Focus();
                paso = false;
            }

            return paso;
        }

 

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();
            int id;
            int.TryParse(IdnumericUpDown.Text, out id);
            Limpiar();
            if (TipoAnalalisisBLL.Eliminar(id))
            {
                MessageBox.Show("Eliminado");
            }
            else
            {
                MyErrorProvider.SetError(IdnumericUpDown, "No se puede eliminar, porque no existe");
            }
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            TipoAnalisis tipoanalisis;
            bool paso = false;


            if (!ValidarCampos())
                return;

            tipoanalisis = LlenaClase();


            if (IdnumericUpDown.Value == 0)
            {
                paso = TipoAnalalisisBLL.Guardar(tipoanalisis);

            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un Tipo de analisis que no existe que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = TipoAnalalisisBLL.Modificar(tipoanalisis);

            }

            if (paso)
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else
                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Limpiar();

        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void BuscarButton_Click_1(object sender, EventArgs e)
        {
            int id;

            TipoAnalisis tipoanalisis = new TipoAnalisis();

            int.TryParse(IdnumericUpDown.Text, out id);
            Limpiar();

            tipoanalisis = TipoAnalalisisBLL.Buscar(id);

            if (tipoanalisis != null)
            {
                MessageBox.Show("ubicacion encontrada");
                LlenaCampo(tipoanalisis);

            }
            else
            {
                MessageBox.Show("ubicacion no encontrada");
            }
        }
    }
}
