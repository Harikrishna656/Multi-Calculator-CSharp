using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prac
{
    public partial class Multi_Calc : Form
    {
        public Multi_Calc()
        {
            InitializeComponent();
        }

        private void btn_simple_calc_Click(object sender, EventArgs e)
        {
            this.Hide();
            new cal().ShowDialog();
            this.Close();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_binary_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Binary_convertions().ShowDialog();
            this.Close();
        }
    }
}
