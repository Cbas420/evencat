using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace evencat
{
    public partial class FormSelectOption : Form
    {
        private Form parentForm;




        public string SelectedOption { get; private set; }



        public FormSelectOption()
        {
            InitializeComponent();


        }

        private void FormSelectOption_Load(object sender, EventArgs e)
        {

            //this.FormBorderStyle = FormBorderStyle.FixedToolWindow; // Eliminar bordes
            //this.ControlBox = false; // Eliminar botones de minimizar/maximizar/cerrar
            //this.TopMost = true;  

            buttonLogOut.Size = buttonSpacesManagement.Size;

            buttonUsersManagement.Size = buttonSpacesManagement.Size;

            panelSelectButton.Left = (Width - panelSelectButton.Width) / 2;

            buttonSpacesManagement.Left = (panelSelectButton.Width - buttonSpacesManagement.Width) / 2;

            buttonUsersManagement.Left = (panelSelectButton.Width - buttonUsersManagement.Width) / 2;

            buttonLogOut.Left = (panelSelectButton.Width - buttonLogOut.Width) / 2;

            int espacioEntreBotones = 20; // Ajusta este valor según necesites
            int alturaTotalBotones = (buttonSpacesManagement.Height * 3) + (espacioEntreBotones * 2);
            int posicionInicialY = (panelSelectButton.Height - alturaTotalBotones) / 2;

            buttonSpacesManagement.Top = posicionInicialY;

            buttonUsersManagement.Top = buttonSpacesManagement.Bottom + espacioEntreBotones;

            buttonLogOut.Top = buttonUsersManagement.Bottom + espacioEntreBotones;

            MakeRoundedMethods.makeRoundedBigButton(buttonSpacesManagement, 20);
            buttonSpacesManagement.BackColor = AppColors.purpleButton;

            MakeRoundedMethods.makeRoundedBigButton(buttonUsersManagement, 20);
            buttonUsersManagement.BackColor = AppColors.purpleButton;

            MakeRoundedMethods.makeRoundedBigButton(buttonLogOut, 20);
            buttonLogOut.BackColor = AppColors.purpleButton;

            MakeRoundedMethods.makeRoundedPanel(panelSelectButton, 15);

            panelSelectButton.BackColor = AppColors.grayBackground;





        }
        private void buttonSpacesManagement_Click(object sender, EventArgs e)
        {

            FormSpacesManagement formSpacesManagement = new FormSpacesManagement();
            this.Hide();
            formSpacesManagement.ShowDialog();

            if (formSpacesManagement.DialogResult == DialogResult.Cancel || formSpacesManagement.DialogResult == DialogResult.OK)
            {

                this.Show();

            }
        }

        private void buttonUsersManagement_Click(object sender, EventArgs e)
        {
            //SelectedOption = "Manage Users";
            //this.DialogResult = DialogResult.OK;



            using (var formUsersManagement = new FormUsersManagement()) {
                this.Hide();

                if (formUsersManagement.ShowDialog() == DialogResult.OK)
                {

                    this.Show();

                }
                else {

                    this.Close();

                }

            }



        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            SelectedOption = "Log Out";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }





        // Hacer que el formulario se mueva junto con el padre

    }
}