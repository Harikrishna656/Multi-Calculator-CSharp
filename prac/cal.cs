using System;
using System.Windows.Forms;

namespace prac
{
    public partial class cal : Form
    {
        static int i,j,k,l,m;
        double FN = 0,SN=0;
        string check;
        char ch;

        public cal()
        {
            InitializeComponent();
        }
        private void btn_Qual_Click(object sender, EventArgs e)
        {
            if(text_FN.Text == "")
                text_FN.Text = "0";
            if (text_SN.Text == "")
                text_SN.Text = "0";
            if (text_OP.Text == "")
                text_OP.Text = "+";
            check = text_FN.Text;
            m = 0;
            for (int i = 0; i < check.Length; i++)
            {
                
                if (!Char.IsDigit(check[i]))
                {
                    if (check[i] == '.')
                    {
                        m=m+1;
                    }
                    
                    if (m > 1)
                    {
                        MessageBox.Show("Only one '.' allowed");
                        text_FN.Text = "0";
                        m = 0;
                        break;
                    }
                    if(check[i]!='.')
                    {
                        MessageBox.Show("Only Numbers allowed");
                        text_FN.Text = "0";
                        break;
                    }

                }
            }
            check = text_SN.Text;
            m = 0;
            for (int i = 0; i < check.Length; i++)
            {

                if (!Char.IsDigit(check[i]))
                {
                    if (check[i] == '.')
                    {
                        m = m + 1;
                    }

                    if (m > 1)
                    {
                        MessageBox.Show("Only one '.' allowed");
                        text_SN.Text = "0";
                        m = 0;
                        break;
                    }
                    if (check[i] != '.')
                    {
                        MessageBox.Show("Only Numbers allowed");
                        text_SN.Text = "0";
                        break;
                    }

                }
            }
            check = text_OP.Text;
            for (int i = 0; i < check.Length; i++)
            {
                ch = check[i];
               if ((!(ch =='+'))&& (!(ch == '-')) && !(ch == '/') && !(ch == '%') && !(ch == '^') && !(ch == '*'))
                {
                    MessageBox.Show("Only resitered operetions allowed");
                    l = 1;
                    break;
                }
            }
            if (l == 1)
            {
                text_OP.Text = "";
                l = 0;
            }        
            else
            {
                FN = double.Parse(text_FN.Text);
                SN = double.Parse(text_SN.Text);
                if (ch == '+')
                    lbl_Result.Text = (FN + SN).ToString();
                if (ch == '-')
                    lbl_Result.Text = (FN - SN).ToString();
                if (ch == '*')
                    lbl_Result.Text = (FN * SN).ToString();
                if (ch == '/')
                    lbl_Result.Text = (FN / SN).ToString();
                if (ch == '%')
                    lbl_Result.Text = (FN % SN).ToString();
                if (ch == '^')
                    lbl_Result.Text = (Math.Pow(FN, SN)).ToString();
                i = 0;
                j = 0;
                l = 0;
            }
        }
        private void btn_cr(object sender, EventArgs e)
        {
            text_FN.Text = "";
            text_SN.Text = "";
            text_OP.Text = "";
            lbl_Result.Text = "";
            i = 0;
            j = 0;
            k = 0;
        }
        private void btn_op_Click(object sender, EventArgs e)
        {
            text_FN.Text = lbl_Result.Text;
            text_OP.Text = "";
            text_SN.Text = "";
            lbl_Result.Text = "";
            k = 1;
        }
        public void key_press(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string N = button.Text;
            if (k == 0)
            {
                if (i == 1)
                {
                    if (N == ".")
                    {
                        if (j == 0)
                            text_SN.Text += N;
                        j = 1;
                    }
                    else
                    {
                        text_SN.Text += N;
                    }
                }

                if (N == "+" || N == "-" || N == "*" || N == "/" || N == "%" || N == "^")
                {
                    text_OP.Text = N;
                    i = 1;
                    j = 0;
                }
                if (i == 0)
                {
                    if (N == ".")
                    {
                        if (j == 0)
                            text_FN.Text += N;
                        j = 1;
                    }
                    else
                    {
                        text_FN.Text += N;
                    }
                }
            }
            else
            {
                if (i == 1)
                {
                    if (N == ".")
                    {
                        if (j == 0)
                            text_SN.Text += N;
                        j = 1;
                    }
                    else
                    {
                        text_SN.Text += N;
                    }
                }
                if (N == "+" || N == "-" || N == "*" || N == "/" || N == "%" || N == "^")
                {
                    text_OP.Text = N;
                    i = 1;
                    j = 0;
                }
            }
        }
    }
}
