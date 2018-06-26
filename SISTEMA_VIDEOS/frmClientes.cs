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
            mostrarCodigo();
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
                llenarDatagrid();
                
            }
        }

        void llenarDatagrid()
        {
            dataGridView1.DataSource = oClidao.llenarClientes();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            mostrarCodigo();
            llenarDatagrid(); 
        }
        private void mostrarCodigo()
        {
            DataTable dt = oClidao.GenerarCodigoCliente();
            textBox5.Text = dt.Rows[0][0].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            oClidao.EliminarCliente(Convert.ToInt32( textBox5.Text));
            inicio();
            llenarDatagrid();
            
                
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
           textBox5.Text= dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            oCLi.codclient =Convert.ToInt32( textBox5.Text);
            oCLi.nombres = textBox1.Text;
            oCLi.direccion = textBox2.Text;
            oCLi.telefono = textBox3.Text;
            oCLi.dni = textBox4.Text;
            oClidao.ActualizarClientes(oCLi);
            inicio();
            llenarDatagrid();
        }
    }
}
