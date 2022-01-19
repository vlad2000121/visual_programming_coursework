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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int temperature = Convert.ToInt32(textBox1.Text);
            if (comboBox1.SelectedIndex == 0)
            {
                label1.Text = textBox1.Text;
                label2.Text = Convert.ToString(temperature - 273);
                label3.Text = Convert.ToString(1.8 * (temperature - 273) + 23);
            }
            if (comboBox1.SelectedIndex == 1)
            {
                label2.Text = textBox1.Text;
                label1.Text = Convert.ToString(temperature + 273);  
                label3.Text = Convert.ToString(1.8 * temperature + 23);
            }
            if (comboBox1.SelectedIndex == 2)
            {
                label3.Text = textBox1.Text;
                label1.Text = Convert.ToString(5 / 9 * (temperature - 32) + 273);
                label2.Text = Convert.ToString(5 / 9 * (temperature - 32));
            }
        }

        
    }
}
