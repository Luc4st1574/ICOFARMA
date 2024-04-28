using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;

namespace IcoFarma
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pbMostrar_Click(object sender, EventArgs e)
        {
            pbOcultar.BringToFront();
            txtPass.PasswordChar = '\0';
            pbOcultar.Invalidate();
        }

        private void pbOcultar_Click(object sender, EventArgs e)
        {
            pbMostrar.BringToFront();
            txtPass.PasswordChar = '*';
            pbMostrar.Invalidate();
        }

        private void pbOcultar_MouseEnter(object sender, EventArgs e)
        {
            pbOcultar.BackColor = Color.AliceBlue;
        }

        private void pbOcultar_MouseLeave(object sender, EventArgs e)
        {
            pbOcultar.BackColor = Color.Transparent;
        }

        private void pbMostrar_MouseEnter(object sender, EventArgs e)
        {
            pbMostrar.BackColor = Color.AliceBlue;
        }

        private void pbMostrar_MouseLeave(object sender, EventArgs e)
        {
            pbMostrar.BackColor = Color.Transparent;
        }

        private void frm_Closing(object sender, FormClosingEventArgs e)
        {
            
            txtUser.Text = string.Empty;
            txtPass.Text = string.Empty;
            this.Show();
            
        }

        private void btnIngresar_Click_1(object sender, EventArgs e)
        {
            List<Usuario> Test = new CN_Usuario().Listar();

            Usuario usuario = new CN_Usuario().Listar().Where(u => u.NombreCompleto == txtUser.Text && u.Clave == txtPass.Text).
                FirstOrDefault();

            if (usuario != null)
            {
                if (usuario.Logged == false) // Comprobar si el usuario no está conectado
                {
                    // Marcar al usuario como conectado
                    new CN_Usuario().loggedtrue(usuario);

                    // Abrir la ventana de inicio
                    Inicio inicio = new Inicio(usuario);
                    inicio.FormClosing += frm_Closing;
                    inicio.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("El usuario ya está conectado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
            this.Close();
            
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                List<Usuario> Test = new CN_Usuario().Listar();

                Usuario usuario = new CN_Usuario().Listar().Where(u => u.NombreCompleto == txtUser.Text && u.Clave == txtPass.Text).
                    FirstOrDefault();

                if (usuario != null)
                {
                    if (usuario.Logged == false) // Comprobar si el usuario no está conectado
                    {
                        // Marcar al usuario como conectado
                        new CN_Usuario().loggedtrue(usuario);

                        // Abrir la ventana de inicio
                        Inicio inicio = new Inicio(usuario);
                        inicio.FormClosing += frm_Closing;
                        inicio.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("El usuario ya está conectado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
