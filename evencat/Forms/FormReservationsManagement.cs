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
    public partial class FormReservationsManagement : Form
    {
        public FormReservationsManagement()
        {
            InitializeComponent();


        }

        private void FormReservationsManagement_Load(object sender, EventArgs e)
        {
            BackColor = AppColors.purpleBackground;
            if (UserSession.Role == "Organitzador")
            {
                pictureBoxMenuIcon.Image = evencat.Resource1.menuIconWhite;

                bindingSourceReserves.DataSource = ReservesOrm.selectForOrganitzador(UserSession.UserId);
            }
            else
            {
                bindingSourceReserves.DataSource = ReservesOrm.select();
            }


            loadDesigns();
        }


        private void loadDesigns()
        {

            dataGridViewReservations.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            MakeRoundedMethods.makeRoundedPanel(panelSearch, 35);

            BackColor = AppColors.purpleBackground;




            float titleFontSize = labelReservationsManagement.Font.Size;







            panelSearch.Left = (Width - panelSearch.Width) / 2;
            panelSearch.BackColor = AppColors.grayBackground;

            MakeRoundedMethods.makeRoundedPanel(panelSearch, 35);
            MakeRoundedMethods.makeRoundedTextBox(textBoxSearchUser, 35, "Search user");
            MakeRoundedMethods.makeRoundedTextBox(textBoxUserName, 35, "Name");
            MakeRoundedMethods.makeRoundedTextBox(textBoxEventName, 35, "Event name");
            MakeRoundedMethods.makeRoundedTextBox(textBoxUserEmail, 35, "Email");

            MakeRoundedMethods.makeRoundedPanel(panelDataGridView, 35);

            MakeRoundedMethods.makeRoundeSmallButton(buttonApplyFilter, 15, Color.White, AppColors.purpleButton);

            MakeRoundedMethods.makeRoundeSmallButton(buttonSearch, 15, Color.White, AppColors.purpleButton);

            MakeRoundedMethods.makeRoundeSmallButton(buttonDelete, 15, Color.White, Color.Red);




            // textBoxEmail.Font = new Font(FontManager.FontCollection.Families[0], textBoxFontSize);


        }

        private void dataGridViewReservations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dataGridViewReservations.Rows[e.RowIndex];
                    int usuariId = Convert.ToInt32(row.Cells["usuariidDataGridViewTextBoxColumn"].Value);
                    int eventId = Convert.ToInt32(row.Cells["eventidDataGridViewTextBoxColumn"].Value);

                    var usuario = Orm.bd.Usuaris.FirstOrDefault(u => u.usuari_id == usuariId); //REPASAR
                    var evento = Orm.bd.Esdeveniments.FirstOrDefault(eve => eve.event_id == eventId); //REPASAR

                    if (usuario != null)
                    {
                        textBoxUserName.Text = usuario.nom ?? "Nombre no encontrado";
                        textBoxUserEmail.Text = usuario.email ?? "Email no encontrado";
                    }
                    else
                    {
                        textBoxUserName.Text = "Usuario no encontrado";
                        textBoxUserEmail.Text = "Usuario no encontrado";
                    }

                    if (evento != null)
                    {
                        textBoxEventName.Text = evento.nom ?? "Evento no encontrado";
                    }
                    else
                    {
                        textBoxEventName.Text = "Evento no encontrado";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void buttonApplyFilter_Click(object sender, EventArgs e)
        {

            DateTime fromDate = dateTimePickerFrom.Value.Date;
            DateTime toDate = dateTimePickerTo.Value.Date.AddDays(1); // Incluir todo el día final

            var filteredReservations = (
                from r in Orm.bd.Reserves
                where r.data_reserva >= fromDate && r.data_reserva < toDate
                select r
            ).ToList();

            bindingSourceReserves.DataSource = filteredReservations;
            dataGridViewReservations.Refresh();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewReservations.CurrentRow != null)
            {
                var selectedReservation = dataGridViewReservations.CurrentRow.DataBoundItem as Reserves;

                if (selectedReservation != null)
                {
                    var confirmResult = MessageBox.Show(
                        $"¿Estás seguro de que deseas eliminar la reserva con ID {selectedReservation.reserva_id}?",
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (confirmResult == DialogResult.Yes)
                    {
                        ReservesOrm.delete(selectedReservation);

                        bindingSourceReserves.Remove(selectedReservation);
                        dataGridViewReservations.Refresh();
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor selecciona una reserva para eliminar.", "Sin selección");
            }
        }

        private void pictureBoxMenuIcon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

            string name = textBoxSearchUser.Text.Trim();

            if (!string.IsNullOrWhiteSpace(name))
            {
                var filtered = ReservesOrm.searchByUserName(name);
                bindingSourceReserves.DataSource = filtered;
                dataGridViewReservations.Refresh();
            }
            else
            {
                // Si no hay texto, mostrar todas las reservas
                bindingSourceReserves.DataSource = ReservesOrm.select();
                dataGridViewReservations.Refresh();
            }
        }
    }
}
