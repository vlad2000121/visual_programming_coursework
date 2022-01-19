using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml;
using System.Drawing;

namespace curs_vp
{
    public partial class Главная_форма : Form
    {
        string buffer;
        public Главная_форма()
        {
            InitializeComponent();

            this.Controls.Add(treeView1);
            treeView1.AllowDrop = true;
            this.ResumeLayout(false);

            treeView1.ItemDrag += new ItemDragEventHandler(treeView1_ItemDrag);
            treeView1.DragEnter += new DragEventHandler(treeView1_DragEnter);
            treeView1.DragDrop += new DragEventHandler(treeView1_DragDrop);



            //textBox1.ContextMenuStrip = contextMenuStrip1;
            //textBox2.ContextMenuStrip = contextMenuStrip1;
            //textBox3.ContextMenuStrip = contextMenuStrip1;
            //textBox4.ContextMenuStrip = contextMenuStrip1;
            //textBox5.ContextMenuStrip = contextMenuStrip1;
            //textBox6.ContextMenuStrip = contextMenuStrip1;
            //textBox7.ContextMenuStrip = contextMenuStrip1;
            //textBox8.ContextMenuStrip = contextMenuStrip1;
            //textBox9.ContextMenuStrip = contextMenuStrip1;
            //textBox10.ContextMenuStrip = contextMenuStrip1;
            //textBox11.ContextMenuStrip = contextMenuStrip1;
            //textBox12.ContextMenuStrip = contextMenuStrip1;
            //textBox13.ContextMenuStrip = contextMenuStrip1;
            //textBox14.ContextMenuStrip = contextMenuStrip1;
            //textBox15.ContextMenuStrip = contextMenuStrip1;
            //textBox16.ContextMenuStrip = contextMenuStrip1;

        }

        public List<Stationary> stationarys = new List<Stationary>();
        List<Portable> portables = new List<Portable>();
        List<PlayStation> playStations = new List<PlayStation>();
        List<Xbox> xboxs = new List<Xbox>();

        public class AllLists
        {
            List<Stationary> stationarys = new List<Stationary>();
            List<Portable> portables = new List<Portable>();
            List<PlayStation> playStations = new List<PlayStation>();
            List<Xbox> xboxs = new List<Xbox>();

            public List<Portable> Portables { get => portables; set => portables = value; }
            public List<Stationary> Stationarys { get => stationarys; set => stationarys = value; }
            public List<PlayStation> PlayStations { get => playStations; set => playStations = value; }
            public List<Xbox> Xboxs { get => xboxs; set => xboxs = value; }
        }
        bool flag = false;
        private void clearing()
        {
         


            portables.Clear();
            stationarys.Clear();
            xboxs.Clear();
            playStations.Clear();
            treeView1.Nodes[0].Nodes[0].Nodes[0].Nodes.Clear();
            treeView1.Nodes[0].Nodes[0].Nodes[1].Nodes.Clear();
            treeView1.Nodes[0].Nodes[1].Nodes[0].Nodes.Clear();
            treeView1.Nodes[0].Nodes[1].Nodes[1].Nodes.Clear();
        }
        private void Save_Win()
        {
            if (flag)
            {
                DialogResult dialogResult = MessageBox.Show("Вы хотите сохранить изменения в документе?", "Внимание!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    сохранитьToolStripMenuItem_Click(сохранитьToolStripMenuItem, null);
                }
            }
        }
        //private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Save_Win();
        //    clearing();
        //}

        private void Clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
       
        }
        public bool flag_save = false;
        //private void Save_Win()
        //{
        //    if (flag_save)
        //    {
        //        DialogResult dialogResult = MessageBox.Show("Вы хотите сохранить изменения в документе?", "Внимание!", MessageBoxButtons.YesNo);
        //        if (dialogResult == DialogResult.Yes)
        //        {
        //            сохранитьToolStripMenuItem1_Click(сохранитьToolStripMenuItem1, null);
        //        }
        //    }
        //}


