using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace curs_vp
{
    public partial class Calc_credit : UserControl
    {
        public Calc_credit()
        {
            InitializeComponent();
            
        }

        private void Calc_credit_Load(object sender, EventArgs e)
        {
            label3.Text = ПроцентBar1.Value.ToString();
            label4.Text = СрокBar2.Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (КредитButton.Checked == true && Сумма.Text!="")
            {
                double m = СрокBar2.Value;
                double m1 = 0 - m;
                double p = ПроцентBar1.Value;
                double p1 = p / (100 * m);
                double s = Convert.ToDouble(Сумма.Text);
                double k = 1 - (Math.Pow((1 + p1), m1));
                double plateg = (s * p1) / k; 
                double plateg1 = plateg * m;
                double plateg2 = plateg1 - s;

                if (s <= 0 || m == 0 || plateg <= 0 || plateg1 <= 0 || plateg2 <= 0)

                {
                    MessageBox.Show("Введены неверные данные! Возможно вы не указали период займа.", "Ошибка!");
                    Сумма.Text = "";
                    label6.Text = "";
                    label7.Text = "";
                    label8.Text = "";
                }
                else
                {
                    label6.Text = Convert.ToString(plateg);
                    label7.Text = Convert.ToString(plateg1);
                    label8.Text = Convert.ToString(plateg2);
                }
            }
            if (РассрочкаButton.Checked == true && Сумма.Text != "")
            {

            }


            }

        private void ПроцентBar1_Scroll(object sender, EventArgs e)
        {    
                label3.Text = ПроцентBar1.Value.ToString();       
        }

        private void КредитButton_CheckedChanged(object sender, EventArgs e)
        {
            ПроцентBar1.Minimum = 1;
            label3.Text = ПроцентBar1.Value.ToString();
        }

        private void РассрочкаButton_CheckedChanged(object sender, EventArgs e)
        {
            ПроцентBar1.Minimum = 0;
            label3.Text = ПроцентBar1.Value.ToString();
        }

        private void СрокBar2_Scroll(object sender, EventArgs e)
        {
            label4.Text = СрокBar2.Value.ToString();
        }
    }
}
