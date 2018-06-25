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

namespace SISTEMA_VIDEOS
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
           inicio();
        }

        void inicio()
        {
            label4.Enabled = false;
            label2.Enabled = false;
            txtContra.Enabled = false;
            button1.Enabled = false;

            label4.Visible = false;
            label2.Visible = false;
            txtContra.Visible = false;
            button1.Visible = false;
            button3.Enabled = false;
            button3.Visible = false;
        }
        clsEmpleadoEntity oEmpleado = new clsEmpleadoEntity();
        clsEmpleadosDao oEmpleadoDao = new clsEmpleadosDao();
        private void button1_Click(object sender, EventArgs e)
        {
         //   MessageBox.Show("hola");
            oEmpleado.ususario = this.txtUsu.Text;
            oEmpleado.clave = this.txtContra.Text;
            

            if (oEmpleadoDao.VerificarAcceso(oEmpleado) == true)
            {
                MessageBox.Show("BIENVENIDOS AL SISTEMA:... " + txtUsu.Text);
                //mostrar el formulario menú o dni(padre)
                Form2 menu = new Form2();
                menu.Show();
                //ocultar el login
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario y/o Clave Incorrecto ");
                this.txtUsu.Clear();
                this.txtContra.Clear();
                this.txtUsu.Focus();
                button3.Visible = true;
                button3.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Enabled = true;
            label4.Visible = true;

            button2.Enabled = false;
            button2.Visible = false;
            txtUsu.Enabled = false;
            label1.Enabled = true;
            txtUsu.Visible = false;
            label1.Visible = false;


            label2.Enabled = true;
            txtContra.Enabled = true;
            button1.Enabled = true;

            label4.Visible = true;
            label2.Visible = true;
            txtContra.Visible = true;
            button1.Visible = true;
            label4.Text = "Bienvenido Usuario De Correo :   " + txtUsu.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            inicio();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
