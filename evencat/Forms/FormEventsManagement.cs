using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using evencat.Forms;
using evencat.Models;

namespace evencat
{
    public partial class FormEventsManagement : Form
    {
        public FormEventsManagement()
        {
            InitializeComponent();
        }

        private void FormEventsManagement_Load(object sender, EventArgs e)
        {
            BackColor = AppColors.purpleBackground;

            bindingSourceEventsDataGrid.DataSource = EsdevenimentsOrm.select();


            dataGridViewEvents.DataSource = bindingSourceEventsDataGrid;


            loadDesigns();

            if (UserSession.Role == "Organitzador")
            {

                buttonEdit.Enabled = false;


            }

        }


        private void loadDesigns()
        {

            dataGridViewEvents.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;



            textBoxEventName.SelectionLength = 0;
            BackColor = AppColors.purpleBackground;

            float titleFontSize = labelEventsManagement.Font.Size;


            labelEventsManagement.Font = new Font(FontManager.FontCollection.Families[0], titleFontSize);


            float eventNameSize = textBoxEventName.Font.Size;


            labelEventsManagement.Left = (Width - labelEventsManagement.Width) / 2;
            panelSearch.Left = (Width - panelSearch.Width) / 2;
            panelSearch.BackColor = AppColors.grayBackground;

            MakeRoundedMethods.makeRoundedPanel(panelSearch, 35);


            MakeRoundedMethods.makeRoundedTextBox(textBoxEventName, 35, "Event name");
            MakeRoundedMethods.makeRoundeSmallButton(buttonSearch, 25, Color.White, AppColors.purpleButton);
            MakeRoundedMethods.makeRoundeSmallButton(buttonCreateEvent, 15, Color.Black, AppColors.grayBackground);
            MakeRoundedMethods.makeRoundeSmallButton(buttonEdit, 15, Color.Black, AppColors.grayBackground);


            MakeRoundedMethods.MakeRoundedComboBox(comboBoxOrderBy, 10, "Order by");
            MakeRoundedMethods.makeRoundedPanel(panelDataGridView, 35);

            MakeRoundedMethods.makeRoundeSmallButton(buttonSaveEdit, 15, Color.White, AppColors.purpleButton);
            MakeRoundedMethods.makeRoundeSmallButton(buttonCancelEdit, 15, Color.White, AppColors.purpleButton);



            MakeRoundedMethods.MakeRoundedComboBox(comboBoxCurrentStatus, 10, "Status");



            dataGridViewEvents.Left = (panelDataGridView.Width - dataGridViewEvents.Width) / 2;

            panelDataGridView.Left = (Width - panelDataGridView.Width) / 2;

            textBoxEventName.Font = new Font(FontManager.FontCollection.Families[0], eventNameSize);

            // textBoxEmail.Font = new Font(FontManager.FontCollection.Families[0], textBoxFontSize);


        }

