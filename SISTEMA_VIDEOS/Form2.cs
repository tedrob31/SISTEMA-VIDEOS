using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISTEMA_VIDEOS
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes prod = new frmClientes();
            //prod.MdiParent = this;
            prod.Show();
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpleado emp = new frmEmpleado();
            //emp.MdiParent = this;
            emp.Show();
        }

        private void actoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmActores act = new frmActores();
            act.Show();
        }

        private void directoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDirectores direc = new frmDirectores();
            direc.Show();
        }
    }
}
