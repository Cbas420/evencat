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

namespace evencat.Forms
{
    public partial class FormCreateEvent : Form
    {
        public FormCreateEvent()
        {
            InitializeComponent();
        }
        private void FormCreateEvent_Load(object sender, EventArgs e)
        {
            dataGridViewSpaces.DataSource = EspaisOrm.select();
            loadDesigns();


        }


        private void loadDesigns()
        {

            dataGridViewSpaces.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            textBoxSearchSpace.SelectionLength = 0;
            BackColor = AppColors.purpleBackground;

            panelNewEvent.BackColor = AppColors.grayBackground;

            float titleFontSize = labelCreateEvent.Font.Size;
            float spaceNameSize = textBoxSearchSpace.Font.Size;


            labelCreateEvent.Font = new Font(FontManager.FontCollection.Families[0], titleFontSize);

            labelNewEvent.Font = new Font(FontManager.FontCollection.Families[0], 35);

            textBoxSearchSpace.Font = new Font(FontManager.FontCollection.Families[0], spaceNameSize);




            labelCreateEvent.Left = (Width - labelCreateEvent.Width) / 2;
            panelSearch.Left = (Width - panelSearch.Width) / 2;
            panelSearch.BackColor = AppColors.grayBackground;

            MakeRoundedMethods.makeRoundedPanel(panelSearch, 35);
            MakeRoundedMethods.makeRoundedTextBox(textBoxSearchSpace, 35, "Search space");
            MakeRoundedMethods.makeRoundedTextBox(textBoxEventName, 35, "Name");
            MakeRoundedMethods.makeRoundedTextBox(textBoxEventDescription, 35, "Description");
            MakeRoundedMethods.makeRoundedTextBox(textBoxEventImage, 35, "Image (URL)");
            MakeRoundedMethods.makeRoundeSmallButton(buttonSearch, 25, Color.White, AppColors.purpleButton);
            MakeRoundedMethods.makeRoundeSmallButton(buttonCreateEvent, 15, Color.White, AppColors.purpleButton);
            MakeRoundedMethods.makeRoundedPanel(panelDataGridView, 35);
            MakeRoundedMethods.makeRoundedPanel(panelNewEvent, 35);

            // textBoxEmail.Font = new Font(FontManager.FontCollection.Families[0], textBoxFontSize);


        }


        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string nom = textBoxSearchSpace.Text.Trim();

            string cadiraFilter = "All";

            string orderBy = "ID";


            var espaisFiltrats = EspaisOrm.searchSpecificSpaces(nom, cadiraFilter, orderBy);

            bindingSourceSpaces.DataSource = espaisFiltrats;
            dataGridViewSpaces.DataSource = bindingSourceSpaces;//No funcionaba porque no puse esto me voy a matar

        }

        private void pictureBoxMenuIcon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCreateEvent_Click(object sender, EventArgs e)
        {
            // Validar que haya un espacio seleccionado
            if (dataGridViewSpaces.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un espacio para el evento.");
                return;
            }

            // Capturar los valores
            string nom = textBoxEventName.Text.Trim();
            string descripcio = textBoxEventDescription.Text.Trim();
            string imatgeUrl = textBoxEventImage.Text.Trim();

            // Validar campos obligatorios y evitar textos por defecto
            if (string.IsNullOrWhiteSpace(nom) || nom == "Name" ||
                string.IsNullOrWhiteSpace(descripcio) || descripcio == "Description")
            {
                MessageBox.Show("El nombre y la descripción del evento son obligatorios.");
                return;
            }

            // Si la imagen está vacía o tiene el valor por defecto, se guarda como null
            if (string.IsNullOrWhiteSpace(imatgeUrl) || imatgeUrl == "Image (URL)")
            {
                imatgeUrl = null;
            }

            // Obtener espai_id del espacio seleccionado
            DataGridViewRow selectedRow = dataGridViewSpaces.SelectedRows[0];
            Espais espaiSeleccionat = (Espais)selectedRow.DataBoundItem;
            int espaiId = espaiSeleccionat.espai_id;

            // Crear el objeto del nuevo evento
            Esdeveniments nouEvent = new Esdeveniments
            {
                nom = nom,
                descripcio = descripcio,
                imatge_promocional_url = imatgeUrl,
                data_hora = DateTime.Now,
                estat = "actiu", // valor por defecto
                espai_id = espaiId,
                organitzador_id = UserSession.UserId // Asumiendo que ya existe esta propiedad
            };

            // Insertar en BD
            EsdevenimentsOrm.insert(nouEvent);

            MessageBox.Show("Evento creado exitosamente.");

            this.Close();
        }
    }
}
