using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using evencat.Models;

namespace evencat
{
    public partial class FormCreateUser : Form
    {

        private BindingSource bindingSourceRoles = new BindingSource();


        private PrivateFontCollection fontCollection;

        public FormCreateUser()
        {
            InitializeComponent();
        }

        private void FormCreateUser_Load(object sender, EventArgs e)
        {



            labelDescription.Font = new Font(FontManager.FontCollection.Families[1], labelDescription.Font.Size);



        //tengo que encontrar la forma de automatizar esto

        panelTitle.Left = (Width - panelTitle.Width) / 2;

            textBoxName.Left = (Width - textBoxName.Width) / 2;

            textBoxLastName.Left = (Width - textBoxLastName.Width) / 2;

            textBoxEmail.Left = (Width - textBoxEmail.Width) / 2;

            textBoxPassword.Left = (Width - textBoxPassword.Width) / 2;

            textBoxConfirmPassword.Left = (Width - textBoxConfirmPassword.Width) / 2;

            comboBoxUserType.Left = (Width - comboBoxUserType.Width) / 2;

            buttonCreateUser.Left = (Width - buttonCreateUser.Width) / 2;


            MakeRoundedMethods.makeRoundeSmallButton(buttonCreateUser, 25, Color.White, AppColors.purpleButton);
            MakeRoundedMethods.MakeRoundedComboBox(comboBoxUserType, 13, "Current state");
            MakeRoundedMethods.makeRoundedTextBox(textBoxEmail, 35, "Email");
            MakeRoundedMethods.makeRoundedTextBox(textBoxName, 35, "Name");
            MakeRoundedMethods.makeRoundedTextBox(textBoxLastName, 35, "Last Name");
            MakeRoundedMethods.makeRoundedTextBox(textBoxPassword, 35, "Password");
            MakeRoundedMethods.makeRoundedTextBox(textBoxConfirmPassword, 35, "Confirm Password");

            if (UserSession.Role.ToString() != "Superadministrador") {
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
            string rolSeleccionado = comboBoxUserType.SelectedItem?.ToString();

            Usuaris user = new Usuaris();

            user.email = textBoxEmail.Text.Trim();

            user.password_hash = textBoxPassword.Text; //Encriptar antes de enviar

            //Actualizar base de datos con campo de nombre

            //Encriptar en BlowFish

            //NECESITO: Campo de nombre y campo de estado (Activo o Deshabilitado)

            //Usar la id del usuario de la sesión actual para el campo "created by"

            //Usar la fecha actual





            

        }
    }
}
