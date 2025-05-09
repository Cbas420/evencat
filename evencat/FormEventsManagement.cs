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
    }
}
