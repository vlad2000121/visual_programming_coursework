using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml;
using System.Drawing;


using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace curs_vp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        List<Stationary> stationarys = new List<Stationary>();
        List<Portable> portables = new List<Portable>();
        List<PlayStation> playStations = new List<PlayStation>();
        List<Xbox> xboxs = new List<Xbox>();



        private void button1_Click(object sender, EventArgs e)
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

        //private void button2_Click(object sender, EventArgs e)
        //{
        //TreeNode node = new TreeNode("Иерархия компьютеров");        // Добавляю сразу 3 класса от 1 до 3
        //node.Nodes.Add("Иерархия компьютеров");
        //node.Nodes[0].Nodes.Add("Иерархия компьютеров");
        //treeView1.Nodes.Add(node);
        //    //treeView1.SelectedNode.Text = "Накопители";
        //}



        ToolTip toolTip = new ToolTip();


        public Button GetButton()
        {
            return button2;
        }
        private void Form1_Load(object sender, EventArgs e)

        {
            foreach (Control c in tabPage1.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    c.Hide();
                }
            }
            foreach (Control c in tabPage2.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    c.Hide();
                }
            }
            button2.Hide();
            tabControl1.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if ((textBox1.Text != "") && (textBox2.Text != "") && (textBox3.Text != "") && (textBox4.Text!= "") && (textBox5.Text != "") && (textBox6.Text != ""))
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
                       
                        portables.Add(new Portable(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, treeView1.SelectedNode.Text));
                      
                        treeView1.SelectedNode.Nodes.Add(textBox1.Text);
                        treeView1.SelectedNode.LastNode.Tag = portables.Last();
                        treeView1.SelectedNode.LastNode.Name = textBox1.Text;
                    }

                    catch (Exception)
                    {
                        MessageBox.Show("Введены неверные данные!", "Ошибка!");
                    }
                    textBox1.Text = "Фирма производитель";
                    textBox2.Text = "Объем(ГБ)";
                    textBox3.Text = "Скорость записи/чтения(МБ/С)";
                    textBox4.Text = "Объем буферной памяти(МБ)";
                    textBox5.Text = "Цена(руб)";
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


                        stationarys.Add(new Stationary(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, treeView1.SelectedNode.Text));
                        treeView1.SelectedNode.Nodes.Add(textBox1.Text);
                        treeView1.SelectedNode.LastNode.Tag = stationarys.Last();
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
                        playStations.Add(new PlayStation(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, treeView1.SelectedNode.Text));


                        treeView1.SelectedNode.Nodes.Add(textBox1.Text);
                        treeView1.SelectedNode.LastNode.Tag = playStations.Last();
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
                        xboxs.Add(new Xbox(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, treeView1.SelectedNode.Text));

                        treeView1.SelectedNode.Nodes.Add(textBox1.Text);
                        treeView1.SelectedNode.LastNode.Tag = xboxs.Last();
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










        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            {
                if (treeView1.SelectedNode.Text == "Портативные компьютеры" || treeView1.SelectedNode.Text == "SSD")
                {
                    //if (treeView1.SelectedNode.Text == "HDD")
                    //{
                    //    pictureBox1.Image = Properties.Resources.hard_disk;
                    //}
                    //else if (treeView1.SelectedNode.Text == "SSD")
                    //{
                    //    pictureBox1.Image = Properties.Resources.SSD;
                    //}
                    tabControl1.Show();
                    button2.Show();
                    textBox1.Show();
                    textBox2.Show();
                    textBox3.Show();
                    textBox4.Show();
                    textBox5.Show();
                    textBox6.Show();
                    textBox7.Show();
                    textBox8.Show();
                    //textBox9.Show();
                    //textBox10.Show();
                    //textBox11.Show();
                    //textBox12.Hide();
                    //textBox13.Show();
                    //textBox14.Show();
                    //textBox15.Show();
                    //textBox16.Show();
                    //textBox17.Show();
                    //textBox18.Hide();

                }
                else if (treeView1.SelectedNode.Text == "Portable" || treeView1.SelectedNode.Text == "DIMM")
                {
                    //if (treeView1.SelectedNode.Text == "SO-DIMM")
                    //{
                    //    pictureBox1.Image = Properties.Resources.;
                    //}
                    //else if (treeView1.SelectedNode.Text == "DIMM")
                    //{
                    //    pictureBox1.Image = Properties.Resources.DIMM;
                    //}
                    tabControl1.Show();
                    button2.Show();
                    textBox1.Show();
                    textBox2.Show();
                    textBox3.Show();
                    textBox4.Show();
                    textBox5.Show();
                    textBox6.Show();
                    textBox7.Show();
                    textBox8.Show();
                    //textBox9.Show();
                    //textBox10.Show();
                    //textBox11.Show();
                    //textBox12.Show();
                    //textBox13.Show();
                    //textBox14.Show();
                    //textBox15.Show();
                    //textBox16.Show();
                    //textBox17.Show();
                    //textBox18.Show();
                    textBox1.Text = "Фирма производитель";
                    textBox2.Text = "Объем(ГБ)";
                    textBox3.Text = "Тип памяти(DDR)";
                    textBox4.Text = "Тактовая частота(МГц)";
                    textBox5.Text = "Пропускная способность(МБ/с)";
                    textBox6.Text = "Цена(руб)";
                }
                // else if (treeView1.SelectedNode.Text == "USB 2.0" || treeView1.SelectedNode.Text == "USB 3.0"
                //|| treeView1.SelectedNode.Text == "USB 3.1/Type-C")
                // {
                //     if (treeView1.SelectedNode.Text == "USB 2.0")
                //     {
                //         pictureBox1.Image = Properties.Resources.USB_2_0;
                //     }
                //     else if (treeView1.SelectedNode.Text == "USB 3.0")
                //     {
                //         pictureBox1.Image = Properties.Resources.USB_3_0;
                //     }
                //     else if (treeView1.SelectedNode.Text == "USB 3.1/Type-C")
                //     {
                //         pictureBox1.Image = Properties.Resources.USB_3_1;
                //     }
                //     tabControl1.Show();
                //     button_add.Show();
                //     textBox1.Hide();
                //     textBox2.Hide();
                //     textBox3.Show();
                //     textBox4.Show();
                //     textBox5.Show();
                //     textBox6.Hide();
                //     textBox7.Hide();
                //     textBox8.Hide();
                //     textBox9.Show();
                //     textBox10.Show();
                //     textBox11.Show();
                //     textBox12.Hide();
                //     textBox13.Hide();
                //     textBox14.Hide();
                //     textBox15.Show();
                //     textBox16.Show();
                //     textBox17.Show();
                //     textBox18.Hide();
                //     textBox1.Text = "NAN";


                //     textBox2.Text = "NAN";
                //     textBox3.Text = "Фирма производитель";
                //     textBox4.Text = "Объем(ГБ)";
                //     textBox5.Text = "Цена(руб)";
                //     textBox6.Text = "NAN";
                // }
                //    if (treeView1.SelectedNode.Level == 3)
                //    {
                //        button_Del.Enabled = true;
                //        foreach (var item in hdd)
                //        {
                //            if (item == treeView1.SelectedNode.Tag)
                //            {
                //                textBox7.Text = item.Production_firm;
                //                textBox8.Text = item.Size;
                //                textBox9.Text = item.WR_speed;
                //                textBox10.Text = item.Buff_size;
                //                textBox11.Text = item.Price;
                //            }
                //        }
                //        foreach (var item in ssd)
                //        {
                //            if (item == treeView1.SelectedNode.Tag)
                //            {
                //                textBox7.Text = item.Production_firm;
                //                textBox8.Text = item.Size;
                //                textBox9.Text = item.WR_speed;
                //                textBox10.Text = item.Buff_size;
                //                textBox11.Text = item.Price;
                //            }
                //        }
                //        foreach (var item in sodimm)
                //        {
                //            if (item == treeView1.SelectedNode.Tag)
                //            {
                //                textBox7.Text = item.Production_firm;
                //                textBox8.Text = item.Size;
                //                textBox9.Text = item.DDR_num;
                //                textBox10.Text = item.Clock_Freq;
                //                textBox11.Text = item.RAM_rate;
                //                textBox12.Text = item.Price;
                //            }
                //        }
                //        foreach (var item in dimm)
                //        {
                //            if (item == treeView1.SelectedNode.Tag)
                //            {
                //                textBox7.Text = item.Production_firm;
                //                textBox8.Text = item.Size;
                //                textBox9.Text = item.DDR_num;
                //                textBox10.Text = item.Clock_Freq;
                //                textBox11.Text = item.RAM_rate;
                //                textBox12.Text = item.Price;
                //            }
                //        }
                //        foreach (var item in usb2)
                //        {
                //            if (item == treeView1.SelectedNode.Tag)
                //            {
                //                textBox9.Text = item.Production_firm;
                //                textBox10.Text = item.Size;
                //                textBox11.Text = item.Price;
                //            }
                //        }
                //        foreach (var item in usb3)
                //        {
                //            if (item == treeView1.SelectedNode.Tag)
                //            {
                //                textBox9.Text = item.Production_firm;
                //                textBox10.Text = item.Size;
                //                textBox11.Text = item.Price;
                //            }
                //        }
                //        foreach (var item in usb_c)
                //        {
                //            if (item == treeView1.SelectedNode.Tag)
                //            {
                //                textBox9.Text = item.Production_firm;
                //                textBox10.Text = item.Size;
                //                textBox11.Text = item.Price;
                //            }
                //        }
                //    }
                //    else
                //    {
                //        button_Del.Enabled = false;
                //    }
                //    if (treeView1.SelectedNode.Level != 3)
                //    {
                //        foreach (Control item in tabPage2.Controls)
                //        {
                //            if (item.GetType() == typeof(TextBox))
                //            {
                //                item.Text = "";
                //            }
                //        }
                //    }
                //}
            }
        }
        //    private void textBox1_TextChanged(object sender, EventArgs e)
        //    {
        //        if (textBox1.Text == "Фирма производитель")
        //        {
        //            textBox1.Clear();
        //        }
        //    }
        //private void textBox2_TextChanged(object sender, EventArgs e)
        //{
        //        if (textBox2.Text == "Объем(ГБ)")
        //        {
        //            textBox2.Clear();
        //        }
        //    }
        //private void textBox3_TextChanged(object sender, EventArgs e)
        //{
        //        if ((textBox3.Text == "Скорость записи/чтения(МБ/С)") || (textBox3.Text == "Тип памяти(DDR)") || (textBox3.Text == "Фирма производитель"))
        //    {
        //            textBox3.Clear();
        //        }
        //    }
        //private void textBox4_TextChanged(object sender, EventArgs e)
        //{
        //        if ((textBox4.Text == "Объем буферной памяти(МБ)") || (textBox4.Text == "Тактовая частота(МГц)") || (textBox4.Text == "Объем(ГБ)"))
        //            {
        //            textBox4.Clear();
        //        }
        //    }
        //private void textBox5_TextChanged(object sender, EventArgs e)
        //{
        //        if ((textBox5.Text == "Цена(руб)") || (textBox5.Text == "Пропускная способность(МБ/с)"))
        //        {
        //            textBox5.Clear();
        //        }
        //    }
        //private void textBox6_TextChanged(object sender, EventArgs e)
        //{
        //        if (textBox6.Text == "Цена(руб)")
        //        {
        //            textBox6.Clear();
        //        }
        //    }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Фирма производитель";
            textBox2.Text = "Объем(ГБ)";
            textBox3.Text = "Скорость записи/чтения(МБ/С)";
            textBox4.Text = "Объем буферной памяти(МБ)";
            textBox5.Text = "Цена(руб)";
        }

        private void treeView1_AfterSelect_1(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode.Text == "Портативные компьютеры" || treeView1.SelectedNode.Text == "SSD")
            {
                if (treeView1.SelectedNode.Text == "Портативные компьютеры")
                {
                    pictureBox1.Image = Image.FromFile(@"C:\Users\1\Desktop\вп\Без названия.jpg");
                }
                //else if (treeView1.SelectedNode.Text == "SSD")
                //{
                //    pictureBox1.Image = Properties.Resources.SSD;
                //}
                tabControl1.Show();                 //Show отображать элемент    Hide -скрыть
                button2.Show();
                textBox1.Show();
                textBox2.Show();
                textBox3.Show();
                textBox4.Show();
                textBox5.Show();
                textBox6.Show();
                textBox7.Show();
                textBox8.Show();
                //textBox9.Show();
                //textBox10.Show();
                //textBox11.Show();
                //textBox12.Hide();
                //textBox13.Show();
                //textBox14.Show();
                //textBox15.Show();
                //textBox16.Show();
                //textBox17.Show();
                //textBox18.Hide();

            }


            if (treeView1.SelectedNode.Level == 3)
            {
                if (treeView1.SelectedNode.Parent.Text == "Портативные компьютеры")
                {

                    foreach (var item in portables)
                    {
                        if (item == treeView1.SelectedNode.Tag)
                        {

                            label2.Text = item.CompNameCompany;
                            label3.Text = item.CompName;
                            label4.Text = item.CompPrice;
                            label5.Text = item.desktopProc;
                        }
                    }
                }
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
           
                if (treeView1.SelectedNode.Level == 3)
                {
                    if (treeView1.SelectedNode.Parent.Text == "Портативные компьютеры")
                    {
                    foreach (var item in portables)
                    {
                        if (item == treeView1.SelectedNode.Tag)
                        {
                            treeView1.SelectedNode.Remove();
                            portables.Remove(item);
                            foreach (Control c in tabPage2.Controls)
                            {
                                if (c.GetType() == typeof(TextBox))
                                {
                                    c.Text = "";
                                }
                            }
                            break;
                        }
                    }
                    }
                }
            
        }


        private void treeView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            TreeNode node = treeView1.GetNodeAt(e.Location);
            if (treeView1.SelectedNode.Level == 3)
            {
                if (treeView1.SelectedNode.Parent.Text == "Портативные компьютеры")
                {
                    foreach (Portable h in portables)
                    {
                        if (h == treeView1.SelectedNode.Tag)
                        {
                     
                            MessageBox.Show(Portable.TextOut(h), "Характеристики");
                            break;
                        }
                    }
                }

            }
        }

      

        private void button4_Click(object sender, EventArgs e)
        {
            
                if (textBox9.Text != "")
                {
                    listBox1.Items.Clear();
                    foreach (Portable h in portables)
                    {
                        if (textBox9.Text == h.CompName)
                        {
                            listBox1.Items.Add(Portable.TextOut(h));
                        }
                        else if (textBox9.Text == h.CompNameCompany)
                        {
                            listBox1.Items.Add(Portable.TextOut(h));
                        }
                        else if (textBox9.Text == h.CompYear)
                        {
                            listBox1.Items.Add(Portable.TextOut(h));
                        }
                    }
                }
                if (listBox1.Items.Count == 0)
                {
                    Поиск.BackColor = Color.Red;
                }
                else
               {
                 Поиск.BackColor = Color.Transparent;
               }
            }
    

        private void сохрToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SaveFileDialog Load = new SaveFileDialog();
            Load.DefaultExt = "xml";
            Load.Filter = "xml files (*.xml;)| *.xml";
            string name = "";
            if (treeView1.SelectedNode.Text == "Портативные компьютеры")
            {
                if (Load.ShowDialog() == DialogResult.OK)
                {
                    name = Load.FileName;
                }
                XmlSerializer xml = new XmlSerializer(typeof(List<Portable>));

                using (FileStream fs = new FileStream(name, FileMode.Create))
                {
                    xml.Serialize(fs, portables);
                }
            }


        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.Text == "Портативные компьютеры" && openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string str = openFileDialog1.FileName;
                FileStream FileStream = new FileStream(str, FileMode.Open, FileAccess.Read);
                XmlReader xmlReader = new XmlTextReader(FileStream);
                XmlSerializer serializer = new XmlSerializer(typeof(List<Portable>));
                if (serializer.CanDeserialize(xmlReader))
                {
                    List<Portable> doc = (List<Portable>)serializer.Deserialize(xmlReader);
                    FileStream.Close();
                    portables.AddRange(doc);
                    foreach (var item in doc)
                    {

                        treeView1.SelectedNode.Nodes.Add(item.CompName);
                        treeView1.SelectedNode.LastNode.Tag = item;
                        treeView1.SelectedNode.LastNode.Name = item.CompName;
                    }
                    doc.Clear();
                }
            }
        }


        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            if (treeView1.SelectedNode.Text == "Портативные компьютеры")
            {
                string[] fileName = (string[])e.Data.GetData(DataFormats.FileDrop);


                foreach (string str in fileName)

                {
                    FileStream FileStream = new FileStream(str, FileMode.Open, FileAccess.Read);
                    XmlReader xmlReader = new XmlTextReader(FileStream);
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Portable>));
                    if (serializer.CanDeserialize(xmlReader))
                    {
                        List<Portable> doc = (List<Portable>)serializer.Deserialize(xmlReader);
                        FileStream.Close();
                        portables.AddRange(doc);
                        foreach (var item in doc)
                        {

                            treeView1.SelectedNode.Nodes.Add(item.CompName);
                            treeView1.SelectedNode.LastNode.Tag = item;
                            treeView1.SelectedNode.LastNode.Name = item.CompName;
                        }
                        doc.Clear();
                    }
                }
            }

            label1.Text = "Перетащите файл сюда";

            Color c = panel1.BackColor;
            Pen pen = new Pen(c, 4);
            pen.DashPattern = new float[] { 4, 4 };  //размеры пунктиров     
            Graphics g = panel1.CreateGraphics();
            g.DrawRectangle(pen, 2, 2, panel1.Width - 4, panel1.Height - 4);
        }
    






        
    
        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                label1.Text = "Отпустите мишь";
                e.Effect = DragDropEffects.Copy;


                Random rnd = new Random();
                Color c = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                Pen pen = new Pen(c, 4);
                pen.DashPattern = new float[] { 4, 4 };  //размеры пунктиров     
                Graphics g = panel1.CreateGraphics();
                g.DrawRectangle(pen, 2, 2, panel1.Width - 4, panel1.Height - 4);
            }
        }

        private void panel1_DragLeave(object sender, EventArgs e)
        {
            label1.Text = "Перетащите файл сюда";

            Color c = panel1.BackColor;
            Pen pen = new Pen(c, 4);
            pen.DashPattern = new float[] { 4, 4 };  //размеры пунктиров     
            Graphics g = panel1.CreateGraphics();
            g.DrawRectangle(pen, 2, 2, panel1.Width - 4, panel1.Height - 4);
        }



        //          ЭТО НУЖНО БУДЕТ УБРАТЬ!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        private void button5_Click(object sender, EventArgs e) ////    пунктир и рандомное изменение цвета
        {
            Random rnd = new Random();
            Color c = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            Pen pen = new Pen(c, 4);
            pen.DashPattern = new float[] { 4, 4 };  //размеры пунктиров     
            Graphics g = panel1.CreateGraphics();
            g.DrawRectangle(pen,2,2,panel1.Width-4,panel1.Height-4);
        }

        private void Изменить_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.Level == 3)
            {
                if (treeView1.SelectedNode.Parent.Text == "Портативные компьютеры")
                {
                    try
                    {
                       // int result;
                        foreach (var item in portables)
                        {
                            if (item == treeView1.SelectedNode.Tag)
                            {
                                //if (item == treeView1.SelectedNode.Tag)
                                //{
                                //    result = Convert.ToInt32(textBox14.Text);
                                //    result = Convert.ToInt32(textBox15.Text);
                                //    result = Convert.ToInt32(textBox16.Text);
                                //}
                                //result = Convert.ToInt32(textBox17.Text);
                                item.CompName = textBox16.Text;
                                item.CompNameCompany = textBox17.Text;
                                item.CompPrice = textBox15.Text;
                                item.CompYear = textBox14.Text;
                                item.desktopProc = textBox13.Text;
                                treeView1.SelectedNode.Text = textBox16.Text;
                                treeView1.SelectedNode.Tag = item;
                                treeView1.SelectedNode.Name = textBox16.Text;
                                label2.Text = item.CompNameCompany;
                                label3.Text = item.CompName;
                                label4.Text = item.CompPrice;
                            }
                       }
                    }

                    catch (Exception)
                    {
                     
                        MessageBox.Show("Введены неверные данные!", "Ошибка!");
                    }
                }

            }
            textBox17.Text="";
            textBox16.Text = "";
            textBox15.Text = "";
            textBox14.Text = "";
            textBox13.Text = "";
            textBox12.Text = "";
            textBox11.Text = "";
            textBox10.Text = "";
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.Level == 3)
            {
                if (treeView1.SelectedNode.Parent.Text == "Портативные компьютеры")
                {

                    foreach (var item in portables)
                    {
                        if (item == treeView1.SelectedNode.Tag)
                        {

                            label2.Text = item.CompNameCompany;
                            label3.Text = item.CompName;
                            label4.Text = item.CompPrice;
                            label5.Text = item.desktopProc;
                        }
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    portables.Sort(Portable.SortCompany);
                    stationarys.Sort(Stationary.SortCompany);
                    listBox1.Items.Clear();
                    foreach (Portable h in portables)
                    {
                        listBox2.Items.Add(Portable.TextOut(h));
                    }
                    foreach (Stationary s in stationarys)
                    {
                        listBox2.Items.Add(Stationary.TextOut(s));
                    }
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    portables.Sort(Portable.SortYear);
                    stationarys.Sort(Stationary.SortYear);
                    listBox1.Items.Clear();
                    foreach (Portable h in portables)
                    {
                        listBox2.Items.Add(Portable.TextOut(h));
                    }
                    foreach (Stationary s in stationarys)
                    {
                        listBox2.Items.Add(Stationary.TextOut(s));
                    }
                }
            }

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }













        //private void button4_Click_1(object sender, EventArgs e)
        //{
        //    UserControl1 u = new UserControl1();
        //    u.Show();
        //}


        //int temperature = Convert.ToInt16(textBox18.Text);
        //if (comboBox2.SelectedIndex == 0)
        //{
        //    label11.Text = textBox18.Text;
        //    label12.Text = Convert.ToString(temperature-273);
        //    label13.Text = Convert.ToString(1,8*(temperature - 273)+23);

        //}
    }
}
    

