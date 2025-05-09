using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using evencat.Models;

namespace evencat
{
    public partial class FormUsersManagement : Form
    {

        public bool goToMenu { get; private set; } = false;

        public FormUsersManagement()
        {
            InitializeComponent();


            // Verificar rol para habilitar/deshabilitar funciones
            if (UserSession.Role != "Superadministrador")
            {
                MakeRoundedMethods.makeRoundeSmallButton(buttonDelete, 15, Color.White, Color.DarkRed);
                buttonDelete.Enabled = false;


            }
            else {
                MakeRoundedMethods.makeRoundeSmallButton(buttonDelete, 15, Color.White, Color.Red);
                buttonDelete.Enabled = true;
            }
        }

        private void FormUsersManagement_Load(object sender, EventArgs e)
        {
            loadDesigns();

            bindingSourceUsersDataGrid.DataSource = UsuarisOrm.Select();

            dataGridViewUsers.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }

        private void loadDesigns() {

            dataGridViewUsers.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            textBoxUserName.SelectionLength = 0;
            BackColor = AppColors.purpleBackground;

            float titleFontSize = labelUsersManagement.Font.Size;


            labelUsersManagement.Font = new Font(FontManager.FontCollection.Families[0], titleFontSize);


            float spaceNameSize = textBoxUserName.Font.Size;


            labelUsersManagement.Left = (Width - labelUsersManagement.Width) / 2;
            panelSearch.Left = (Width - panelSearch.Width) / 2;
            panelSearch.BackColor = AppColors.grayBackground;

            MakeRoundedMethods.makeRoundedPanel(panelSearch, 35);
            MakeRoundedMethods.makeRoundedTextBox(textBoxUserName, 35, "Space name");
            MakeRoundedMethods.makeRoundeSmallButton(buttonSearch, 25, Color.White, AppColors.purpleButton);
            MakeRoundedMethods.makeRoundeSmallButton(buttonCheckUserReservations, 15, Color.White, AppColors.purpleButton);

            MakeRoundedMethods.makeRoundeSmallButton(buttonAllReservations, 15, Color.White, AppColors.purpleButton);

            MakeRoundedMethods.makeRoundeSmallButton(buttonCreateUser, 15, Color.Black, AppColors.grayBackground);
            MakeRoundedMethods.makeRoundeSmallButton(buttonEdit, 15, Color.Black, AppColors.grayBackground);

            //MakeRoundedMethods.makeRoundeSmallButton(buttonDelete, 15, Color.White, Color.Red);

            MakeRoundedMethods.MakeRoundedComboBox(comboBoxUserType, 10, "Current state");
            MakeRoundedMethods.MakeRoundedComboBox(comboBoxOrderBy, 10, "Order by");
            MakeRoundedMethods.makeRoundedPanel(panelDataGridView, 35);

            dataGridViewUsers.Left = (panelDataGridView.Width - dataGridViewUsers.Width) / 2;

            panelDataGridView.Left = (Width - panelDataGridView.Width) / 2;


            textBoxUserName.Font = new Font(FontManager.FontCollection.Families[0], spaceNameSize);

        }

        private void buttonCreateUser_Click(object sender, EventArgs e)
        {
            FormCreateUser createUserForm = new FormCreateUser();

            createUserForm.ShowDialog();



        }

        private void pictureBoxMenu_Click(object sender, EventArgs e)
        {

           this.DialogResult = DialogResult.OK;

            this.Close();
        }

        private void buttonAllReservations_Click(object sender, EventArgs e)
        {
            FormReservationsManagement formReservationsManagement = new FormReservationsManagement();
            formReservationsManagement.ShowDialog();
        }
    }
}
