using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using evencat.Helpers;
using evencat.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace evencat
{
    public partial class FormLogIn : Form
    {
        private PrivateFontCollection fontCollection;
        public int UsuarioId { get; private set; }
        public string Email { get; private set; }
        public string Rol { get; private set; }
        public bool LoginSuccess { get; private set; } = false;

        public FormLogIn()
        {
            InitializeComponent();
        }

        private void FormStart_Load(object sender, EventArgs e)
        {

            TopMost = true;

            BackColor = AppColors.purpleBackground;
            float titleFontSize = labelEvencat.Font.Size;

            float textBoxFontSize = textBoxEmail.Font.Size;


            //deberia hacer un metodo que cargue todos los diseños o lo dejo todo en el load?

            //lo de las fuentes funciona bien asi? o hay una forma de incrustarlas en el proyecto como recurso sin tener que
            //programar cada label uno a uno

            MakeRoundedMethods.makeRoundedPanel(panelLogin, 70);

            labelEvencat.Font = new Font(FontManager.FontCollection.Families[1], titleFontSize);

            //tengo que encontrar la forma de automatizar esto

            labelEvencat.Left = (panelLogin.Width - labelEvencat.Width) / 2;

            pictureBoxLogo.Left = (panelLogin.Width - pictureBoxLogo.Width) / 2;

            panelPurpleBar.BackColor = AppColors.purpleBackground;

            panelPurpleBar.Left = (panelLogin.Width - panelPurpleBar.Width) / 2;

            textBoxEmail.Left = (panelLogin.Width - textBoxEmail.Width) / 2;

            textBoxPassword.Left = (panelLogin.Width - textBoxPassword.Width) / 2;


            buttonLogIn.Left = (panelLogin.Width - buttonLogIn.Width) / 2;


            buttonLogIn.BackColor = AppColors.purpleButton;


            MakeRoundedMethods.makeRoundedTextBox(textBoxEmail, 35, "Email");
            MakeRoundedMethods.makeRoundedTextBox(textBoxPassword, 35, "Password");
            MakeRoundedMethods.makeRoundedBigButton(buttonLogIn, 35);

            textBoxEmail.Font = new Font(FontManager.FontCollection.Families[0], textBoxFontSize);
            textBoxPassword.Font = new Font(FontManager.FontCollection.Families[0], textBoxFontSize);

        }

        private void panelLogin_Paint(object sender, PaintEventArgs e)
        {
            panelLogin.Location = new Point(
                this.ClientSize.Width / 2 - panelLogin.Size.Width / 2,
                this.ClientSize.Height / 2 - panelLogin.Size.Height / 2);
            panelLogin.BackColor = AppColors.grayBackground;
        }

        public void LoadCustomFonts()
        {
            fontCollection = new PrivateFontCollection();

            // Rutas de los archivos de la fuente
            string[] fontFiles = new string[]
            {
            "Poppins-Black.ttf",
            "Poppins-Light.ttf",
            "Poppins-Regular.ttf"
            };

            // Cargar todas las fuentes
            foreach (string fontFile in fontFiles)
            {
                string fontPath = Path.Combine(Application.StartupPath, "fonts", fontFile);

                // Verificar si el archivo de la fuente existe
                if (File.Exists(fontPath))
                {
                    try
                    {
                        // Cargar la fuente desde el archivo
                        fontCollection.AddFontFile(fontPath);
                    }
                    catch (Exception ex)
                    {
                        // Si hay un error, mostrar el mensaje y qué archivo de fuente falló
                        MessageBox.Show($"Error al cargar la fuente {fontFile}: {ex.Message}");
                    }
                }
                else
                {
                    // Si no se encuentra el archivo de la fuente
                    MessageBox.Show($"No se encontró el archivo de la fuente: {fontPath}");
                }
            }
        }



        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxEmail.Text) || string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            VerifyCredentials();
        }

        private void VerifyCredentials()
        {
            try
            {
                var usuario = Orm.bd.Usuaris
                    .FirstOrDefault(u => u.email == textBoxEmail.Text.Trim());

                if (usuario != null)
                {
                    // Encriptar lo que escribió el usuario
                    string encryptedInputPassword = Encryption.encrypt(textBoxPassword.Text);

                    if (usuario.password_hash == encryptedInputPassword)
                    {
                        UserSession.UserId = usuario.usuari_id;
                        UserSession.Email = usuario.email;
                        UserSession.Role = usuario.rol;

                        LoginSuccess = true;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta.", "Error",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Usuario no encontrado.", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al verificar credenciales: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '*';
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBoxPassword.Text))
            {

                textBoxPassword.Text = "Password";

                textBoxPassword.PasswordChar = '\0';

                textBoxPassword.ForeColor = Color.Gray;

            }
            else {

                textBoxPassword.PasswordChar = '*';

            }


        }


    }
}