       AllLists lists = new AllLists();
       

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode.Text == "Портативные компьютеры")
            {
               // pictureBox2.Image = Image.FromFile("порт.jpg");
                pictureBox3.Image = Image.FromFile("порт.jpg");
            } else
            if (treeView1.SelectedNode.Text == "Стационарные компьютеры")
            {
                //pictureBox2.Image = Image.FromFile("стац.jpg");
                pictureBox3.Image = Image.FromFile("стац.jpg");
            }
            else
            if (treeView1.SelectedNode.Text == "Xbox")
            {
                //pictureBox2.Image = Image.FromFile("х.jpeg");
                pictureBox3.Image = Image.FromFile("х.jpeg");
            }
            else
            if (treeView1.SelectedNode.Text == "PlayStation")
            {
                //pictureBox2.Image = Image.FromFile("р.jpg");
                pictureBox3.Image = Image.FromFile("р.jpg");
            }
           
        }



        private void Главная_форма_Load(object sender, EventArgs e)
        {
            TreeNode node = new TreeNode("Иерархия компьютеров");        // Добавляю сразу 3 класса от 1 до 3
            node.Nodes.Add("Настольные компьютеры");
            node.Nodes[0].Nodes.Add("Портативные компьютеры");
            node.Nodes[0].Nodes.Add("Стационарные компьютеры");
            node.Nodes.Add("Игровые консоли");
            node.Nodes[1].Nodes.Add("PlayStation");
            node.Nodes[1].Nodes.Add("Xbox");
           
            treeView1.Nodes.Add(node);
        }

        //private void button1_Click(object sender, EventArgs e)
        //{

        //    if (treeView1.SelectedNode.Level == 3)
        //    {
        //        if (treeView1.SelectedNode.Parent.Text == "Портативные компьютеры")
        //        {
        //            foreach (var item in portables)
        //            {
        //                if (item == treeView1.SelectedNode.Tag)
        //                {
        //                    treeView1.SelectedNode.Remove();
        //                    portables.Remove(item);
        //                    break;
        //                }
        //            }
        //        }
        //    }
        //}

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {

            string[] fileName = (string[])e.Data.GetData(DataFormats.FileDrop);

            foreach (string str in fileName)

            {
                FileStream FileStream = new FileStream(str, FileMode.Open, FileAccess.Read);
                XmlReader xmlReader = new XmlTextReader(FileStream);
                XmlSerializer deserializer = new XmlSerializer(typeof(AllLists));
                if (deserializer.CanDeserialize(xmlReader))
                {
                    Clear();
                    clearing();


                    AllLists lists = (AllLists)deserializer.Deserialize(xmlReader);
                    portables = lists.Portables;
                    foreach (var item in portables)
                    {
                        treeView1.Nodes[0].Nodes[0].Nodes[0].Nodes.Add(item.CompName);
                        treeView1.Nodes[0].Nodes[0].Nodes[0].LastNode.Tag = item;
                    }
                    stationarys = lists.Stationarys;
                    foreach (var item in stationarys)
                    {
                        treeView1.Nodes[0].Nodes[0].Nodes[1].Nodes.Add(item.CompName);
                        treeView1.Nodes[0].Nodes[0].Nodes[1].LastNode.Tag = item;
                    }
                    playStations = lists.PlayStations;
                    foreach (var item in playStations)
                    {
                        treeView1.Nodes[0].Nodes[1].Nodes[0].Nodes.Add(item.CompName);
                        treeView1.Nodes[0].Nodes[1].Nodes[0].LastNode.Tag = item;
                    }
                    xboxs = lists.Xboxs;
                    foreach (var item in xboxs)
                    {
                        treeView1.Nodes[0].Nodes[1].Nodes[1].Nodes.Add(item.CompName);
                        treeView1.Nodes[0].Nodes[1].Nodes[1].LastNode.Tag = item;
                    }
                    FileStream.Close();
                }
                else MessageBox.Show("Неверный формат файла", "Ошибка");

            }


            //string[] fileName = (string[])e.Data.GetData(DataFormats.FileDrop);

            //foreach (string str in fileName)

            //{
            //    FileStream FileStream = new FileStream(str, FileMode.Open, FileAccess.Read);
            //    XmlReader xmlReader = new XmlTextReader(FileStream);
            //    if (treeView1.SelectedNode.Text == "Портативные компьютеры")
            //    {
            //        XmlSerializer serializer = new XmlSerializer(typeof(List<Portable>));
            //        if (serializer.CanDeserialize(xmlReader))
            //        {
            //            List<Portable> doc = (List<Portable>)serializer.Deserialize(xmlReader);
            //            FileStream.Close();
            //            portables.AddRange(doc);
            //            foreach (var item in doc)
            //            {

            //                treeView1.SelectedNode.Nodes.Add(item.CompName);
            //                treeView1.SelectedNode.LastNode.Tag = item;
            //                treeView1.SelectedNode.LastNode.Name = item.CompName;
            //            }
            //            doc.Clear();
            //        }
            //    }
            //    else if (treeView1.SelectedNode.Text == "Стационарные компьютеры")
            //    {
            //        XmlSerializer serializer = new XmlSerializer(typeof(List<Stationary>));
            //        if (serializer.CanDeserialize(xmlReader))
            //        {
            //            List<Stationary> doc = (List<Stationary>)serializer.Deserialize(xmlReader);
            //            FileStream.Close();
            //            stationarys.AddRange(doc);
            //            foreach (var item in doc)
            //            {

            //                treeView1.SelectedNode.Nodes.Add(item.CompName);
            //                treeView1.SelectedNode.LastNode.Tag = item;
            //                treeView1.SelectedNode.LastNode.Name = item.CompName;
            //            }
            //            doc.Clear();
            //        }
            //    }
            //    else if (treeView1.SelectedNode.Text == "Xbox")
            //    {
            //        XmlSerializer serializer = new XmlSerializer(typeof(List<Xbox>));
            //        if (serializer.CanDeserialize(xmlReader))
            //        {
            //            List<Xbox> doc = (List<Xbox>)serializer.Deserialize(xmlReader);
            //            FileStream.Close();
            //            xboxs.AddRange(doc);
            //            foreach (var item in doc)
            //            {

            //                treeView1.SelectedNode.Nodes.Add(item.CompName);
            //                treeView1.SelectedNode.LastNode.Tag = item;
            //                treeView1.SelectedNode.LastNode.Name = item.CompName;
            //            }
            //            doc.Clear();
            //        }
            //    }
            //    else if (treeView1.SelectedNode.Text == "PlayStation")
            //    {
            //        XmlSerializer serializer = new XmlSerializer(typeof(List<Xbox>));
            //        if (serializer.CanDeserialize(xmlReader))
            //        {
            //            List<PlayStation> doc = (List<PlayStation>)serializer.Deserialize(xmlReader);
            //            FileStream.Close();
            //            playStations.AddRange(doc);
            //            foreach (var item in doc)
            //            {

            //                treeView1.SelectedNode.Nodes.Add(item.CompName);
            //                treeView1.SelectedNode.LastNode.Tag = item;
            //                treeView1.SelectedNode.LastNode.Name = item.CompName;
            //            }
            //            doc.Clear();
            //        }
            //    }

            //}


            label234.Text = "Перетащите файл сюда";

            Color c = panel1.BackColor;
            Pen pen = new Pen(c, 4);
            pen.DashPattern = new float[] { 4, 4 };  //размеры пунктиров     
            Graphics g = panel1.CreateGraphics();
            g.DrawRectangle(pen, 2, 2, panel1.Width - 4, panel1.Height - 4);
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                label234.Text = "Отпустите мишь";
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
            label234.Text = "Перетащите файл сюда";

            Color c = panel1.BackColor;
            Pen pen = new Pen(c, 4);
            pen.DashPattern = new float[] { 4, 4 };  //размеры пунктиров     
            Graphics g = panel1.CreateGraphics();
            g.DrawRectangle(pen, 2, 2, panel1.Width - 4, panel1.Height - 4);
        }


        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (portables.Count != 0 || stationarys.Count != 0 || xboxs.Count != 0 || playStations.Count != 0)
            {
                flag = false;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK && saveFileDialog1.FileName != "")
                {
                    string str = saveFileDialog1.FileName;

                    FileStream fileStream = new FileStream(str, FileMode.Create, FileAccess.ReadWrite);
                    AllLists all = new AllLists();
                    all.Portables = portables;
                    all.Stationarys = stationarys;
                    all.PlayStations = playStations;
                    all.Xboxs = xboxs;
                   



                    var serializer = new XmlSerializer(typeof(AllLists));                   
                    serializer.Serialize(fileStream, all);
                    fileStream.Close();

                }
            }
            else MessageBox.Show("Данных нет", "Ошибка");
        }













        //SaveFileDialog Load = new SaveFileDialog();
        //    Load.DefaultExt = "xml";
        //    Load.Filter = "xml files (*.xml;)| *.xml";
        //    string name = "";

        //    if (treeView1.SelectedNode.Text == "Портативные компьютеры")
        //    {
        //        if (Load.ShowDialog() == DialogResult.OK)
        //        {
        //            name = Load.FileName;
        //        }
        //        XmlSerializer xml = new XmlSerializer(typeof(List<Portable>));

        //        using (FileStream fs = new FileStream(name, FileMode.Create))
        //        {
        //            xml.Serialize(fs, portables);
        //        }
        //    }
        //    else if (treeView1.SelectedNode.Text == "Стационарные компьютеры")
        //    {
        //        if (Load.ShowDialog() == DialogResult.OK)
        //        {
        //            name = Load.FileName;
        //        }
        //        XmlSerializer xml = new XmlSerializer(typeof(List<Stationary>));

        //        using (FileStream fs = new FileStream(name, FileMode.Create))
        //        {
        //            xml.Serialize(fs, stationarys);
        //        }
        //    }

        //    else if (treeView1.SelectedNode.Text == "Xbox")
        //    {
        //        if (Load.ShowDialog() == DialogResult.OK)
        //        {
        //            name = Load.FileName;
        //        }
        //        XmlSerializer xml = new XmlSerializer(typeof(List<Xbox>));

        //        using (FileStream fs = new FileStream(name, FileMode.Create))
        //        {
        //            xml.Serialize(fs, xboxs);
        //        }
        //    }
        //    else if (treeView1.SelectedNode.Text == "PlayStation")
        //    {
        //        if (Load.ShowDialog() == DialogResult.OK)
        //        {
        //            name = Load.FileName;
        //        }
        //        XmlSerializer xml = new XmlSerializer(typeof(List<PlayStation>));

        //        using (FileStream fs = new FileStream(name, FileMode.Create))
        //        {
        //            xml.Serialize(fs, playStations);
        //        }
        //    }

        //}



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
                            label32.Text = h.CompNameCompany;
                            label31.Text = h.CompName;
                            label30.Text = h.desktopProc;
                            label29.Text = h.desktopVideo;
                            label28.Text = h.desktopRAM;
                            label27.Text = h.desktopDrives;
                            label26.Text = h.CompPrice;
                            label25.Text = h.CompYear;


                            label57.Text = h.CompNameCompany;
                            label56.Text = h.CompName;
                            label55.Text = h.desktopProc;
                            label54.Text = h.desktopVideo;
                            label53.Text = h.desktopRAM;
                            label52.Text = h.desktopDrives;
                            label51.Text = h.CompPrice;
                            label50.Text = h.CompYear;


                            textBox16.Text = h.CompNameCompany;
                            textBox15.Text = h.CompName;
                            textBox14.Text = h.desktopProc;
                            textBox13.Text = h.desktopVideo;
                            textBox12.Text = h.desktopRAM;
                            textBox11.Text = h.desktopDrives;
                            textBox10.Text = h.CompPrice;
                            textBox9.Text = h.CompYear;

                            
                            break;
                        }
                    }
                }
                if (treeView1.SelectedNode.Parent.Text == "Стационарные компьютеры")
                {
                    foreach (Stationary h in stationarys)
                    {
                        if (h == treeView1.SelectedNode.Tag)
                        {
                            label32.Text = h.CompNameCompany;
                            label31.Text = h.CompName;
                            label30.Text = h.desktopProc;
                            label29.Text = h.desktopVideo;
                            label28.Text = h.desktopRAM;
                            label27.Text = h.desktopDrives;
                            label26.Text = h.CompPrice;
                            label25.Text = h.CompYear;

                            label57.Text = h.CompNameCompany;
                            label56.Text = h.CompName;
                            label55.Text = h.desktopProc;
                            label54.Text = h.desktopVideo;
                            label53.Text = h.desktopRAM;
                            label52.Text = h.desktopDrives;
                            label51.Text = h.CompPrice;
                            label50.Text = h.CompYear;

                            textBox16.Text = h.CompNameCompany;
                            textBox15.Text = h.CompName;
                            textBox14.Text = h.desktopProc;
                            textBox13.Text = h.desktopVideo;
                            textBox12.Text = h.desktopRAM;
                            textBox11.Text = h.desktopDrives;
                            textBox10.Text = h.CompPrice;
                            textBox9.Text = h.CompYear;
                            break;
                        }
                    }
                }
               
               
                else if (treeView1.SelectedNode.Parent.Text == "Xbox")
                {
                    foreach (Xbox h in xboxs)
                    {
                        if (h == treeView1.SelectedNode.Tag)
                        {
                            label32.Text = h.CompNameCompany;
                            label31.Text = h.CompName;
                            label30.Text = h.ConsoleProc;
                            label29.Text = h.ConsoleVideo;
                            label28.Text = h.ConsoleRAM;
                            label27.Text = h.ConsoleDrives;
                            label26.Text = h.CompPrice;
                            label25.Text = h.CompYear;

                            label57.Text = h.CompNameCompany;
                            label56.Text = h.CompName;
                            label55.Text = h.ConsoleProc;
                            label54.Text = h.ConsoleVideo;
                            label53.Text = h.ConsoleRAM;
                            label52.Text = h.ConsoleDrives;
                            label51.Text = h.CompPrice;
                            label50.Text = h.CompYear;

                            textBox16.Text = h.CompNameCompany;
                            textBox15.Text = h.CompName;
                            textBox14.Text = h.ConsoleProc;
                            textBox13.Text = h.ConsoleVideo;
                            textBox12.Text = h.ConsoleRAM;
                            textBox11.Text = h.ConsoleDrives;
                            textBox10.Text = h.CompPrice;
                            textBox9.Text = h.CompYear;
                            break;
                        }
                    }
                }
                else if (treeView1.SelectedNode.Parent.Text == "PlayStation")
                {
                    foreach (PlayStation h in playStations)
                    {
                        if (h == treeView1.SelectedNode.Tag)
                        {
                            label32.Text = h.CompNameCompany;
                            label31.Text = h.CompName;
                            label30.Text = h.ConsoleProc;
                            label29.Text = h.ConsoleVideo;
                            label28.Text = h.ConsoleRAM;
                            label27.Text = h.ConsoleDrives;
                            label26.Text = h.CompPrice;
                            label25.Text = h.CompYear;

                            label57.Text = h.CompNameCompany;
                            label56.Text = h.CompName;
                            label55.Text = h.ConsoleProc;
                            label54.Text = h.ConsoleVideo;
                            label53.Text = h.ConsoleRAM;
                            label52.Text = h.ConsoleDrives;
                            label51.Text = h.CompPrice;
                            label50.Text = h.CompYear;

                            textBox16.Text = h.CompNameCompany;
                            textBox15.Text = h.CompName;
                            textBox14.Text = h.ConsoleProc;
                            textBox13.Text = h.ConsoleVideo;
                            textBox12.Text = h.ConsoleRAM;
                            textBox11.Text = h.ConsoleDrives;
                            textBox10.Text = h.CompPrice;
                            textBox9.Text = h.CompYear;
                            break;
                        }
                    }
                }

            }
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Добавить form2 = new Добавить(this, sender, e, portables, stationarys, playStations, xboxs);
            //form2.Show();
            tabControl1.SelectedIndex = 1;

            tabPage1.Show();


        }


        private void поискToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Поиск поиск = new Поиск(this, sender, e, portables, stationarys, playStations, xboxs);
            поиск.Show();
        }




        private void сортировкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Сортировка сортировка = new Сортировка(this, sender, e, portables, stationarys, playStations, xboxs);
            сортировка.Show();
        }


        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Вы точно хотите выйти?", "Выход", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
                this.Close();
        }

        private void Главная_форма_KeyPress(object sender, KeyPressEventArgs e)
        {
          
            if (e.KeyChar == (char)Keys.Escape)
            {
                DialogResult res = MessageBox.Show("Вы точно хотите выйти?", "Выход", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                    this.Close();
            }
        }

     

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)

            {
            Save_Win();
            if (openFileDialog1.ShowDialog() == DialogResult.OK && openFileDialog1.FileName != "")
                {
                    string str = openFileDialog1.FileName;
                    FileStream fileStream = new FileStream(str, FileMode.Open, FileAccess.Read);
                    XmlReader xmlReader = new XmlTextReader(fileStream);
                    XmlSerializer deserializer = new XmlSerializer(typeof(AllLists));
                    if (deserializer.CanDeserialize(xmlReader))
                    {
                    Clear();
                    clearing();


                    AllLists lists = (AllLists)deserializer.Deserialize(xmlReader);
                        portables = lists.Portables;
                        foreach (var item in portables)
                        {
                            treeView1.Nodes[0].Nodes[0].Nodes[0].Nodes.Add(item.CompName);
                            treeView1.Nodes[0].Nodes[0].Nodes[0].LastNode.Tag = item;
                        }
                        stationarys = lists.Stationarys;
                        foreach (var item in stationarys)
                        {
                            treeView1.Nodes[0].Nodes[0].Nodes[1].Nodes.Add(item.CompName);
                            treeView1.Nodes[0].Nodes[0].Nodes[1].LastNode.Tag = item;
                        }
                    xboxs = lists.Xboxs;
                    foreach (var item in xboxs)
                    {
                        treeView1.Nodes[0].Nodes[1].Nodes[1].Nodes.Add(item.CompName);
                        treeView1.Nodes[0].Nodes[1].Nodes[1].LastNode.Tag = item;
                    }
                    playStations = lists.PlayStations;
                    foreach (var item in playStations)
                    {
                        treeView1.Nodes[0].Nodes[1].Nodes[0].Nodes.Add(item.CompName);
                        treeView1.Nodes[0].Nodes[1].Nodes[0].LastNode.Tag = item;
                    }
                   
                    fileStream.Close();
                    }
                    else MessageBox.Show("Неверный формат файла", "Ошибка");
                }
            }














        //            try
        //            {
        //                if (/*treeView1.SelectedNode.Text == "Портативные компьютеры" &&*/ openFileDialog1.ShowDialog() == DialogResult.OK)
        //            {
        //                string str = openFileDialog1.FileName;
        //                FileStream FileStream = new FileStream(str, FileMode.Open, FileAccess.Read);
        //                XmlReader xmlReader = new XmlTextReader(FileStream);
        //                if (treeView1.SelectedNode.Text == "Портативные компьютеры")
        //                {
        //                    XmlSerializer serializer = new XmlSerializer(typeof(List<Portable>));
        //                    if (serializer.CanDeserialize(xmlReader))
        //                    {
        //                        List<Portable> doc = (List<Portable>)serializer.Deserialize(xmlReader);
        //                        FileStream.Close();
        //                        portables.AddRange(doc);
        //                        foreach (var item in doc)
        //                        {

        //                            treeView1.SelectedNode.Nodes.Add(item.CompName);
        //                            treeView1.SelectedNode.LastNode.Tag = item;
        //                            treeView1.SelectedNode.LastNode.Name = item.CompName;
        //                        }
        //                        doc.Clear();
        //                    }
        //                }
        //                else if (treeView1.SelectedNode.Text == "Стационарные компьютеры")
        //                {
        //                    XmlSerializer serializer = new XmlSerializer(typeof(List<Stationary>));
        //                    if (serializer.CanDeserialize(xmlReader))
        //                    {
        //                        List<Stationary> doc = (List<Stationary>)serializer.Deserialize(xmlReader);
        //                        FileStream.Close();
        //                        stationarys.AddRange(doc);
        //                        foreach (var item in doc)
        //                        {
        //                            treeView1.SelectedNode.Nodes.Add(item.CompName);
        //                            treeView1.SelectedNode.LastNode.Tag = item;
        //                            treeView1.SelectedNode.LastNode.Name = item.CompName;
        //                        }
        //                        doc.Clear();
        //                    }

        //                }
        //                else if (treeView1.SelectedNode.Text == "Xbox")
        //                {
        //                    XmlSerializer serializer = new XmlSerializer(typeof(List<Xbox>));
        //                    if (serializer.CanDeserialize(xmlReader))
        //                    {
        //                        List<Xbox> doc = (List<Xbox>)serializer.Deserialize(xmlReader);
        //                        FileStream.Close();
        //                        xboxs.AddRange(doc);
        //                        foreach (var item in doc)
        //                        {

        //                            treeView1.SelectedNode.Nodes.Add(item.CompName);
        //                            treeView1.SelectedNode.LastNode.Tag = item;
        //                            treeView1.SelectedNode.LastNode.Name = item.CompName;
        //                        }
        //                        doc.Clear();
        //                    }

        //                }
        //                else if (treeView1.SelectedNode.Text == "PlayStation")
        //                {
        //                    XmlSerializer serializer = new XmlSerializer(typeof(List<PlayStation>));
        //                    if (serializer.CanDeserialize(xmlReader))
        //                    {
        //                        List<PlayStation> doc = (List<PlayStation>)serializer.Deserialize(xmlReader);
        //                        FileStream.Close();
        //                        playStations.AddRange(doc);
        //                        foreach (var item in doc)
        //                        {

        //                            treeView1.SelectedNode.Nodes.Add(item.CompName);
        //                            treeView1.SelectedNode.LastNode.Tag = item;
        //                            treeView1.SelectedNode.LastNode.Name = item.CompName;
        //                        }
        //                        doc.Clear();
        //                    }

        //                }

        //            }
        //        }
        //                 catch (Exception)
        //            { MessageBox.Show("Что-то пошло не так! Упс!", "Ошибка!"); }
        //}


        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flag = true;
            Save_Win();
            clearing();
        }

        //{
        //    try
        //    {

        //        saveFileDialog1.Filter = "xml files (*.xml;)| *.xml";
        //        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
        //        {
        //            string name = saveFileDialog1.FileName;
        //            FileStream fs = new FileStream(name, FileMode.Create);

        //        }
        //    }
        //    catch (Exception)
        //    { MessageBox.Show("Введены неверные данные!", "Ошибка!"); }
        //}

        private void Изменить_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.Level == 3)
            {
                if (treeView1.SelectedNode.Parent.Text == "Портативные компьютеры")
                {
                    try
                    {

                        foreach (var item in portables)
                        {
                            if (item == treeView1.SelectedNode.Tag)
                            {

                                item.CompName = textBox15.Text;
                                item.CompNameCompany = textBox16.Text;
                                item.CompPrice = textBox10.Text;
                                item.CompYear = textBox9.Text;
                                item.desktopProc = textBox14.Text;
                                item.desktopVideo = textBox13.Text;
                                item.desktopRAM = textBox12.Text;
                                item.desktopDrives = textBox11.Text;
                                treeView1.SelectedNode.Text = textBox15.Text;
                                treeView1.SelectedNode.Tag = item;
                                treeView1.SelectedNode.Name = textBox15.Text;
                                label32.Text = item.CompNameCompany;
                                label31.Text = item.CompName;
                                label26.Text = item.CompPrice;
                            }
                        }
                    }

                    catch (Exception)
                    {

                        MessageBox.Show("Введены неверные данные!", "Ошибка!");
                    }
                }
                else if (treeView1.SelectedNode.Parent.Text == "Стационарные компьютеры")
                {
                    try
                    {
                        // int result;
                        foreach (var item in stationarys)
                        {
                            if (item == treeView1.SelectedNode.Tag)
                            {
                               
                                item.CompName = textBox15.Text;
                                item.CompNameCompany = textBox16.Text;
                                item.CompPrice = textBox10.Text;
                                item.CompYear = textBox9.Text;
                                item.desktopProc = textBox14.Text;
                                item.desktopVideo = textBox13.Text;
                                item.desktopRAM = textBox12.Text;
                                item.desktopDrives = textBox11.Text;
                                treeView1.SelectedNode.Text = textBox15.Text;
                                treeView1.SelectedNode.Tag = item;
                                treeView1.SelectedNode.Name = textBox15.Text;
                                label32.Text = item.CompNameCompany;
                                label31.Text = item.CompName;
                                label26.Text = item.CompPrice;
                            }
                        }
                    }

                    catch (Exception)
                    {

                        MessageBox.Show("Введены неверные данные!", "Ошибка!");
                    }
                }

                else if (treeView1.SelectedNode.Parent.Text == "PlayStation")
                {
                    try
                    {
                        // int result;
                        foreach (var item in playStations)
                        {
                            if (item == treeView1.SelectedNode.Tag)
                            {
                                
                                item.CompName = textBox15.Text;
                                item.CompNameCompany = textBox16.Text;
                                item.CompPrice = textBox10.Text;
                                item.CompYear = textBox9.Text;
                                item.ConsoleProc = textBox14.Text;
                                item.ConsoleVideo = textBox13.Text;
                                item.ConsoleRAM = textBox12.Text;
                                item.ConsoleDrives = textBox11.Text;
                                treeView1.SelectedNode.Text = textBox15.Text;
                                treeView1.SelectedNode.Tag = item;
                                treeView1.SelectedNode.Name = textBox15.Text;
                                label32.Text = item.CompNameCompany;
                                label31.Text = item.CompName;
                                label26.Text = item.CompPrice;
                            }
                        }
                    }

                    catch (Exception)
                    {

                        MessageBox.Show("Введены неверные данные!", "Ошибка!");
                    }
                }
                else if (treeView1.SelectedNode.Parent.Text == "Xbox")
                {
                    try
                    {
                        // int result;
                        foreach (var item in xboxs)
                        {
                            if (item == treeView1.SelectedNode.Tag)
                            {
                               
                                item.CompName = textBox15.Text;
                                item.CompNameCompany = textBox16.Text;
                                item.CompPrice = textBox10.Text;
                                item.CompYear = textBox9.Text;
                                item.ConsoleProc = textBox14.Text;
                                item.ConsoleVideo = textBox13.Text;
                                item.ConsoleRAM = textBox12.Text;
                                item.ConsoleDrives = textBox11.Text;
                                treeView1.SelectedNode.Text = textBox15.Text;
                                treeView1.SelectedNode.Tag = item;
                                treeView1.SelectedNode.Name = textBox15.Text;
                                label32.Text = item.CompNameCompany;
                                label31.Text = item.CompName;
                                label26.Text = item.CompPrice;
                            }
                        }
                    }

                    catch (Exception)
                    {

                        MessageBox.Show("Введены неверные данные!", "Ошибка!");
                    }
                }

            }

            textBox16.Text = "";
            textBox15.Text = "";
            textBox14.Text = "";
            textBox13.Text = "";
            textBox12.Text = "";
            textBox11.Text = "";
            textBox10.Text = "";
            textBox9.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text != "") && (textBox2.Text != "") && (textBox3.Text != "") && (textBox4.Text != "") && (textBox5.Text != "") && (textBox6.Text != ""))
            {
                
                if (treeView1.SelectedNode.Text == "Портативные компьютеры")
                {
                
                    try
                    {
                       

                        portables.Add(new Portable(textBox1.Text, textBox2.Text, textBox7.Text, textBox8.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, treeView1.SelectedNode.Text));

                        treeView1.SelectedNode.Nodes.Add(textBox2.Text);
                        treeView1.SelectedNode.LastNode.Tag = portables.Last();
                        treeView1.SelectedNode.LastNode.Name = textBox2.Text;
                    }

                    catch (Exception)
                    {
                        MessageBox.Show("Введены неверные данные!", "Ошибка!");
                    }
                }
                else if (treeView1.SelectedNode.Text == "Стационарные компьютеры")
                {
                 
                    try
                    {
                      

                        stationarys.Add(new Stationary(textBox1.Text, textBox2.Text, textBox7.Text, textBox8.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, treeView1.SelectedNode.Text));

                        treeView1.SelectedNode.Nodes.Add(textBox2.Text);
                        treeView1.SelectedNode.LastNode.Tag = stationarys.Last();
                        treeView1.SelectedNode.LastNode.Name = textBox2.Text;
                    }

                    catch (Exception)
                    {
                        MessageBox.Show("Введены неверные данные!", "Ошибка!");
                    }
                }
                else if (treeView1.SelectedNode.Text == "Xbox")
                {
                    
                    try
                    {
                   

                        xboxs.Add(new Xbox(textBox1.Text, textBox2.Text, textBox7.Text, textBox8.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, treeView1.SelectedNode.Text));

                        treeView1.SelectedNode.Nodes.Add(textBox2.Text);
                        treeView1.SelectedNode.LastNode.Tag = xboxs.Last();
                        treeView1.SelectedNode.LastNode.Name = textBox2.Text;
                    }

                    catch (Exception)
                    {
                        MessageBox.Show("Введены неверные данные!", "Ошибка!");
                    }
                }
                else if (treeView1.SelectedNode.Text == "PlayStation")
                {
                    
                    try
                    {
                      

                        playStations.Add(new PlayStation(textBox1.Text, textBox2.Text, textBox7.Text, textBox8.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, treeView1.SelectedNode.Text));

                        treeView1.SelectedNode.Nodes.Add(textBox2.Text);
                        treeView1.SelectedNode.LastNode.Tag = playStations.Last();
                        treeView1.SelectedNode.LastNode.Name = textBox2.Text;
                    }

                    catch (Exception)
                    {
                        MessageBox.Show("Введены неверные данные!", "Ошибка!");
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
                            break;
                        }
                    }
                }
                else if (treeView1.SelectedNode.Parent.Text == "Стационарные компьютеры")
                {
                    foreach (var item in stationarys)
                    {
                        if (item == treeView1.SelectedNode.Tag)
                        {
                            treeView1.SelectedNode.Remove();
                            stationarys.Remove(item);
                            break;
                        }
                    }
                }
                else if (treeView1.SelectedNode.Parent.Text == "Xbox")
                {
                    foreach (var item in xboxs)
                    {
                        if (item == treeView1.SelectedNode.Tag)
                        {
                            treeView1.SelectedNode.Remove();
                            xboxs.Remove(item);
                            break;
                        }
                    }
                }
                else if (treeView1.SelectedNode.Parent.Text == "PlayStation")
                {
                    foreach (var item in playStations)
                    {
                        if (item == treeView1.SelectedNode.Tag)
                        {
                            treeView1.SelectedNode.Remove();
                            playStations.Remove(item);
                            break;
                        }
                    }
                }
            }
        }

        private void изменитьОбьектToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;

            tabPage2.Show();

        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
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
                            break;
                        }
                    }
                }
                else if (treeView1.SelectedNode.Parent.Text == "Стационарные компьютеры")
                {
                    foreach (var item in stationarys)
                    {
                        if (item == treeView1.SelectedNode.Tag)
                        {
                            treeView1.SelectedNode.Remove();
                            stationarys.Remove(item);
                            break;
                        }
                    }
                }
                else if (treeView1.SelectedNode.Parent.Text == "Xbox")
                {
                    foreach (var item in xboxs)
                    {
                        if (item == treeView1.SelectedNode.Tag)
                        {
                            treeView1.SelectedNode.Remove();
                            xboxs.Remove(item);
                            break;
                        }
                    }
                }
                else if (treeView1.SelectedNode.Parent.Text == "PlayStation")
                {
                    foreach (var item in playStations)
                    {
                        if (item == treeView1.SelectedNode.Tag)
                        {
                            treeView1.SelectedNode.Remove();
                            playStations.Remove(item);
                            break;
                        }
                    }
                }
            }
        }

        private void конвертерВалютToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Конвертвал валюта = new Конвертвал();
            валюта.Show();
        }

        private void конвертерТемпературыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Преобразование_температуры температура = new Преобразование_температуры();
            температура.Show();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            //if (treeView1.SelectedNode.Parent.Text == "PlayStation" || treeView1.SelectedNode.Parent.Text == "Xbox")
            //{
            //    label23.Text = "Название консоли";
            //}
            //else
            //{
            //    label23.Text = "Название компьютера";
            //}
        }

        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buffer = textBox1.SelectedText;
            textBox1.Text = "";
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buffer = textBox1.SelectedText;
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste(buffer);
        }

        private void удалитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void оПрограммеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Приложение с иерархией компьютеров.\n" +
                "Пользователь может добавлять, удалять, изменять обьекты.\n"+
                "Так же предусмотренна возможность сортировки и поиска обьекта\n" +

                "Создано два элемента управления: Оналайн конверт валют и конверт температуры.\n"

                , "Информация о программе");
        }

        private void создатьToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {

                saveFileDialog1.Filter = "xml files (*.xml;)| *.xml";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string name = saveFileDialog1.FileName;
                    FileStream fs = new FileStream(name, FileMode.Create);

                }
            }
            catch (Exception)
            { MessageBox.Show("Введены неверные данные!", "Ошибка!"); }
        }

        private void открытьToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (/*treeView1.SelectedNode.Text == "Портативные компьютеры" &&*/ openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string str = openFileDialog1.FileName;
                FileStream FileStream = new FileStream(str, FileMode.Open, FileAccess.Read);
                XmlReader xmlReader = new XmlTextReader(FileStream);
                if (treeView1.SelectedNode.Text == "Портативные компьютеры")
                {
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
                else if (treeView1.SelectedNode.Text == "Стационарные компьютеры")
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Stationary>));
                    if (serializer.CanDeserialize(xmlReader))
                    {
                        List<Stationary> doc = (List<Stationary>)serializer.Deserialize(xmlReader);
                        FileStream.Close();
                        stationarys.AddRange(doc);
                        foreach (var item in doc)
                        {
                            treeView1.SelectedNode.Nodes.Add(item.CompName);
                            treeView1.SelectedNode.LastNode.Tag = item;
                            treeView1.SelectedNode.LastNode.Name = item.CompName;
                        }
                        doc.Clear();
                    }

                }
                else if (treeView1.SelectedNode.Text == "Xbox")
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Xbox>));
                    if (serializer.CanDeserialize(xmlReader))
                    {
                        List<Xbox> doc = (List<Xbox>)serializer.Deserialize(xmlReader);
                        FileStream.Close();
                        xboxs.AddRange(doc);
                        foreach (var item in doc)
                        {

                            treeView1.SelectedNode.Nodes.Add(item.CompName);
                            treeView1.SelectedNode.LastNode.Tag = item;
                            treeView1.SelectedNode.LastNode.Name = item.CompName;
                        }
                        doc.Clear();
                    }

                }
                else if (treeView1.SelectedNode.Text == "PlayStation")
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<PlayStation>));
                    if (serializer.CanDeserialize(xmlReader))
                    {
                        List<PlayStation> doc = (List<PlayStation>)serializer.Deserialize(xmlReader);
                        FileStream.Close();
                        playStations.AddRange(doc);
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
        }
            catch (Exception)
            { MessageBox.Show("Что-то пошло не так! Упс!", "Ошибка!"); }
        }

