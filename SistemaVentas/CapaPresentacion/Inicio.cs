using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using CapaNegocio;
using FontAwesome.Sharp;

namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
        private static Usuario usuarioActual;
        private static IconMenuItem MenuActivo = null;
        public static Form FormularioActivo = null;
        public Inicio(Usuario objusuario = null)
        {
            if (objusuario == null) usuarioActual = new Usuario() { NombreCompleto = "Admin Predefinido", IdUsuario = 3 };
            else

                usuarioActual = objusuario;
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            List<Permiso> ListaPermisos = new CN_Permiso().Listar(usuarioActual.IdUsuario);

            
            foreach (IconMenuItem iconMenu in menu.Items)
            {
                bool encontrado = ListaPermisos.Any(m => m.NombreMenu == iconMenu.Name);
                if (encontrado==false)
                {
                    iconMenu.Visible = false;
                }
            }
            lblUsuario.Text = usuarioActual.NombreCompleto;
        }

        private void AbrirFormulario(IconMenuItem menu, Form Formulario)
        {
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.White;
            }
            menu.BackColor = Color.Silver;
            MenuActivo=menu;

            
            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = Formulario;
            Formulario.TopLevel = false;
            Formulario.FormBorderStyle = FormBorderStyle.None;
            Formulario.Dock = DockStyle.Fill;
            Formulario.BackColor = Color.SteelBlue;

            Contenedor.Controls.Add(Formulario);
            Formulario.Show();
        }

       

        private void Submenucategoria_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuMantenedor, new FrmCategoria());
        }

        private void Submenuregistrarventas_Click(object sender, EventArgs e)
        {

            AbrirFormulario(MenuVentas, new FrmVentas());
        }

        private void Submenuproducto_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuMantenedor, new FrmProducto());
        }

        private void submenuregistrarcompras_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuCompras, new FrmCompras());
        }

        private void Submenuverdetallercompras_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuCompras, new FrmDetalleCompra());
        }

        private void Submenuverdetalleventas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuVentas, new FrmDetalleVenta());
        }

        

        private void MenuProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmProveedores());
        }

        private void MenuReportes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmReportes());
        }

        private void MenuClientes_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmClientes());
        }

        private void MenuUsuario_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmUsuario());
        }
    }
}
