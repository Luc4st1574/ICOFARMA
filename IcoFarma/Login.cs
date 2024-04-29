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
        private int intentos = 0;
        private int intentosCaptcha = 0;

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
            txtCaptcha.Text = string.Empty;
            intentos = 0;
            GenerarCaptcha();
            this.Show();
            
        }

        private void btnIngresar_Click_1(object sender, EventArgs e)
        {
            if (lblCaptcha.Text != txtCaptcha.Text)
            {
                intentoCaptcha();
                MessageBox.Show($"Captcha incorrecto, Intentos restantes: {3 - intentosCaptcha}", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCaptcha.Text = string.Empty;
                return;
            }
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
                intentosLogin();
                MessageBox.Show($"Usuario o contraseña incorrectos. Intentos restantes: {3 - intentos}", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPass.Text = string.Empty;
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
                if(lblCaptcha.Text != txtCaptcha.Text)
                {
                    intentoCaptcha();
                    MessageBox.Show($"Captcha incorrecto, Intentos restantes: {3-intentosCaptcha}", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCaptcha.Text = string.Empty;
                    return;
                }
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
                    intentosLogin();
                    MessageBox.Show($"Usuario o contraseña incorrectos. Intentos restantes: {3-intentos}", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPass.Text = string.Empty;
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
            GenerarCaptcha();
        }

        private void GenerarCaptcha()
        {
            Random rand = new Random();
            int num = rand.Next(6, 8);
            string captcha = "";
            int total = 0;
            do
            {
                int chr = rand.Next(48, 123);
                if ((chr >= 48 && chr <= 57) || (chr >= 65 && chr <= 90) || (chr >= 97 && chr <= 122))
                {
                    captcha = captcha + (char)chr;
                    total++;
                    if (total == num)
                        break;

                }
            } while (true);

            lblCaptcha.Text = captcha;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            GenerarCaptcha();
        }

        private void intentosLogin()
        {
            intentos++;
            if (intentos == 3)
            {
                MessageBox.Show("Ha superado el número de intentos permitidos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
            txtPass.Text = string.Empty;
        }   

        private void intentoCaptcha()
        {
            intentosCaptcha++;
            if (intentosCaptcha == 3)
            {
                MessageBox.Show("Ha superado el número de intentos permitidos del captcha", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
            txtCaptcha.Text = string.Empty;
        }   
    }
}
