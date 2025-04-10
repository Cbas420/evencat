using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace evencat
{
    public partial class FormSelectOption : Form
    {
        private Form parentForm;




        public string SelectedOption { get; private set; }



        public FormSelectOption()
        {
            InitializeComponent();


        }

        private void FormSelectOption_Load(object sender, EventArgs e)
        {

            this.FormBorderStyle = FormBorderStyle.FixedToolWindow; // Eliminar bordes
            this.ControlBox = false; // Eliminar botones de minimizar/maximizar/cerrar
            //this.TopMost = true;  

            panelSelectButton.Left = (Width - panelSelectButton.Width) / 2;

        }

        private void button1_Click(object sender, EventArgs e)
        {


            this.DialogResult = DialogResult.OK;
            this.Close();
            SelectedOption = "Manage Spaces";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
            SelectedOption = "Manage Users";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
            SelectedOption = "Log Out";

        }





        // Hacer que el formulario se mueva junto con el padre

    }
}