using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio;
using Entidad;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            List<Usuario> Test = new CN_Usuario().Listar(); 
            Usuario ousuario = new CN_Usuario().Listar().Where(u => u.Documento == TxtDocumento.Text && u.Clave == txtClave.Text).FirstOrDefault();

            if (ousuario != null)
            {


                Inicio form = new Inicio(ousuario);
                form.Show();
                this.Hide();
                form.FormClosing += frm_closing;
            }
            else
            {
                MessageBox.Show("No se ha podido encontrar el usuario","Mensaje", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            TxtDocumento.Text = "";
            txtClave.Text = "";
            this.Show();

        }
    }
}
