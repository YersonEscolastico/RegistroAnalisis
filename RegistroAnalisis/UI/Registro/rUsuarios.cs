using RegistroAnalisis.BLL;
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
    public partial class rUsuarios : Form
    {
        public rUsuarios()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            IdnumericUpDown.Value = 0;
            NombretextBox.Text = string.Empty;
            EmailtextBox.Text = string.Empty;
            NivelUsuariocomboBox.Text = string.Empty;
            ClavetextBox.Text = string.Empty;
            UsuariotextBox.Text = string.Empty;
            ConfirmarClavetextBox.Text = string.Empty;
            MyErrorProvider.Clear();


        }


        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private Usuarios LlenaClase()
        {
            Usuarios usuario = new Usuarios();
            usuario.UsuarioId = Convert.ToInt32(IdnumericUpDown.Value);
            usuario.Nombres = NombretextBox.Text;
            usuario.Email = EmailtextBox.Text;
            usuario.NivelUsuario = NivelUsuariocomboBox.Text;
            usuario.Clave = ClavetextBox.Text;
            usuario.Usuario = UsuariotextBox.Text;
            usuario.FechaIngreso = FechaIngresodateTimePicker.Value;
            return usuario;

        }

        private void LlenaCampo(Usuarios usuario)
        {
            IdnumericUpDown.Value = usuario.UsuarioId;
            NombretextBox.Text = usuario.Nombres;
            EmailtextBox.Text = usuario.Email;
            NivelUsuariocomboBox.Text = usuario.NivelUsuario;
            ClavetextBox.Text = usuario.Clave;
            UsuariotextBox.Text = usuario.Usuario;
            FechaIngresodateTimePicker.Value = usuario.FechaIngreso;

        }

        private bool Validar()
        {

            bool paso = true;
            MyErrorProvider.Clear();

            string Clave = ClavetextBox.Text;
            string Confirmar = ConfirmarClavetextBox.Text;

            int Resultado = 0;

            Resultado = string.Compare(Clave, Confirmar);

            if (Resultado != 0)
            {
                MyErrorProvider.SetError(ConfirmarClavetextBox, "Clave no coincide!");
                ConfirmarClavetextBox.Focus();
                paso = false;
            }
            if (NombretextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(NombretextBox, "Este campo no puede estar vacio");
                NombretextBox.Focus();
                paso = false;
            }
            if (EmailtextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(EmailtextBox, "Este campo no puede estar vacio");
                EmailtextBox.Focus();
                paso = false;
            }
            if (NivelUsuariocomboBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(NivelUsuariocomboBox, "Este campo no puede estar vacio");
                NivelUsuariocomboBox.Focus();
                paso = false;

            }
            if (UsuariotextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(UsuariotextBox, "Este campo no puede estar vacio");
                UsuariotextBox.Focus();
                paso = false;

            }
            if (ClavetextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(ClavetextBox, "Este campo no puede estar vacio");
                ClavetextBox.Focus();
                paso = false;

            }
            if (ConfirmarClavetextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(ConfirmarClavetextBox, "Este campo no puede estar vacio");
                ConfirmarClavetextBox.Focus();
                paso = false;

            }
            if (NoRepetido(UsuariotextBox.Text))
            {
                MessageBox.Show("Los Usuarios no pueden ser iguales");
                UsuariotextBox.Focus();
                paso = false;
            }
            return paso;
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Usuarios usuario;
            bool paso = false;

            if (!Validar())
                return;

            usuario = LlenaClase();


            if (IdnumericUpDown.Value == 0)
            {
                paso = UsuariosBLL.Guardar(usuario);
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un usuario que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = UsuariosBLL.Modificar(usuario);

            }

            if (paso)
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Limpiar();
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Usuarios usuario = UsuariosBLL.Buscar((int)IdnumericUpDown.Value);
            return (usuario != null);

        }


        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id;
            Usuarios usuario = new Usuarios();

            int.TryParse(IdnumericUpDown.Text, out id);
            Limpiar();

            usuario = UsuariosBLL.Buscar(id);

            if (usuario != null)
            {
                LlenaCampo(usuario);

            }
            else
            {
                MessageBox.Show("Usuario no existe");
            }
        }



        private void EliminarButton_Click(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();
            int id;
            int.TryParse(IdnumericUpDown.Text, out id);
            Limpiar();
            if (UsuariosBLL.Eliminar(id))
            {
                MessageBox.Show("Eliminado");
            }
            else
            {
                MyErrorProvider.SetError(IdnumericUpDown, "No se puede eliminar, porque no existe");
            }
        }

        public static bool NoRepetido(string descripcion)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if (db.Usuarios.Any(p => p.Usuario.Equals(descripcion)))
                {
                    paso = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("!Ya existe otro campo con ese nombre!");
            }
            return paso;
        }


        private void NivelUsuariocomboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
