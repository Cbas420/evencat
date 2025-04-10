using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace evencat
{
    public partial class FormUsersManagement : Form
    {
        public FormUsersManagement()
        {
            InitializeComponent();
        }

        private void FormUsersManagement_Load(object sender, EventArgs e)
        {
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
            MakeRoundedMethods.makeRoundeSmallButton(buttonCreateReservation, 15, Color.White, AppColors.purpleButton);
            MakeRoundedMethods.makeRoundeSmallButton(buttonCreateUser, 15, Color.Black, AppColors.grayBackground);
            MakeRoundedMethods.makeRoundeSmallButton(buttonEdit, 15, Color.Black, AppColors.grayBackground);
            MakeRoundedMethods.makeRoundeSmallButton(buttonDelete, 15, Color.White, Color.Red);
            MakeRoundedMethods.MakeRoundedComboBox(comboBoxUserType, 10, "Current state");
            MakeRoundedMethods.MakeRoundedComboBox(comboBoxOrderBy, 10, "Order by");
            MakeRoundedMethods.makeRoundedPanel(panelDataGridView, 35);

            dataGridViewUsers.Left = (panelDataGridView.Width - dataGridViewUsers.Width) / 2;

            panelDataGridView.Left = (Width - panelDataGridView.Width) / 2;


            textBoxUserName.Font = new Font(FontManager.FontCollection.Families[0], spaceNameSize);
        }
    }
}
