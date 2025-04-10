using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace evencat
{
    public partial class FormStart : Form
    {
        Boolean selectedOption;


        public FormStart()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Lado izquierdo: Centrar labelEvencat y pictureBoxLogoWhite en el espacio a la izquierda del panel
            int espacioIzquierda = panel1.Left;  // El espacio a la izquierda del panel (0 a 398)

            // Centrar labelEvencat y pictureBoxLogoWhite horizontalmente en el espacio disponible
            labelEvencat.Left = (espacioIzquierda - labelEvencat.Width) / 2;
            pictureBoxLogoWhite.Left = (espacioIzquierda - pictureBoxLogoWhite.Width) / 2;

            MakeRoundedMethods.makeRoundedBigButton(buttonNext, 35);
            buttonNext.BackColor = AppColors.purpleButton;



        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            this.Hide();

            if (ShowLoginForm() == DialogResult.OK)
            {
                HandleUserSelection();
            }
        }

        private DialogResult ShowLoginForm()
        {
            using (var formLogIn = new FormLogIn())
            {
                return formLogIn.ShowDialog();
            }
        }

        private void HandleUserSelection()
        {
            var selectedOption = GetUserSelectedOption();

            if (selectedOption == null) return;

            ProcessSelectedOption(selectedOption);
        }

        private string GetUserSelectedOption()
        {
            using (var formSelectOption = new FormSelectOption())
            {
                if (formSelectOption.ShowDialog() == DialogResult.OK)
                {
                    return formSelectOption.SelectedOption;
                }
                return null;
            }
        }

        private void ProcessSelectedOption(string selectedOption)
        {
            MessageBox.Show($"Opción seleccionada: {selectedOption}");

            switch (selectedOption)
            {
                case "Manage Spaces":
                    FormSpacesManagement formSpacesManagement = new FormSpacesManagement();
                    formSpacesManagement.Show();
                    break;
                case "Manage Users":
                    FormUsersManagement formUsersManagement = new FormUsersManagement();
                    formUsersManagement.Show(); 
                    break;
                case "Log Out":
                    // Volver al login
                    break;
                default:
                    // Manejar opción no reconocida
                    break;
            }
        }
    }
}
    






