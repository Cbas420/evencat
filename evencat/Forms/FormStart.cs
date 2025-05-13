using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace evencat
{
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Centrar elementos
            labelEvencat.Left = (panel1.Width - labelEvencat.Width) / 2;
            pictureBoxLogoWhite.Left = (panel1.Width - pictureBoxLogoWhite.Width) / 2;

            MakeRoundedMethods.makeRoundedBigButton(buttonNext, 35);
            buttonNext.BackColor = AppColors.purpleButton;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
    






