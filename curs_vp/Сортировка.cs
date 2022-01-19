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
    public partial class Сортировка : Form
    {
        List<Stationary> stat = new List<Stationary>();
        List<Portable> port = new List<Portable>();
        List<PlayStation> playStat = new List<PlayStation>();
        List<Xbox> xboxs1 = new List<Xbox>();
        public Сортировка(Form form1, object sender, EventArgs e, List<Portable> portables, List<Stationary> stationaries, List<PlayStation> playStations, List<Xbox> xboxes)
        {
            InitializeComponent();
            stat = stationaries;
            port = portables;
            playStat = playStations;
            xboxs1 = xboxes;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    port.Sort(Portable.SortCompany);
                    stat.Sort(Stationary.SortCompany);
                    listBox2.Items.Clear();
                    foreach (Portable h in port)
                    {
                        listBox2.Items.Add(Portable.TextOut(h));
                    }
                    foreach (Stationary s in stat)
                    {
                        listBox2.Items.Add(Stationary.TextOut(s));
                    }
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    port.Sort(Portable.SortYear);
                    stat.Sort(Stationary.SortYear);
                    listBox2.Items.Clear();
                    foreach (Portable h in port)
                    {
                        listBox2.Items.Add(Portable.TextOut(h));
                    }
                    foreach (Stationary s in stat)
                    {
                        listBox2.Items.Add(Stationary.TextOut(s));
                    }
                }
            }
            else
            {
                if (radioButton2.Checked)
                {
                    if (comboBox1.SelectedIndex == 0)
                    {
                        xboxs1.Sort(Xbox.SortCompany);
                        playStat.Sort(PlayStation.SortCompany);
                        listBox2.Items.Clear();
                        foreach (Xbox h in xboxs1)
                        {
                            listBox2.Items.Add(Xbox.TextOut(h));
                        }
                        foreach (PlayStation s in playStat)
                        {
                            listBox2.Items.Add(PlayStation.TextOut(s));
                        }
                    }
                    else if (comboBox1.SelectedIndex == 1)
                    {
                        xboxs1.Sort(Xbox.SortYear);
                        playStat.Sort(PlayStation.SortYear);
                        listBox2.Items.Clear();
                        foreach (Xbox h in xboxs1)
                        {
                            listBox2.Items.Add(Xbox.TextOut(h));
                        }
                        foreach (PlayStation s in playStat)
                        {
                            listBox2.Items.Add(PlayStation.TextOut(s));
                        }
                    }
                }
            }
        }

   
    }
}
