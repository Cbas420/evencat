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
    /// <summary>
    /// Formulario para la creación de nuevos eventos en el sistema.
    /// Permite seleccionar un espacio existente y asignarle los detalles del evento.
    /// </summary>
    public partial class FormCreateEvent : Form
    {
        /// <summary>
        /// Constructor inicial del formulario
        /// </summary>
        public FormCreateEvent()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento que se ejecuta al cargar el formulario.
        /// Carga los espacios disponibles y configura el diseño visual.
        /// </summary>
        private void FormCreateEvent_Load(object sender, EventArgs e)
        {
            // Cargar todos los espacios disponibles en el DataGridView
            dataGridViewSpaces.DataSource = EspaisOrm.select();

            // Configurar el diseño visual de los controles
            loadDesigns();
        }

        /// <summary>
        /// Configura el diseño visual de todos los controles del formulario.
        /// Incluye fuentes, colores, bordes redondeados y posicionamiento.
        /// </summary>
        private void loadDesigns()
        {
            // Configuración del DataGridView
            dataGridViewSpaces.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Configuración del campo de búsqueda
            textBoxSearchSpace.SelectionLength = 0;

            // Configuración de colores de fondo
            BackColor = AppColors.purpleBackground;
            panelNewEvent.BackColor = AppColors.grayBackground;
            panelSearch.BackColor = AppColors.grayBackground;

            // Configuración de fuentes personalizadas
            float titleFontSize = labelCreateEvent.Font.Size;
            float spaceNameSize = textBoxSearchSpace.Font.Size;

            labelCreateEvent.Font = new Font(FontManager.FontCollection.Families[0], titleFontSize);
            labelNewEvent.Font = new Font(FontManager.FontCollection.Families[0], 35);
            textBoxSearchSpace.Font = new Font(FontManager.FontCollection.Families[0], spaceNameSize);

            // Centrado de elementos en el formulario
            labelCreateEvent.Left = (Width - labelCreateEvent.Width) / 2;
            panelSearch.Left = (Width - panelSearch.Width) / 2;

            // Aplicación de bordes redondeados a los controles
            MakeRoundedMethods.makeRoundedPanel(panelSearch, 35);
            MakeRoundedMethods.makeRoundedTextBox(textBoxSearchSpace, 35, "Search space");
            MakeRoundedMethods.makeRoundedTextBox(textBoxEventName, 35, "Name");
            MakeRoundedMethods.makeRoundedTextBox(textBoxEventDescription, 35, "Description");
            MakeRoundedMethods.makeRoundedTextBox(textBoxEventImage, 35, "Image (URL)");
            MakeRoundedMethods.makeRoundeSmallButton(buttonSearch, 25, Color.White, AppColors.purpleButton);
            MakeRoundedMethods.makeRoundeSmallButton(buttonCreateEvent, 15, Color.White, AppColors.purpleButton);
            MakeRoundedMethods.makeRoundedPanel(panelDataGridView, 35);
            MakeRoundedMethods.makeRoundedPanel(panelNewEvent, 35);
        }

        /// <summary>
        /// Evento click para el botón de búsqueda de espacios.
        /// Filtra los espacios según el texto introducido en el campo de búsqueda.
        /// </summary>
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            // Obtener el texto de búsqueda (eliminando espacios al inicio/fin)
            string nom = textBoxSearchSpace.Text.Trim();

            // Valores por defecto para los filtros
            string cadiraFilter = "All";
            string orderBy = "ID";

            // Obtener espacios filtrados según el criterio de búsqueda
            var espaisFiltrats = EspaisOrm.searchSpecificSpaces(nom, cadiraFilter, orderBy);

            // Asignar los resultados filtrados al DataGridView
            bindingSourceSpaces.DataSource = espaisFiltrats;
            dataGridViewSpaces.DataSource = bindingSourceSpaces;
        }

        /// <summary>
        /// Evento click para el icono de menú.
        /// Cierra el formulario actual.
        /// </summary>
        private void pictureBoxMenuIcon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Evento click para el botón de crear evento.
        /// Valida los datos y crea un nuevo evento en la base de datos.
        /// </summary>
        private void buttonCreateEvent_Click(object sender, EventArgs e)
        {
            // Validar que se haya seleccionado un espacio
            if (dataGridViewSpaces.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un espacio para el evento.");
                return;
            }

            // Obtener los valores de los campos del formulario
            string nom = textBoxEventName.Text.Trim();
            string descripcio = textBoxEventDescription.Text.Trim();
            string imatgeUrl = textBoxEventImage.Text.Trim();

            // Validar campos obligatorios
            if (string.IsNullOrWhiteSpace(nom) || nom == "Name" ||
                string.IsNullOrWhiteSpace(descripcio) || descripcio == "Description")
            {
                MessageBox.Show("El nombre y la descripción del evento son obligatorios.");
                return;
            }

            // Si no hay URL de imagen o es el texto por defecto, se guarda como null
            if (string.IsNullOrWhiteSpace(imatgeUrl) || imatgeUrl == "Image (URL)")
            {
                imatgeUrl = null;
            }

            // Obtener el espacio seleccionado del DataGridView
            DataGridViewRow selectedRow = dataGridViewSpaces.SelectedRows[0];
            Espais espaiSeleccionat = (Espais)selectedRow.DataBoundItem;
            int espaiId = espaiSeleccionat.espai_id;

            // Crear el objeto del nuevo evento
            Esdeveniments nouEvent = new Esdeveniments
            {
                nom = nom,
                descripcio = descripcio,
                imatge_promocional_url = imatgeUrl,
                data_hora = DateTime.Now, // Fecha/hora actual
                estat = "actiu", // Estado por defecto
                espai_id = espaiId,
                organitzador_id = UserSession.UserId // ID del usuario logueado
            };

            // Insertar el nuevo evento en la base de datos
            EsdevenimentsOrm.insert(nouEvent);

            // Mostrar mensaje de confirmación
            MessageBox.Show("Evento creado exitosamente.");

            // Cerrar el formulario
            this.Close();
        }
    }
}