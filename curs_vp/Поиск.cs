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
    public partial class Поиск : Form
    {
        string buffer;
        
        List<Stationary> stat = new List<Stationary>();
        List<Portable> port = new List<Portable>();
        List<PlayStation> playStat = new List<PlayStation>();
        List<Xbox> xboxs1 = new List<Xbox>();
        public Поиск(Form form1, object sender, EventArgs e, List<Portable> portables, List<Stationary> stationaries, List<PlayStation> playStations, List<Xbox> xboxes)
        {
            InitializeComponent();
            stat = stationaries;
            port = portables;
            playStat = playStations;
            xboxs1 = xboxes;

            textBox1.ContextMenuStrip = contextMenuStrip1;
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                listBox1.Items.Clear();
                foreach (Portable h in port)
                {
                    if (textBox1.Text == h.CompName)
                    {
                        listBox1.Items.Add(Portable.TextOut(h));
                    }
                    else if (textBox1.Text == h.CompNameCompany)
                    {
                        listBox1.Items.Add(Portable.TextOut(h));
                    }
                    else if (textBox1.Text == h.CompYear)
                    {
                        listBox1.Items.Add(Portable.TextOut(h));
                    }
                }
                foreach (Stationary h in stat)
                {
                    if (textBox1.Text == h.CompName)
                    {
                        listBox1.Items.Add(Stationary.TextOut(h));
                    }
                    else if (textBox1.Text == h.CompNameCompany)
                    {
                        listBox1.Items.Add(Stationary.TextOut(h));
                    }
                    else if (textBox1.Text == h.CompYear)
                    {
                        listBox1.Items.Add(Stationary.TextOut(h));
                    }
                }
                foreach (Xbox h in xboxs1)
                {
                    if (textBox1.Text == h.CompName)
                    {
                        listBox1.Items.Add(Xbox.TextOut(h));
                    }
                    else if (textBox1.Text == h.CompNameCompany)
                    {
                        listBox1.Items.Add(Xbox.TextOut(h));
                    }
                    else if (textBox1.Text == h.CompYear)
                    {
                        listBox1.Items.Add(Xbox.TextOut(h));
                    }
                }
                foreach (PlayStation h in playStat)
                {
                    if (textBox1.Text == h.CompName)
                    {
                        listBox1.Items.Add(PlayStation.TextOut(h));
                    }
                    else if (textBox1.Text == h.CompNameCompany)
                    {
                        listBox1.Items.Add(PlayStation.TextOut(h));
                    }
                    else if (textBox1.Text == h.CompYear)
                    {
                        listBox1.Items.Add(PlayStation.TextOut(h));
                    }
                }
            }
            if (listBox1.Items.Count == 0)
            {
                button1.BackColor = Color.Red;
                button1.Text = "Не найдено";
            }
            else
            {
                button1.Text = "Поиск";
                button1.BackColor = Color.Transparent;
            }
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {         
            buffer = textBox1.SelectedText;
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {         
                textBox1.Paste(buffer);
        }

        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buffer = textBox1.SelectedText;
            textBox1.Text = "";
          
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void вырезатьToolStripButton_Click(object sender, EventArgs e)
        {
            buffer = textBox1.SelectedText;
            textBox1.Text = "";
        }

        private void копироватьToolStripButton_Click(object sender, EventArgs e)
        {
            buffer = textBox1.SelectedText;
        }

        private void вставкаToolStripButton_Click(object sender, EventArgs e)
        {
            textBox1.Paste(buffer);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
