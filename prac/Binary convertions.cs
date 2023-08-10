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
    public partial class Binary_convertions : Form
    {
        public Binary_convertions()
        {
            InitializeComponent();
        }
        string val;
        private void btn_convert_Click(object sender, EventArgs e)
        {
            val = value.Text;
            if (from.Text == "binary")
            {
                for (int i = 0; i < val.Length; i++)
                {
                    if (val[i] != '1' && val[i] != '0')
                    {
                        MessageBox.Show("Enter the valid binary number");
                        val = "0";
                    }
                }
            }
            if (from.Text == "decimal" && to.Text == "binary")
                val = Convert.ToString(Convert.ToInt32(val, 10), 2);
            else if (from.Text == "decimal" && to.Text == "oct")
                val = Convert.ToString(Convert.ToInt32(val, 10), 16);
            else if (from.Text == "decimal" && to.Text == "hex")
                val = Convert.ToString(Convert.ToInt32(val, 10), 8);

            else if (from.Text == "binary" && to.Text == "decimal")
                val = Convert.ToString(Convert.ToInt32(val, 2), 10);
            else if (from.Text == "binary" && to.Text == "oct")
                val = Convert.ToString(Convert.ToInt32(val, 2), 16);
            else if (from.Text == "binary" && to.Text == "hex")
                val = Convert.ToString(Convert.ToInt32(val, 2), 8);

            else if (from.Text == "hex" && to.Text == "decimal")
                val = Convert.ToString(Convert.ToInt32(val, 8), 10);
            else if (from.Text == "hex" && to.Text == "binary")
                val = Convert.ToString(Convert.ToInt32(val, 8), 2);
            else if (from.Text == "hex" && to.Text == "oct")
                val = Convert.ToString(Convert.ToInt32(val, 8), 16);

            else if (from.Text == "oct" && to.Text == "decimal")
                val = Convert.ToString(Convert.ToInt32(val, 16), 10);
            else if (from.Text == "oct" && to.Text == "binary")
                val = Convert.ToString(Convert.ToInt32(val, 16), 2);
            else if (from.Text == "oct" && to.Text == "hex")
                val = Convert.ToString(Convert.ToInt32(val, 16), 8);

            lbl_convert_result.Text = val;
        }

    }
}
