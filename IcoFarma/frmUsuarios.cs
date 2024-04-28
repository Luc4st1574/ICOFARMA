using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IcoFarma.Utilidades;
using CapaEntidad;
using CapaNegocio;
using System.Windows.Forms.Design;
using System.Diagnostics.Eventing.Reader;

namespace IcoFarma
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            cboestado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            cboestado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });
            cboestado.DisplayMember = "Texto";
            cboestado.ValueMember = "Valor";
            cboestado.SelectedIndex = 0;


            List<Rol> listaRol = new CN_Rol().Listar();

            foreach (Rol item in listaRol)
            {
                cborol.Items.Add(new OpcionCombo() { Valor = item.IdRol, Texto = item.Descripcion });
            }
            cborol.DisplayMember = "Texto";
            cborol.ValueMember = "Valor";
            cborol.SelectedIndex = 0;


            foreach (DataGridViewColumn columna in dgvUsers.Columns)
            {

                if (columna.Visible == true && columna.Name != "btnseleccionar")
                {
                    cbobusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            cbobusqueda.DisplayMember = "Texto";
            cbobusqueda.ValueMember = "Valor";
            cbobusqueda.SelectedIndex = 0;

            List<Usuario> usuarios = new CN_Usuario().Listar();
            foreach (Usuario usuario in usuarios)
            {
                dgvUsers.Rows.Add(new object[] { "", usuario.IdUsuario, usuario.Documento, usuario.NombreCompleto, usuario.Correo, 
                    usuario.Clave, usuario.oRol.IdRol, usuario.oRol.Descripcion, 
                    usuario.Estado == true ? 1 : 0, 
                    usuario.Estado == true ? "Activo" : "Inactivo"
                });
            }   


        }


        private void clear() 
        {
            txtindice.Text = "";
            txtid.Text = "";
            txtDocumento.Text = "";
            txtUsuario.Text = "";
            txtCorreo.Text = "";
            txtClave.Text = "";
            txtConfirmarClave.Text = "";
            cborol.SelectedIndex = 0;
            cboestado.SelectedIndex = 0;
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            txtDocumento.Text = "";
            txtUsuario.Text = "";
            txtCorreo.Text = "";
            txtClave.Text = "";
            txtConfirmarClave.Text = "";
            txtDocumento.Focus();
        }

        

        private void dgvUsers_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUsers.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    txtindice.Text = indice.ToString();
                    txtid.Text = dgvUsers.Rows[indice].Cells["IdUsuario"].Value.ToString();
                    txtDocumento.Text = dgvUsers.Rows[indice].Cells["Documento"].Value.ToString();
                    txtUsuario.Text = dgvUsers.Rows[indice].Cells["NombreCompleto"].Value.ToString();
                    txtCorreo.Text = dgvUsers.Rows[indice].Cells["Correo"].Value.ToString();
                    txtClave.Text = dgvUsers.Rows[indice].Cells["Contraseña"].Value.ToString();
                    txtConfirmarClave.Text = dgvUsers.Rows[indice].Cells["Contraseña"].Value.ToString();

                    foreach (OpcionCombo oc in cborol.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvUsers.Rows[indice].Cells["IdRol"].Value))
                        {
                            int indice_combo = cborol.Items.IndexOf(oc);
                            cborol.SelectedIndex = indice_combo;
                            break;
                        }
                    }

                    foreach (OpcionCombo oc in cboestado.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvUsers.Rows[indice].Cells["Estado"].Value))
                        {
                            int indice_combo = cboestado.Items.IndexOf(oc);
                            cboestado.SelectedIndex = indice_combo;
                            break;
                        }
                    }

                }

            }
        }

        private void dgvUsers_CellPainting_1(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.Checkmark.Width;
                var h = Properties.Resources.Checkmark.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;
                e.Graphics.DrawImage(Properties.Resources.Checkmark, new Rectangle(x, y, w, h));
                e.Handled = true;


            }
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            string mensaje = "";
            Usuario usuario = new Usuario();
            usuario.IdUsuario = Convert.ToInt32(txtid.Text);
            usuario.Documento = txtDocumento.Text;
            usuario.NombreCompleto = txtUsuario.Text;
            usuario.Correo = txtCorreo.Text;
            usuario.Clave = txtClave.Text;
            usuario.oRol = new Rol();
            usuario.oRol.IdRol = Convert.ToInt32(((OpcionCombo)cborol.SelectedItem).Valor);
            usuario.Estado = Convert.ToInt32(((OpcionCombo)cboestado.SelectedItem).Valor) == 1 ? true : false;



            if (usuario.IdUsuario == 0)
            {
                int idUsuario = new CN_Usuario().Registrar(usuario, out mensaje);
                if (idUsuario != 0)
                {
                    dgvUsers.Rows.Add(new object[] { "",idUsuario, txtDocumento.Text, txtUsuario, txtCorreo.Text, txtClave.Text,
                ((OpcionCombo)cborol.SelectedItem).Valor.ToString(),
                ((OpcionCombo)cborol.SelectedItem).Texto.ToString(),
                ((OpcionCombo)cboestado.SelectedItem).Valor.ToString(),
                ((OpcionCombo)cboestado.SelectedItem).Texto.ToString()
                });

                }
                else
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                clear();
            }
            else
            {
                bool resultado = new CN_Usuario().Editar(usuario, out mensaje);
                if (resultado)
                {
                    int indice = Convert.ToInt32(txtindice.Text);
                    dgvUsers.Rows[indice].Cells["IdUsuario"].Value = txtid.Text;
                    dgvUsers.Rows[indice].Cells["Documento"].Value = txtDocumento.Text;
                    dgvUsers.Rows[indice].Cells["NombreCompleto"].Value = txtUsuario.Text;
                    dgvUsers.Rows[indice].Cells["Correo"].Value = txtCorreo.Text;
                    dgvUsers.Rows[indice].Cells["Contraseña"].Value = txtClave.Text;
                    dgvUsers.Rows[indice].Cells["IdRol"].Value = ((OpcionCombo)cborol.SelectedItem).Valor.ToString();
                    dgvUsers.Rows[indice].Cells["Rol"].Value = ((OpcionCombo)cborol.SelectedItem).Texto.ToString();
                    dgvUsers.Rows[indice].Cells["Estado"].Value = ((OpcionCombo)cboestado.SelectedItem).Valor.ToString();
                    dgvUsers.Rows[indice].Cells["EstadoValor"].Value = ((OpcionCombo)cboestado.SelectedItem).Texto.ToString();
                }
                else
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                clear();
            }
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            txtid.Text = "";
            txtDocumento.Text = "";
            txtUsuario.Text = "";
            txtCorreo.Text = "";
            txtClave.Text = "";
            txtConfirmarClave.Text = "";
            txtDocumento.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtid.Text) != 0)
            {
                if (MessageBox.Show("Desea eliminar el usuario", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = "No puedes eliminar";
                    Usuario usuario = new Usuario();
                    usuario.IdUsuario = Convert.ToInt32(txtid.Text);

                    bool Respuesta = new CN_Usuario().Eliminar(usuario, out mensaje);
                    dgvUsers.Rows.RemoveAt(Convert.ToInt32(txtindice.Text));


                }

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cbobusqueda.SelectedItem).Valor.ToString();

            if (dgvUsers.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvUsers.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBusqueda.Text.Trim().ToUpper()))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtBusqueda.Text = "";
            foreach (DataGridViewRow row in dgvUsers.Rows)
            {
                row.Visible = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
