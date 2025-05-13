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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace evencat
{
    public partial class FormSpacesManagement : Form
    {

        public bool VolverAlMenu { get; private set; } = false;

        public FormSpacesManagement()
        {
            InitializeComponent();

            // Verificar si las fuentes están cargadas
            if (FontManager.FontCollection.Families.Length == 0)
            {
                MessageBox.Show("Las fuentes no se han cargado correctamente.");
            }

                this.FormBorderStyle = FormBorderStyle.Sizable; // Eliminar bordes
                this.ControlBox = true; // Eliminar botones de minimizar/maximizar/cerrar
                this.ShowInTaskbar = true; // No mostrar en la barra de tareas
                this.TopMost = true;

        }

        private void formSpacesManagement_Load(object sender, EventArgs e)
        {
            dataGridViewSpaces.DataSource = EspaisOrm.Select();

            loadDesigns();

        }


        private void loadDesigns() {

            dataGridViewSpaces.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;



            textBoxSpaceName.SelectionLength = 0;
            BackColor = AppColors.purpleBackground;

            float titleFontSize = labelSpacesManagement.Font.Size;


            labelSpacesManagement.Font = new Font(FontManager.FontCollection.Families[0], titleFontSize);


            float spaceNameSize = textBoxSpaceName.Font.Size;


            labelSpacesManagement.Left = (Width - labelSpacesManagement.Width) / 2;
            panelSearch.Left = (Width - panelSearch.Width) / 2;
            panelSearch.BackColor = AppColors.grayBackground;

            MakeRoundedMethods.makeRoundedPanel(panelSearch, 35);




            MakeRoundedMethods.makeRoundedTextBox(textBoxSpaceName, 35, "Space name");
            MakeRoundedMethods.makeRoundeSmallButton(buttonSearch, 25, Color.White, AppColors.purpleButton);
            MakeRoundedMethods.makeRoundeSmallButton(buttonCreateSpace, 15, Color.Black, AppColors.grayBackground);
            MakeRoundedMethods.makeRoundeSmallButton(buttonEdit, 15, Color.Black, AppColors.grayBackground);
            MakeRoundedMethods.makeRoundeSmallButton(buttonDelete, 15, Color.White, Color.Red);
            MakeRoundedMethods.makeRoundeSmallButton(buttonCheckAllEvents, 15, Color.White, AppColors.purpleButton);
            MakeRoundedMethods.MakeRoundedComboBox(comboBoxCurrentState, 10, "Current state");
            MakeRoundedMethods.MakeRoundedComboBox(comboBoxOrderBy, 10, "Order by");
            MakeRoundedMethods.makeRoundedPanel(panelDataGridView, 35);

            dataGridViewSpaces.Left = (panelDataGridView.Width - dataGridViewSpaces.Width) / 2;

            panelDataGridView.Left = (Width - panelDataGridView.Width) / 2;

            textBoxSpaceName.Font = new Font(FontManager.FontCollection.Families[0], spaceNameSize);

            // textBoxEmail.Font = new Font(FontManager.FontCollection.Families[0], textBoxFontSize);


        }

        private void textSpaceName_Leave(object sender, EventArgs e)
        {
            // Deseleccionar el texto
            textBoxSpaceName.SelectionLength = 0;
        }

        private void buttonCreateActivity_Click(object sender, EventArgs e)
        {
            FormUsersManagement formUsersManagement = new FormUsersManagement();

            formUsersManagement.Show();
        }

        private void pictureBoxMenuIcon_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.OK;

            this.Close();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {

            dataGridViewSpaces.ReadOnly = false;

            // Bloquear las columnas específicas usando sus nombres reales
            dataGridViewSpaces.Columns["espaiidDataGridViewTextBoxColumn"].ReadOnly = true;
            dataGridViewSpaces.Columns["cadiresfixesDataGridViewTextBoxColumn"].ReadOnly = true; //ESTE SE CAMBIA CON CHANGE STATUS

            // Mostrar los botones Save y Cancel
            buttonSaveEdit.Visible = true;
            buttonCancelEdit.Visible = true;
            buttonChangeStatus.Enabled = true;


            buttonEdit.Enabled = false;
            buttonCheckAllEvents.Enabled = false;
            buttonDelete.Enabled = false;
            buttonCreateSpace.Enabled = false;

        }

        private void buttonCancelEdit_Click(object sender, EventArgs e)
        {

            //bindingSourceSpacesDataGrid.DataSource = UsuarisOrm.Select(); EL SELECT DEBE SER CON EL CORRESPONDIENTE

            dataGridViewSpaces.ReadOnly = true;

            // Ocultar Save y Cancel
            buttonEdit.Enabled = true;
            buttonCheckAllEvents.Enabled = true;
            buttonDelete.Enabled = true;
            buttonCreateSpace.Enabled = true;

            buttonSaveEdit.Visible = false;
            buttonCancelEdit.Visible = false;
            buttonChangeStatus.Enabled = false;
        }

        private void buttonCheckAllEvents_Click(object sender, EventArgs e)
        {
            FormEventsManagement formEventsManagement = new FormEventsManagement();
            this.Hide();
            formEventsManagement.ShowDialog();
            this.Show();
        }
    }
}
