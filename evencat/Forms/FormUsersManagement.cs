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

            //PENDIENTE. HACER LA EDICIÓN Y QUE SE GUARDE
            //BLOQUEAR ACCIONES DEPENDIENDO DE USUARIO
            //HACER DELETE
            //AGREGAR FILTROS
            //AGREGAR BUSQUEDA POR NOMBRE
            //AGREGAR ORDENAR POR (TOMAR EN CUENTA LOS FILTROS)


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

            //dataGridViewUsers.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Centrar el texto de las celdas
            //dataGridViewUsers.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Centrar los encabezados de las columnas
            //dataGridViewUsers.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

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

            MakeRoundedMethods.makeRoundeSmallButton(buttonAllReservations, 15, Color.White, AppColors.purpleButton);

            MakeRoundedMethods.makeRoundeSmallButton(buttonCreateUser, 15, Color.Black, AppColors.grayBackground);
            MakeRoundedMethods.makeRoundeSmallButton(buttonEdit, 15, Color.Black, AppColors.grayBackground);

            //MakeRoundedMethods.makeRoundeSmallButton(buttonDelete, 15, Color.White, Color.Red);

            MakeRoundedMethods.MakeRoundedComboBox(comboBoxUserType, 10, "Role");
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
            this.Hide();
            formReservationsManagement.ShowDialog();
            this.Show();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            dataGridViewUsers.ReadOnly = false;

            // Bloquear las columnas específicas usando sus nombres reales
            dataGridViewUsers.Columns["usuariidDataGridViewTextBoxColumn"].ReadOnly = true;
            dataGridViewUsers.Columns["dataregistreDataGridViewTextBoxColumn"].ReadOnly = true;

            // Mostrar los botones Save y Cancel
            buttonSaveEdit.Visible = true;
            buttonCancelEdit.Visible = true;

            buttonEdit.Enabled = false;
            buttonDelete.Enabled = false;
            buttonCreateUser.Enabled = false;
            buttonAllReservations.Enabled = false;

        }

        private void buttonCancelEdit_Click(object sender, EventArgs e)
        {
            bindingSourceUsersDataGrid.DataSource = UsuarisOrm.Select();

            dataGridViewUsers.ReadOnly = true;

            // Ocultar Save y Cancel
            buttonSaveEdit.Visible = false;
            buttonCancelEdit.Visible = false;

            buttonEdit.Enabled = true;
            buttonDelete.Enabled = true;
            buttonCreateUser.Enabled = true;
            buttonAllReservations.Enabled = true;

        }

        private void comboBoxOrderBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombre = textBoxUserName.Text.Trim();
            string rol = comboBoxUserType.SelectedItem?.ToString() ?? "All";
            string orden = comboBoxOrderBy.SelectedItem?.ToString() ?? "ID";

            var usuariosFiltrados = UsuarisOrm.searchSpecificUsers(nombre, rol, orden);

            bindingSourceUsersDataGrid.DataSource = usuariosFiltrados;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string name = textBoxUserName.Text.Trim();

            Console.WriteLine($"Valor de textBoxUserName.Text: '{name}'");

            // Obtener valor seleccionado del ComboBox de roles
            string selectedRole = "All";
            if (comboBoxUserType.SelectedItem != null)
            {
                selectedRole = comboBoxUserType.SelectedItem.ToString();
            }

            // Traducir el valor del ComboBox al valor que espera la base de datos
            string role = "Todos";
            if (selectedRole == "Superadmin")
            {
                role = "Superadministrador";
            }
            else if (selectedRole == "Organizer")
            {
                role = "Organitzador";
            }
            else if (selectedRole == "NormalUser")
            {
                role = "UsuariNormal";
            }
            else if (selectedRole == "All")
            {
                role = "Todos";
            }

            // Obtener valor seleccionado del ComboBox de orden
            string order = "ID";
            if (comboBoxOrderBy.SelectedItem != null)
            {
                order = comboBoxOrderBy.SelectedItem.ToString();
            }

            // Llamar al método para obtener los usuarios filtrados y ordenados
            var filteredUsers = UsuarisOrm.searchSpecificUsers(name, role, order);

            // Mostrar los usuarios en el DataGrid
            bindingSourceUsersDataGrid.DataSource = filteredUsers;

        }
    }
}
