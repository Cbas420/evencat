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

            bindingSourceUsersDataGrid.DataSource = UsuarisOrm.select();

            dataGridViewUsers.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }

        private void loadDesigns() {

            textBoxUserName.SelectionLength = 0;
            BackColor = AppColors.purpleBackground;

            float titleFontSize = labelUsersManagement.Font.Size;


            labelUsersManagement.Font = new Font(FontManager.FontCollection.Families[0], titleFontSize);


            float userNameSize = textBoxUserName.Font.Size;


            labelUsersManagement.Left = (Width - labelUsersManagement.Width) / 2;
            panelSearch.Left = (Width - panelSearch.Width) / 2;
            panelSearch.BackColor = AppColors.grayBackground;

            MakeRoundedMethods.makeRoundedPanel(panelSearch, 35);
            MakeRoundedMethods.makeRoundedTextBox(textBoxUserName, 35, "User name");
            MakeRoundedMethods.makeRoundeSmallButton(buttonSearch, 25, Color.White, AppColors.purpleButton);

            MakeRoundedMethods.makeRoundeSmallButton(buttonAllReservations, 15, Color.White, AppColors.purpleButton);

            MakeRoundedMethods.makeRoundeSmallButton(buttonCreateUser, 15, Color.Black, AppColors.grayBackground);
            MakeRoundedMethods.makeRoundeSmallButton(buttonEdit, 15, Color.Black, AppColors.grayBackground);
            MakeRoundedMethods.makeRoundeSmallButton(buttonSaveEdit, 15, Color.Black, AppColors.grayBackground);
            MakeRoundedMethods.makeRoundeSmallButton(buttonCancelEdit, 15, Color.Black, AppColors.grayBackground);

            //MakeRoundedMethods.makeRoundeSmallButton(buttonDelete, 15, Color.White, Color.Red);

            MakeRoundedMethods.MakeRoundedComboBox(comboBoxUserType, 10, "Role");
            MakeRoundedMethods.MakeRoundedComboBox(comboBoxOrderBy, 10, "Order by");
            MakeRoundedMethods.makeRoundedPanel(panelDataGridView, 35);

            dataGridViewUsers.Left = (panelDataGridView.Width - dataGridViewUsers.Width) / 2;

            panelDataGridView.Left = (Width - panelDataGridView.Width) / 2;


            textBoxUserName.Font = new Font(FontManager.FontCollection.Families[0], userNameSize);

        }

        private void buttonCreateUser_Click(object sender, EventArgs e)
        {
            FormCreateUser createUserForm = new FormCreateUser();

            createUserForm.ShowDialog();

            bindingSourceUsersDataGrid.DataSource = UsuarisOrm.select();
            dataGridViewUsers.Refresh();
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
            if (dataGridViewUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un usuario para editar.");
                return;
            }

            dataGridViewUsers.ReadOnly = false;

            // Para solo poder editar la fila seleccionada 
            foreach (DataGridViewRow row in dataGridViewUsers.Rows)
            {
                if (!row.Selected)
                {
                    row.ReadOnly = true;
                }
            }

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
            bindingSourceUsersDataGrid.DataSource = UsuarisOrm.select();

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


            string selectedRole = "All";
            if (comboBoxUserType.SelectedItem != null)
            {
                selectedRole = comboBoxUserType.SelectedItem.ToString();
            }

            if (selectedRole == "Superadmin")
            {
                selectedRole = "Superadministrador";
            }
            else if (selectedRole == "Organizer")
            {
                selectedRole = "Organitzador";
            }
            else if (selectedRole == "NormalUser")
            {
                selectedRole = "UsuariNormal";
            }
            else if (selectedRole == "All")
            {
                selectedRole = "Todos";
            }

            string orden = comboBoxOrderBy.SelectedItem?.ToString() ?? "ID"; //Revisa

            var usuariosFiltrados = UsuarisOrm.searchSpecificUsers(nombre, selectedRole, orden);

            bindingSourceUsersDataGrid.DataSource = usuariosFiltrados;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string name = textBoxUserName.Text.Trim();

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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.CurrentRow != null)
            {
                var selectedUser = dataGridViewUsers.CurrentRow.DataBoundItem as Usuaris;

                if (selectedUser != null)
                {
                    var confirmResult = MessageBox.Show(
                        $"¿Estás seguro de que deseas eliminar el usuario: {selectedUser.nom}?",
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (confirmResult == DialogResult.Yes)
                    {
                        UsuarisOrm.delete(selectedUser);

                        bindingSourceUsersDataGrid.Remove(selectedUser);
                        dataGridViewUsers.Refresh();
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
            if (dataGridViewUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una fila para guardar.");
                return;
            }

            var row = dataGridViewUsers.SelectedRows[0];

            Usuaris updatedUser = (Usuaris)row.DataBoundItem; //Repasar esto

            //Array de strings con los roles que son ya tu sae
            string[] rolesValidos = { "Superadministrador", "Organitzador", "UsuariNormal" };
            if (!rolesValidos.Contains(updatedUser.rol))
            {
                MessageBox.Show("El rol debe ser 'Superadministrador', 'Organitzador' o 'UsuariNormal'.");
                return;
            }

            // Actualizar en BD
            UsuarisOrm.update(updatedUser);

            MessageBox.Show("Cambios guardados.");

            // Restaurar estado original
            dataGridViewUsers.ReadOnly = true;
            buttonSaveEdit.Visible = false;
            buttonCancelEdit.Visible = false;

            buttonEdit.Enabled = true;
            buttonDelete.Enabled = true;
            buttonCreateUser.Enabled = true;
            buttonAllReservations.Enabled = true;

            // Recargar datos
            bindingSourceUsersDataGrid.DataSource = UsuarisOrm.select();
        }
    }
}