//        private void сохранитьToolStripButton_Click(object sender, EventArgs e)
       
//        {
//            try
//            {
//                SaveFileDialog Load = new SaveFileDialog();
//            Load.DefaultExt = "xml";
//            Load.Filter = "xml files (*.xml;)| *.xml";
//            string name = "";

//            if (treeView1.SelectedNode.Text == "Портативные компьютеры")
//            {
//                if (Load.ShowDialog() == DialogResult.OK)
//                {
//                    name = Load.FileName;
//                }
//                XmlSerializer xml = new XmlSerializer(typeof(List<Portable>));

//                using (FileStream fs = new FileStream(name, FileMode.Create))
//                {
//                    xml.Serialize(fs, portables);
//                }
//            }
//            else if (treeView1.SelectedNode.Text == "Стационарные компьютеры")
//            {
//                if (Load.ShowDialog() == DialogResult.OK)
//                {
//                    name = Load.FileName;
//                }
//                XmlSerializer xml = new XmlSerializer(typeof(List<Stationary>));

//                using (FileStream fs = new FileStream(name, FileMode.Create))
//                {
//                    xml.Serialize(fs, stationarys);
//                }
//            }

//            else if (treeView1.SelectedNode.Text == "Xbox")
//            {
//                if (Load.ShowDialog() == DialogResult.OK)
//                {
//                    name = Load.FileName;
//                }
//                XmlSerializer xml = new XmlSerializer(typeof(List<Xbox>));

