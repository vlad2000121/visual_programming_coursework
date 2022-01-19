using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace curs_vp
{
    public partial class Добавить : Form
    {
       
        List<Stationary> stat = new List<Stationary>();
        List<Portable> port = new List<Portable>();
        List<PlayStation> playStat = new List<PlayStation>();
        List<Xbox> xboxs1 = new List<Xbox>();
        bool flag = false;
        
        public Добавить(Form form1, object sender, EventArgs e, List<Portable> portables, List<Stationary> stationaries, List<PlayStation> playStations, List<Xbox> xboxes)
        {
            InitializeComponent();
            stat = stationaries;
            port = portables;
            playStat = playStations;
            xboxs1 = xboxes;
            if (stat.Count >= stationaries.Count)
            { stationaries = stat; }

            if (port.Count > portables.Count)
            { portables = port; }

        }



        private void button2_Click(object sender, EventArgs e)
     
        {

            if ((textBox1.Text != "") && (textBox2.Text != "") && (textBox3.Text != "") && (textBox4.Text != "") && (textBox5.Text != "") && (textBox6.Text != "") && (textBox7.Text != "") && (textBox8.Text != ""))
            {
                if (treeView1.SelectedNode.Text == "Портативные компьютеры")
                {
                    try
                    {
                        int result;
                        result = Convert.ToInt32(textBox2.Text);
                        result = Convert.ToInt32(textBox3.Text);


                        result = Convert.ToInt32(textBox4.Text);
                        result = Convert.ToInt32(textBox5.Text);

                        
                        port.Add(new Portable(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, treeView1.SelectedNode.Text));
                    
                        treeView1.SelectedNode.Nodes.Add(textBox1.Text);
                        treeView1.SelectedNode.LastNode.Tag = port.Last();
                        treeView1.SelectedNode.LastNode.Name = textBox1.Text;
                    }

                    catch (Exception)
                    {
                        MessageBox.Show("Введены неверные данные!", "Ошибка!");
                    }
                   

                    /////
                    string name = "doc.xml";

                    XmlSerializer xml = new XmlSerializer(typeof(List<Portable>));

                        using (FileStream fs = new FileStream(name, FileMode.Create))
                        {
                            xml.Serialize(fs, port);
                        }
                   

                }
                else if (treeView1.SelectedNode.Text == "Stationary")
                {
                    try
                    {
                        int result;
                        result = Convert.ToInt32(textBox2.Text);
                        result = Convert.ToInt32(textBox3.Text);
                        result = Convert.ToInt32(textBox4.Text);
                        result = Convert.ToInt32(textBox5.Text);


                        stat.Add(new Stationary(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, treeView1.SelectedNode.Text));
                        treeView1.SelectedNode.Nodes.Add(textBox1.Text);
                        treeView1.SelectedNode.LastNode.Tag = stat.Last();
                        treeView1.SelectedNode.LastNode.Name = textBox1.Text;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Введены неверные данные!", "Ошибка!");
                    }
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";


                }
                else if (treeView1.SelectedNode.Text == "playStations")
                {
                    try
                    {
                        int result;
                        result = Convert.ToInt32(textBox2.Text);
                        result = Convert.ToInt32(textBox3.Text);
                        result = Convert.ToInt32(textBox4.Text);
                        result = Convert.ToInt32(textBox5.Text);
                        result = Convert.ToInt32(textBox6.Text);
                        playStat.Add(new PlayStation(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, treeView1.SelectedNode.Text));


                        treeView1.SelectedNode.Nodes.Add(textBox1.Text);
                        treeView1.SelectedNode.LastNode.Tag = playStat.Last();
                        treeView1.SelectedNode.LastNode.Name = textBox1.Text;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Введены неверные данные!", "Ошибка!");
                    }
                    textBox1.Text = "Фирма производитель";
                    textBox2.Text = "Объем(ГБ)";
                    textBox3.Text = "Тип памяти(DDR)";
                    textBox4.Text = "Тактовая частота(МГц)";
                    textBox5.Text = "Пропускная способность(МБ/с)";
                    textBox6.Text = "Цена(руб)";
                }
                else if (treeView1.SelectedNode.Text == "DIMM")
                {
                    try
                    {
                        int result;
                        result = Convert.ToInt32(textBox2.Text);
                        result = Convert.ToInt32(textBox3.Text);
                        result = Convert.ToInt32(textBox4.Text);
                        result = Convert.ToInt32(textBox5.Text);
                        result = Convert.ToInt32(textBox6.Text);
                        xboxs1.Add(new Xbox(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, treeView1.SelectedNode.Text));

                        treeView1.SelectedNode.Nodes.Add(textBox1.Text);
                        treeView1.SelectedNode.LastNode.Tag = xboxs1.Last();
                        treeView1.SelectedNode.LastNode.Name = textBox1.Text;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Введены неверные данные!", "Ошибка!");
                    }
                    textBox1.Text = "Фирма производитель";
                    textBox2.Text = "Объем(ГБ)";
                    textBox3.Text = "Тип памяти(DDR)";
                    textBox4.Text = "Тактовая частота(МГц)";
                    textBox5.Text = "Пропускная способность(МБ/с)";
                    textBox6.Text = "Цена(руб)";

                }
            }


        }

        private void Добавить_Load(object sender, EventArgs e)
        {
            TreeNode node = new TreeNode("Иерархия компьютеров");        // Добавляю сразу 3 класса от 1 до 3
            node.Nodes.Add("Настольные компьютеры");
            node.Nodes[0].Nodes.Add("Портативные компьютеры");
            node.Nodes[0].Nodes.Add("Стационарные компьютеры");
            node.Nodes.Add("Игровые консоли");
            node.Nodes[1].Nodes.Add("Xbox");
            node.Nodes[1].Nodes.Add("PS");
            treeView1.Nodes.Add(node);

        

        }

        private void Добавить_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}



