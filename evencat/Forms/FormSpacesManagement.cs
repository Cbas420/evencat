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
using evencat.Forms;
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

        }

        private void formSpacesManagement_Load(object sender, EventArgs e)
        {
            dataGridViewSpaces.DataSource = EspaisOrm.select();

            loadDesigns();

            if (UserSession.Role == "Organitzador") {

                buttonDelete.Enabled = false;

                buttonEdit.Enabled = false;

                buttonCreateSpace.Enabled = false;

            }

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
            MakeRoundedMethods.MakeRoundedComboBox(comboBoxCurrentSeats, 10, "Seating type");
            MakeRoundedMethods.MakeRoundedComboBox(comboBoxOrderBy, 10, "Order by");
            MakeRoundedMethods.makeRoundedPanel(panelDataGridView, 35);

            MakeRoundedMethods.makeRoundeSmallButton(buttonSaveEdit, 15, Color.White, AppColors.purpleButton);
            MakeRoundedMethods.makeRoundeSmallButton(buttonCancelEdit, 15, Color.White, AppColors.purpleButton);



            dataGridViewSpaces.Left = (panelDataGridView.Width - dataGridViewSpaces.Width) / 2;

            panelDataGridView.Left = (Width - panelDataGridView.Width) / 2;

            textBoxSpaceName.Font = new Font(FontManager.FontCollection.Families[0], spaceNameSize);

            // textBoxEmail.Font = new Font(FontManager.FontCollection.Families[0], textBoxFontSize);


        }

        private void textSpaceName_Leave(object sender, EventArgs e)
        {

        }


        private void pictureBoxMenuIcon_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.OK;

            this.Close();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {

            if (dataGridViewSpaces.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un usuario para editar.");
                return;
            }


            dataGridViewSpaces.ReadOnly = false;

            foreach (DataGridViewRow row in dataGridViewSpaces.Rows)
            {
                if (!row.Selected)
                {
                    row.ReadOnly = true;
                }
            }

            // Bloquear las columnas específicas usando sus nombres reales
            dataGridViewSpaces.Columns["espaiidDataGridViewTextBoxColumn"].ReadOnly = true;

            // Mostrar los botones Save y Cancel
            buttonSaveEdit.Visible = true;
            buttonCancelEdit.Visible = true;

            buttonEdit.Enabled = false;
            buttonCheckAllEvents.Enabled = false;
            buttonDelete.Enabled = false;
            buttonCreateSpace.Enabled = false;

        }

        private void buttonCancelEdit_Click(object sender, EventArgs e)
        {

            bindingSourceSpacesDataGrid.DataSource = EspaisOrm.select();

            dataGridViewSpaces.ReadOnly = true;

            // Ocultar Save y Cancel
            buttonEdit.Enabled = true;
            buttonCheckAllEvents.Enabled = true;
            buttonDelete.Enabled = true;
            buttonCreateSpace.Enabled = true;

            buttonSaveEdit.Visible = false;
            buttonCancelEdit.Visible = false;
        }

        private void buttonCheckAllEvents_Click(object sender, EventArgs e)
        {
            FormEventsManagement formEventsManagement = new FormEventsManagement();
            this.Hide();
            formEventsManagement.ShowDialog();
            this.Show();
        }

        private void comboBoxOrderBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonSearch_Click(sender, e); // Reutiliza el mismo filtro

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string nom = textBoxSpaceName.Text.Trim();

            string cadiraFilter = "All";
            if (comboBoxCurrentSeats.SelectedItem != null)
            {
                cadiraFilter = comboBoxCurrentSeats.SelectedItem.ToString();
            }

            string orderBy = "ID";
            if (comboBoxOrderBy.SelectedItem != null)
            {
                orderBy = comboBoxOrderBy.SelectedItem.ToString();
            }

            var espaisFiltrats = EspaisOrm.searchSpecificSpaces(nom, cadiraFilter, orderBy);

            bindingSourceSpacesDataGrid.DataSource = espaisFiltrats;
            dataGridViewSpaces.DataSource = bindingSourceSpacesDataGrid;//No funcionaba porque no puse esto me voy a matar

        }

        private void buttonCreateSpace_Click(object sender, EventArgs e)
        {
            FormCreateSpace createSpaceForm = new FormCreateSpace();

            createSpaceForm.ShowDialog();
            
            
            bindingSourceSpacesDataGrid.DataSource = EspaisOrm.select();
            dataGridViewSpaces.Refresh();



        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewSpaces.CurrentRow != null)
            {
                var selectedSpace = dataGridViewSpaces.CurrentRow.DataBoundItem as Espais;

                if (selectedSpace != null)
                {
                    var confirmResult = MessageBox.Show(
                        $"¿Estás seguro de que deseas eliminar el espacio: {selectedSpace.nom}?",
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (confirmResult == DialogResult.Yes)
                    {
                        EspaisOrm.delete(selectedSpace);

                        // Recargar datos desde la BD
                        bindingSourceSpacesDataGrid.DataSource = EspaisOrm.select();
                        dataGridViewSpaces.Refresh();
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor selecciona una reserva para eliminar.", "Sin selección");
            }
        }

        private void buttonSaveEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewSpaces.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una fila para guardar.");
                return;
            }

            var row = dataGridViewSpaces.SelectedRows[0];
            Espais updatedSpace = (Espais)row.DataBoundItem;

            // Validar campos requeridos
            if (string.IsNullOrWhiteSpace(updatedSpace.nom) ||
                string.IsNullOrWhiteSpace(updatedSpace.ubicacio) ||
                updatedSpace.metres_quadrats <= 0)
            {
                MessageBox.Show("Revisa que els camps 'Nom', 'Ubicació' i 'Metres quadrats' siguin vàlids.");
                return;
            }

            // Guardar en base de datos
            EspaisOrm.update(updatedSpace);

            MessageBox.Show("Canvis desats correctament.");

            // Restaurar el estado del formulario
            dataGridViewSpaces.ReadOnly = true;
            buttonSaveEdit.Visible = false;
            buttonCancelEdit.Visible = false;

            buttonEdit.Enabled = true;
            buttonCheckAllEvents.Enabled = true;
            buttonDelete.Enabled = true;
            buttonCreateSpace.Enabled = true;

            // Recargar los datos actualizados
            bindingSourceSpacesDataGrid.DataSource = EspaisOrm.select();
        }
    }
}
