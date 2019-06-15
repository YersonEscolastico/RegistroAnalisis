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

    public partial class rAnalisis : Form
    {
        public List<AnalisisDetalle> Detalle { get; set; }

        public rAnalisis()
        {
            InitializeComponent();
            LlenarComboBox();
            LLenarComboBoxx();
            this.Detalle = new List<AnalisisDetalle>();

        }

        private void Limpiar()
        {
            IdnumericUpDown.Value = 0;
            UsuariocomboBox.Text = string.Empty;
            MyErrorProvider.Clear();
            this.Detalle = new List<AnalisisDetalle>();
            CargarGrid();

        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }


        private Analisis LlenaClase()
        {
            Analisis analisis = new Analisis();
            analisis.AnalisisId = Convert.ToInt32(IdnumericUpDown.Value);
            analisis.UsuarioId = Convert.ToInt32(UsuariocomboBox.SelectedValue);
            analisis.Fecha = FechadateTimePicker.Value;
            analisis.detalle = this.Detalle;
            return analisis;

        }

        private void LlenaCampo(Analisis analisis)
        {
            IdnumericUpDown.Value = analisis.UsuarioId;
            IdnumericUpDown.Value = analisis.AnalisisId;
            FechadateTimePicker.Value = analisis.Fecha;
            UsuariocomboBox.Text = analisis.UsuarioId.ToString();
            this.Detalle = analisis.detalle;
            CargarGrid();



        }
        private void LlenarComboBox()
        {
            var lista = new List<Usuarios>();
            lista = UsuariosBLL.GetList(p => true);
            UsuariocomboBox.DataSource = lista;
            UsuariocomboBox.DisplayMember = "Usuario";
            UsuariocomboBox.ValueMember = "UsuarioId";
        }


        private void LLenarComboBoxx()
        {
            var lista2 = new List<TipoAnalisis>();
            lista2 = TipoAnalalisisBLL.GetList(l => true);
            TipoAnalisiscomboBox.DataSource = lista2;
            TipoAnalisiscomboBox.DisplayMember = "Descripcion";
            TipoAnalisiscomboBox.ValueMember = "TipoId";
        }


        private bool Validar()
        {

            bool paso = true;
            MyErrorProvider.Clear();


            if (UsuariocomboBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(UsuariocomboBox, "Este campo no puede estar vacio");
                UsuariocomboBox.Focus();
                paso = false;

            }

            if (TipoAnalisiscomboBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(TipoAnalisiscomboBox, "Este campo no puede estar vacio");
                TipoAnalisiscomboBox.Focus();
                paso = false;

            }

            if (ResultadotextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(ResultadotextBox, "Este campo no puede estar vacio");
                ResultadotextBox.Focus();
                paso = false;
            }
            return paso;

        }


        private void GuardarButton_Click(object sender, EventArgs e)
        {

            Analisis analisis;
            bool paso = false;

            if (!Validar())
                return;

            analisis = LlenaClase();


            if (IdnumericUpDown.Value == 0)
            {
                paso = AnalisisBLL.Guardar(analisis);
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar una persona que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Modificado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                paso = AnalisisBLL.Modificar(analisis);

            }

            if (paso)
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Limpiar();
        }


        private bool ExisteEnLaBaseDeDatos()
        {
            Analisis analisis = AnalisisBLL.Buscar((int)IdnumericUpDown.Value);
            return (analisis != null);

        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id;
            Analisis analisis = new Analisis();

            int.TryParse(IdnumericUpDown.Text, out id);
            Limpiar();

            analisis = AnalisisBLL.Buscar(id);

            if (analisis != null)
            {
                LlenaCampo(analisis);

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
            if (AnalisisBLL.Eliminar(id))
            {
                MessageBox.Show("Eliminado");
            }
            else
            {
                MyErrorProvider.SetError(IdnumericUpDown, "No se puede elimina, porque no existe");
            }
        }


        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            if (detalleDataGridView.DataSource != null)
                this.Detalle = (List<AnalisisDetalle>)detalleDataGridView.DataSource;

            this.Detalle.Add(
                new AnalisisDetalle(
                    id: 0,
                    analisisID: (int)IdnumericUpDown.Value,
                    tipoID: Convert.ToInt32(TipoAnalisiscomboBox.Text),
                    resultado: ResultadotextBox.Text
                    )
               );

            CargarGrid();
        }

        private void RemoverButton_Click(object sender, EventArgs e)
        {
            if (detalleDataGridView.Rows.Count > 0 && detalleDataGridView.CurrentRow != null)
            {
                //remover la fila
                Detalle.RemoveAt(detalleDataGridView.CurrentRow.Index);

                CargarGrid();
            }
        }

        private void CargarGrid()
        {
            detalleDataGridView.DataSource = null;
            detalleDataGridView.DataSource = Detalle;
        }

        private void AgregarTiposAnalisisButton_Click(object sender, EventArgs e)
        {
            rTiposAnalisis frm = new rTiposAnalisis();
            frm.ShowDialog();
        }
    }
}
