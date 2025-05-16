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
    public partial class FormCreateSpace : Form
    {
        public FormCreateSpace()
        {
            InitializeComponent();

            MakeRoundedMethods.makeRoundeSmallButton(buttonCreateSpace, 25, Color.White, AppColors.purpleButton);
            MakeRoundedMethods.MakeRoundedComboBox(comboBoxSeatType, 13, "Assigned seats?");
            MakeRoundedMethods.makeRoundedTextBox(textBoxName, 35, "Name");
            MakeRoundedMethods.makeRoundedTextBox(textBoxLocation, 35, "Location");
            MakeRoundedMethods.makeRoundedTextBox(textBoxSquareMeters, 35, "Square meters");
            MakeRoundedMethods.makeRoundedTextBox(textBoxNumberSeats, 35, "Number of seats");
        }

        private void buttonCreateSpace_Click(object sender, EventArgs e)
        {
            try
            {
                string nom = textBoxName.Text.Trim();
                string ubicacio = textBoxLocation.Text.Trim();

                if (string.IsNullOrWhiteSpace(nom) || string.IsNullOrWhiteSpace(ubicacio))
                {
                    MessageBox.Show("Name and Location are required.");
                    return;
                }

                int metresQuadrats = int.Parse(textBoxSquareMeters.Text);

                if (metresQuadrats <= 0)
                {
                    MessageBox.Show("Square meters must be greater than 0.");
                    return;
                }

                int? cadiresFixes = null;
                if (comboBoxSeatType.SelectedItem?.ToString() == "Yes")
                {
                    cadiresFixes = int.Parse(textBoxNumberSeats.Text);
                }

                Espais nouEspai = new Espais
                {
                    nom = nom,
                    ubicacio = ubicacio,
                    metres_quadrats = metresQuadrats,
                    cadires_fixes = cadiresFixes
                };

                EspaisOrm.insert(nouEspai);

                MessageBox.Show("Espai created successfully!");


                this.DialogResult = DialogResult.OK;

                this.Close();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message);
            }
        }

        private void comboBoxSeatType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSeatType.SelectedItem.ToString() == "Yes")
            {
                textBoxNumberSeats.Enabled = true;
            }
            else if (comboBoxSeatType.SelectedItem.ToString() == "No")
            {
                textBoxNumberSeats.Enabled = false;
                textBoxNumberSeats.Text = "";
            }
        }
    }
}
