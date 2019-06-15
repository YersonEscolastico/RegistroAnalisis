using RegistroAnalisis.UI.Registro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroAnalisis
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void UsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rUsuarios frm = new rUsuarios();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void AnalisisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rAnalisis frm = new rAnalisis();
            frm.Show();
        }
    }
}