//                using (FileStream fs = new FileStream(name, FileMode.Create))
//                {
//                    xml.Serialize(fs, xboxs);
//                }
//            }
//            else if (treeView1.SelectedNode.Text == "PlayStation")
//            {
//                if (Load.ShowDialog() == DialogResult.OK)
//                {
//                    name = Load.FileName;
//                }
//                XmlSerializer xml = new XmlSerializer(typeof(List<PlayStation>));

//                using (FileStream fs = new FileStream(name, FileMode.Create))
//                {
//                    xml.Serialize(fs, playStations);
//                }
//            }
//        }
//         catch (Exception)
//            { MessageBox.Show("Что-то пошло не так! Упс!", "Ошибка!"); }
//}

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

        private void treeView1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
        private void treeView1_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode NewNode;
            if (e.Data.GetDataPresent("System.Windows.Forms.TreeNode", false))
            {
                Point pt = ((TreeView)sender).PointToClient(new Point(e.X, e.Y));
                TreeNode DestinationNode = ((TreeView)sender).GetNodeAt(pt);
                int index = DestinationNode.Index;
                NewNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");
                if (DestinationNode.Level != 0 && NewNode.Level == 3 &&
               DestinationNode.Level != 1)
                {
                    if (DestinationNode.Level == 3)
                    {
                        DestinationNode.Parent.Nodes.Insert(index,
                       (TreeNode)NewNode.Clone());
                    }
                    else if (DestinationNode.Level == 2)
                    {
                        DestinationNode.Nodes.Insert(index, (TreeNode)NewNode.Clone());
                    }
                    NewNode.Remove();
                }
            }
        }
        private void treeView1_ItemDrag(object sender, ItemDragEventArgs e)
        {
            DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void button4_Click(object sender, EventArgs e)
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
                            break;
                        }
                    }
                }
                else if (treeView1.SelectedNode.Parent.Text == "Стационарные компьютеры")
                {
                    foreach (var item in stationarys)
                    {
                        if (item == treeView1.SelectedNode.Tag)
                        {
                            treeView1.SelectedNode.Remove();
                            stationarys.Remove(item);
                            break;
                        }
                    }
                }
                else if (treeView1.SelectedNode.Parent.Text == "Xbox")
                {
                    foreach (var item in xboxs)
                    {
                        if (item == treeView1.SelectedNode.Tag)
                        {
                            treeView1.SelectedNode.Remove();
                            xboxs.Remove(item);
                            break;
                        }
                    }
                }
                else if (treeView1.SelectedNode.Parent.Text == "PlayStation")
                {
                    foreach (var item in playStations)
                    {
                        if (item == treeView1.SelectedNode.Tag)
                        {
                            treeView1.SelectedNode.Remove();
                            playStations.Remove(item);
                            break;
                        }
                    }
                }
            }
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Приложение с иерархией компьютеров.\n" +
               "Пользователь может добавлять, удалять, изменять обьекты по нажатию кнопки мышью, а также с помощью горячих клавиш.\n" +
               "Так же предусмотренна возможность сортировки и поиска обьекта\n" +

               "Создано два элемента управления: Оналайн конверт валют и конверт температуры." +
               " Для работы Онлайн конверт валют необходимо интернет соединение. \n"

               , "Справка");
        }

      
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            создатьToolStripMenuItem_Click(toolStripButton1, null);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            сохранитьToolStripMenuItem_Click(toolStripButton2, null);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.Level == 2)
                добавитьToolStripMenuItem_Click(toolStripButton3, null);
            else MessageBox.Show("Выберите 2 уровень", "Ошибка");
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            удалитьToolStripMenuItem_Click(toolStripButton4, null);
        }

        private void contextMenuStrip2_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
            изменитьОбьектToolStripMenuItem_Click(редактироватьToolStripMenuItem, null);
        }
    }
}