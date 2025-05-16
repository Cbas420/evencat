using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using evencat.Helpers;
using evencat.Models;


namespace evencat
{
    public partial class FormCreateUser : Form
    {

        private BindingSource bindingSourceRoles = new BindingSource();


        //private PrivateFontCollection fontCollection;

        public FormCreateUser()
        {
            InitializeComponent();

            //Encriptar antes de enviar

            //Actualizar base de datos con campo de nombre

            //Encriptar en BlowFish

            //NECESITO: Campo de nombre y campo de estado (Activo o Deshabilitado)

            //Usar la id del usuario de la sesión actual para el campo "created by"

            //Usar la fecha actual

        }

        private void FormCreateUser_Load(object sender, EventArgs e)
        {



            labelDescription.Font = new Font(FontManager.FontCollection.Families[1], labelDescription.Font.Size);



            //tengo que encontrar la forma de automatizar esto

            panelTitle.Left = (Width - panelTitle.Width) / 2;

            textBoxName.Left = (Width - textBoxName.Width) / 2;

            textBoxEmail.Left = (Width - textBoxEmail.Width) / 2;

            textBoxPassword.Left = (Width - textBoxPassword.Width) / 2;

            textBoxConfirmPassword.Left = (Width - textBoxConfirmPassword.Width) / 2;

            comboBoxUserType.Left = (Width - comboBoxUserType.Width) / 2;

            buttonCreateUser.Left = (Width - buttonCreateUser.Width) / 2;

            textBoxDescription.Left = (Width - textBoxDescription.Width) / 2;



            MakeRoundedMethods.makeRoundeSmallButton(buttonCreateUser, 25, Color.White, AppColors.purpleButton);
            MakeRoundedMethods.MakeRoundedComboBox(comboBoxUserType, 13, "Current state");
            MakeRoundedMethods.makeRoundedTextBox(textBoxEmail, 35, "Email");
            MakeRoundedMethods.makeRoundedTextBox(textBoxName, 35, "Name");
            MakeRoundedMethods.makeRoundedTextBox(textBoxPassword, 35, "Password");
            MakeRoundedMethods.makeRoundedTextBox(textBoxConfirmPassword, 35, "Confirm Password");

            if (UserSession.Role.ToString() != "Superadministrador")
            {
                var listaRoles = new List<string> {
                    "Administrator",
                    "Common"
                };
                bindingSourceRoles.DataSource = listaRoles;

                comboBoxUserType.Text = "Select user type";

                comboBoxUserType.DataSource = bindingSourceRoles;


            }

        }

        private void labelDescription_Click(object sender, EventArgs e)
        {

        }

        private void buttonCreateUser_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedRole = comboBoxUserType.SelectedItem?.ToString();
                string password = textBoxPassword.Text;
                string confirmPassword = textBoxConfirmPassword.Text;
                string email = textBoxEmail.Text.Trim();

                // Validación de rol
                if (selectedRole != "Administrator" && selectedRole != "Common" && selectedRole != "Organizer")
                    throw new Exception("Por favor, selecciona un tipo de usuario válido.");

                // Validación de contraseñas
                if (password != confirmPassword)
                    throw new Exception("Las contraseñas no coinciden.");

                // Validación simple de email con el CHECK de SQL Server
                if (!System.Text.RegularExpressions.Regex.IsMatch(email, @"^.+@..+\..{2,}$"))
                    throw new Exception("Por favor, introduce un email válido (ejemplo: usuario@dominio.com).");

                // Mapeo del rol al valor real
                string role = selectedRole == "Administrator" ? "Superadministrador"
                             : selectedRole == "Common" ? "UsuariNormal"
                             : "Organitzador";

                var user = new Usuaris
                {
                    nom = textBoxName.Text.Trim(),
                    email = email,
                    password_hash = Encryption.encrypt(password),
                    rol = role,
                    data_registre = DateTime.Now,
                    created_by = UserSession.UserId,
                    descripcio = textBoxDescription.Text.Trim()
                };

                UsuarisOrm.insert(user);
                MessageBox.Show("Usuario creado correctamente.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al crear usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

