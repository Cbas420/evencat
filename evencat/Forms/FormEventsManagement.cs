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
    public partial class FormEventsManagement : Form
    {
        public FormEventsManagement()
        {
            InitializeComponent();
        }

        private void FormEventsManagement_Load(object sender, EventArgs e)
        {
            BackColor = AppColors.purpleBackground;

        }

        private void buttonSaveEdit_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancelEdit_Click(object sender, EventArgs e)
        {

            //bindingSourceEventsDataGrid.DataSource = UsuarisOrm.Select(); EL SELECT DEBE SER CON EL CORRESPONDIENTE

            dataGridViewEvents.ReadOnly = true;

            // Ocultar Save y Cancel
            buttonSaveEdit.Visible = false;
            buttonCancelEdit.Visible = false;
            buttonChangeStatus.Visible = false;

            buttonEdit.Enabled = true;
            buttonCreateEvent.Enabled = true;

        }

        private void pictureBoxMenuIcon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            dataGridViewEvents.ReadOnly = false;

            // Bloquear las columnas específicas usando sus nombres reales
            dataGridViewEvents.Columns["eventidDataGridViewTextBoxColumn"].ReadOnly = true;
            dataGridViewEvents.Columns["datahoraDataGridViewTextBoxColumn"].ReadOnly = true;
            dataGridViewEvents.Columns["estatDataGridViewTextBoxColumn"].ReadOnly = true;
            dataGridViewEvents.Columns["espaiidDataGridViewTextBoxColumn"].ReadOnly = true;
            dataGridViewEvents.Columns["organitzadoridDataGridViewTextBoxColumn"].ReadOnly = true;
            dataGridViewEvents.Columns["imatge_promocional_url"].ReadOnly = true;



            // Mostrar los botones Save y Cancel
            buttonSaveEdit.Visible = true;
            buttonCancelEdit.Visible = true;
            buttonChangeStatus.Enabled = true;


            buttonEdit.Enabled = false;
            buttonCreateEvent.Enabled = false;
        }
    }
}
