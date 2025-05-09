using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }
    }
}