        private void buttonSaveEdit_Click(object sender, EventArgs e)
        {

            if (dataGridViewEvents.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un evento para guardar.");
                return;
            }

            var row = dataGridViewEvents.SelectedRows[0];
            Esdeveniments updatedEvent = (Esdeveniments)row.DataBoundItem;

            // Validación de 'estat'
            string[] estadosValidos = { "actiu", "cancel·lat", "finalitzat" };
            if (!estadosValidos.Contains(updatedEvent.estat.Trim().ToLower()))
            {
                MessageBox.Show("El estado debe ser 'actiu', 'cancel·lat' o 'finalitzat'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Guardar en BD
            EsdevenimentsOrm.update(updatedEvent);
            MessageBox.Show("Cambios guardados correctamente.");

            // Restaurar estado original
            dataGridViewEvents.ReadOnly = true;
            buttonSaveEdit.Visible = false;
            buttonCancelEdit.Visible = false;

            buttonEdit.Enabled = true;
            buttonCreateEvent.Enabled = true;

            // Recargar los datos
            bindingSourceEventsDataGrid.DataSource = EsdevenimentsOrm.select();

        }



        private void buttonCancelEdit_Click(object sender, EventArgs e)
        {

            //bindingSourceEventsDataGrid.DataSource = UsuarisOrm.Select(); EL SELECT DEBE SER CON EL CORRESPONDIENTE

            dataGridViewEvents.ReadOnly = true;

            // Ocultar Save y Cancel
            buttonSaveEdit.Visible = false;
            buttonCancelEdit.Visible = false;

            buttonEdit.Enabled = true;
            buttonCreateEvent.Enabled = true;

        }

        private void pictureBoxMenuIcon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewEvents.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un evento para editar.");
                return;
            }

            dataGridViewEvents.ReadOnly = false;

            // Hacer todas las filas solo lectura excepto la seleccionada
            foreach (DataGridViewRow row in dataGridViewEvents.Rows)
            {
                row.ReadOnly = !row.Selected;
            }

            // Bloquear columnas específicas incluso en la fila seleccionada
            dataGridViewEvents.Columns["eventidDataGridViewTextBoxColumn"].ReadOnly = true;
            dataGridViewEvents.Columns["datahoraDataGridViewTextBoxColumn"].ReadOnly = true;
            dataGridViewEvents.Columns["espaiidDataGridViewTextBoxColumn"].ReadOnly = true;
            dataGridViewEvents.Columns["organitzadoridDataGridViewTextBoxColumn"].ReadOnly = true;
            dataGridViewEvents.Columns["imatge_promocional_url"].ReadOnly = true;

            // Mostrar botones Save y Cancel
            buttonSaveEdit.Visible = true;
            buttonCancelEdit.Visible = true;

            buttonEdit.Enabled = false;
            buttonCreateEvent.Enabled = false;
        }

        private void dataGridViewEvents_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            // Solo validar si la columna es "estat"
            if (dataGridViewEvents.Columns[e.ColumnIndex].DataPropertyName == "estat")
            {
                string newValue = e.FormattedValue.ToString().Trim().ToLower();

                List<string> allowedStatuses = new List<string> { "actiu", "cancel·lat", "finalitzat" };

                if (!allowedStatuses.Contains(newValue))
                {
                    e.Cancel = true; // cancela el cambio
                    MessageBox.Show("Valor inválido para 'estat'. Solo se permite: actiu, cancel·lat, finalitzat.",
                                    "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    // Opcional: marca la celda con un color de error
                    dataGridViewEvents.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightCoral;
                }
                else
                {
                    // Restaurar color si es válido
                    dataGridViewEvents.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = dataGridViewEvents.DefaultCellStyle.BackColor;
                }
            }
        }


        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string name = textBoxEventName.Text.Trim();

            string selectedStatus = comboBoxCurrentStatus.SelectedItem?.ToString() ?? "All";
            string dbStatus = ""; // cadena vacía para que no filtre si es "All"

            if (selectedStatus == "Active")
            {
                dbStatus = "actiu";
            }
            else if (selectedStatus == "Finished")
            {
                dbStatus = "finalitzat";
            }
            else if (selectedStatus == "Cancelled")
            {
                dbStatus = "cancel·lat";
            }

            string selectedOrder = comboBoxOrderBy.SelectedItem?.ToString() ?? "ID";

            var filteredEvents = EsdevenimentsOrm.searchSpecificEvents(name, dbStatus, selectedOrder);

            bindingSourceEventsDataGrid.DataSource = filteredEvents;

            dataGridViewEvents.Refresh();
        }

        private void comboBoxOrderBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonSearch.PerformClick(); // Reutiliza el click de búsqueda

        }

        private void comboBoxCurrentStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonCreateEvent_Click(object sender, EventArgs e)
        {
            FormCreateEvent formCreateEvent = new FormCreateEvent();
            this.Hide();
            formCreateEvent.ShowDialog();
            this.Show();
            bindingSourceEventsDataGrid.DataSource = EsdevenimentsOrm.select();
        }
    }
}
