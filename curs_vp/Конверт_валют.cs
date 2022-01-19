using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace curs_vp
{
    public partial class Конверт_валют : UserControl
    {
        public Конверт_валют()
        {
            InitializeComponent();
        }



        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)

        {

            if (comboBox1.SelectedIndex == comboBox2.SelectedIndex)
            {
                textBox1.Hide();
                textBox2.Hide();
            }
            else {
                textBox1.Show();
                textBox2.Show();
            }
                
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == comboBox2.SelectedIndex)
            {
                textBox1.Hide();
                textBox2.Hide();
            }
            else
            {
                textBox1.Show();
                textBox2.Show();
            }
        }
        private void Конверт_валют_Load(object sender, EventArgs e)
        {
         
      

        }



      

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 1)
            {
                WebClient client = new WebClient();
                string theDate = dateTimePicker1.Value.ToString("dd/MM/yyyy");
                var xml = client.DownloadString("http://www.cbr.ru/scripts/XML_daily.asp?date_req=" + theDate);
                XDocument xdoc = XDocument.Parse(xml);
                var el = xdoc.Element("ValCurs").Elements("Valute");
                string curs_evro = el.Where(x => x.Attribute("ID").Value == "R01239").Select(x => x.Element("Value").Value).FirstOrDefault();
                double n = Convert.ToDouble(Convert.ToString(textBox1.Text));
               
                textBox2.Text = Convert.ToString(n / Convert.ToDouble(curs_evro));
               
            }
            else if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 2)
            {
                WebClient client = new WebClient();
                string theDate = dateTimePicker1.Value.ToString("dd/MM/yyyy");
                var xml = client.DownloadString("http://www.cbr.ru/scripts/XML_daily.asp?date_req=" + theDate);
                XDocument xdoc = XDocument.Parse(xml);
                var el = xdoc.Element("ValCurs").Elements("Valute");
                string curs_usd = el.Where(x => x.Attribute("ID").Value == "R01235").Select(x => x.Element("Value").Value).FirstOrDefault();
                double n = Convert.ToDouble(Convert.ToString(textBox1.Text));
                textBox2.Text = Convert.ToString(n / Convert.ToDouble(curs_usd));

            }
            else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 2)
            {
                WebClient client = new WebClient();
                string theDate = dateTimePicker1.Value.ToString("dd/MM/yyyy");
                var xml = client.DownloadString("http://www.cbr.ru/scripts/XML_daily.asp?date_req=" + theDate);
                XDocument xdoc = XDocument.Parse(xml);
                var el = xdoc.Element("ValCurs").Elements("Valute");
                string curs_usd = el.Where(x => x.Attribute("ID").Value == "R01235").Select(x => x.Element("Value").Value).FirstOrDefault();
                string curs_evro = el.Where(x => x.Attribute("ID").Value == "R01239").Select(x => x.Element("Value").Value).FirstOrDefault();
                double n = Convert.ToDouble(Convert.ToString(textBox1.Text));
                
                textBox2.Text = Convert.ToString((Convert.ToDouble(curs_evro) * n) / Convert.ToDouble(curs_usd));
            }
            else if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 1)
            {
                WebClient client = new WebClient();
                string theDate = dateTimePicker1.Value.ToString("dd/MM/yyyy");
                var xml = client.DownloadString("http://www.cbr.ru/scripts/XML_daily.asp?date_req=" + theDate);
                XDocument xdoc = XDocument.Parse(xml);
                var el = xdoc.Element("ValCurs").Elements("Valute");
                string curs_usd = el.Where(x => x.Attribute("ID").Value == "R01235").Select(x => x.Element("Value").Value).FirstOrDefault();
                string curs_evro = el.Where(x => x.Attribute("ID").Value == "R01239").Select(x => x.Element("Value").Value).FirstOrDefault();
                double n = Convert.ToDouble(textBox1.Text);
               
                textBox2.Text = Convert.ToString((Convert.ToDouble(curs_usd) * n) / Convert.ToDouble(curs_evro));
            }
            else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 0)
            {
                WebClient client = new WebClient();
                string theDate = dateTimePicker1.Value.ToString("dd/MM/yyyy");
                var xml = client.DownloadString("http://www.cbr.ru/scripts/XML_daily.asp?date_req=" + theDate);
                XDocument xdoc = XDocument.Parse(xml);
                var el = xdoc.Element("ValCurs").Elements("Valute");      
                string curs_evro = el.Where(x => x.Attribute("ID").Value == "R01239").Select(x => x.Element("Value").Value).FirstOrDefault();
                double n = Convert.ToDouble(textBox1.Text);
                
                textBox2.Text = Convert.ToString(Convert.ToDouble(curs_evro) * n);
            }
            else if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 0)
            {
                WebClient client = new WebClient();
                string theDate = dateTimePicker1.Value.ToString("dd/MM/yyyy");
                var xml = client.DownloadString("http://www.cbr.ru/scripts/XML_daily.asp?date_req=" + theDate);
                XDocument xdoc = XDocument.Parse(xml);
                var el = xdoc.Element("ValCurs").Elements("Valute");
                string curs_usd = el.Where(x => x.Attribute("ID").Value == "R01235").Select(x => x.Element("Value").Value).FirstOrDefault();
                
                double n = Convert.ToDouble(textBox1.Text);
                textBox2.Text = Convert.ToString(Convert.ToDouble(curs_usd) * n);
               
            }
        }  
    }
}
