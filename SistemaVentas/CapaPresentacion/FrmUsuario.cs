using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.Utilidades;
using Entidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            CboEstado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            CboEstado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });

            CboEstado.DisplayMember = "Texto";
            CboEstado.ValueMember = "Valor";
            CboEstado.SelectedIndex = 0;



            List<Rol> listaRol = new CN_Rol().Listar();
            foreach (Rol Item in listaRol)
            {
                CboRol.Items.Add(new OpcionCombo() { Valor = Item.IdRol, Texto = Item.Descripcion });
            }

            CboRol.DisplayMember = "Texto";
            CboRol.ValueMember = "Valor";
            CboRol.SelectedIndex = 0;


            foreach (DataGridViewColumn columna in DgvData.Columns)
            {
                if (columna.Visible == true)
                {
                    CboBusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
                CboBusqueda.DisplayMember = "Texto";
                CboBusqueda.ValueMember = "Valor";
                CboBusqueda.SelectedIndex = 0;
            }

            //Mostrar todos los user
            List<Usuario> listausuario = new CN_Usuario().Listar();
            foreach (Usuario Item in listausuario)
            {
                DgvData.Rows.Add(new object[] {"",Item.IdUsuario,Item.Documento,Item.NombreCompleto,Item.Correo,Item.Clave,
                                         Item.oRol.IdRol,
                                         Item.oRol.Descripcion,
                                         Item.Estado == true ? 1 : 0,
                                        Item.Estado == true ? "Activo" : "No Activo",

                });
                    } } 

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

            //Usuario objusuario = new Usuario();
            //{

            //    IdUsuario = Convert.ToInt32(txtId.Text),
            //        Documento =TxtDocumento.Text,
            //        NombreCompleto = TxtNombreCompleto.Text,
            //        Correo = TxtCorreo.Text,
            //        Clave= TxtClave.Text,
            //        oRol = new Rol() { IdRol = Convert.ToInt32(((OpcionCombo) CboRol.SelectedItem).Valor) },
            //        Estado = Convert.ToInt32(((OpcionCombo)CboEstado.SelectedItem).Valor) == 1? true : false
            //};



            DgvData.Rows.Add(new object[] {"",txtId.Text,TxtDocumento.Text,TxtNombreCompleto.Text,TxtCorreo.Text,TxtClave.Text,
                                         ((OpcionCombo) CboRol.SelectedItem).Valor.ToString(),
                                         ((OpcionCombo) CboRol.SelectedItem).Texto.ToString(),
                                         ((OpcionCombo) CboEstado.SelectedItem).Valor.ToString(),
                                         ((OpcionCombo) CboEstado.SelectedItem).Texto.ToString()
            });
            Limpiar();

        }

        private void Limpiar()
        {
            TxtIndice.Text = "-1";
            txtId.Text = "0";
            TxtDocumento.Text = "";
            TxtNombreCompleto.Text = "";
            TxtCorreo.Text = "";
            TxtClave.Text = "";
            TxtConfirmarClave.Text = "";
            CboRol.SelectedIndex = 0;
            CboEstado.SelectedIndex = 0;


        }

        private void DgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvData.Columns[e.ColumnIndex].Name == "BtnSeleccionar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    TxtIndice.Text = indice.ToString();
                    txtId.Text = DgvData.Rows[indice].Cells["Id"].Value.ToString();
                    TxtDocumento.Text = DgvData.Rows[indice].Cells["Documento"].Value.ToString();
                    TxtNombreCompleto.Text = DgvData.Rows[indice].Cells["NombreCompleto"].Value.ToString();
                    TxtCorreo.Text = DgvData.Rows[indice].Cells["Correo"].Value.ToString();
                    TxtClave.Text = DgvData.Rows[indice].Cells["Clave"].Value.ToString();
                    TxtConfirmarClave.Text = DgvData.Rows[indice].Cells["Clave"].Value.ToString();


                    foreach (OpcionCombo oc  in CboRol.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(DgvData.Rows[indice].Cells["IdRol"].Value))
                        {
                            int indice_combo = CboRol.Items.IndexOf(oc);
                            CboRol.SelectedIndex = indice_combo;
                            break;


                        }
                    }

                    foreach (OpcionCombo oc in CboEstado.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(DgvData.Rows[indice].Cells["EstadoValor"].Value))
                        {
                            int indice_combo = CboEstado.Items.IndexOf(oc);
                            CboEstado.SelectedIndex = indice_combo;
                            break;


                        }
                    }

                }
            }
        }
    }
}
