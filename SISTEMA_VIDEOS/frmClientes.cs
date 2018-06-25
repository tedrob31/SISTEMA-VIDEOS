using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaCodigo;
using CapaEntidades;
using CapaDao;

namespace SISTEMA_VIDEOS
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }
        clsclientes oCLi = new clsclientes();
        clsClientesDao oClidao = new clsClientesDao();
        void inicio()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text!="" && textBox3.Text!="" && textBox4.Text!="")
            {
                oCLi.nombres = textBox1.Text;
                oCLi.direccion = textBox2.Text;
                oCLi.telefono = textBox3.Text;
                oCLi.dni = textBox4.Text;
                oClidao.InsertarClientes(oCLi);
                MessageBox.Show("Cliente ingresado con exito :>");
                inicio();
            }
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
             dataGridView1.DataSource= oClidao.llenarClientes();
        }
    }
}
