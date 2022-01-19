using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curs_vp
{
    //Консоли

    [Serializable]
    public class Console : Comp     //Консоли
    {
        private string _consoleProc;
        private string _consoleVideo;
        private string _consoleRAM;
        private string _consoleDrives;
        public string ConsoleProc
        {
            get { return _consoleProc; }
            set { _consoleProc = value; }
        }
        public string ConsoleVideo
        {
            get { return _consoleVideo; }
            set { _consoleVideo = value; }
        }
        public string ConsoleRAM
        {
            get { return _consoleRAM; }
            set { _consoleRAM = value; }
        }

        public string ConsoleDrives
        {
            get { return _consoleDrives; }
            set { _consoleDrives = value; }
        }

        public Console()
        { }
        public Console(string namecompany, string name, string price, string year, string proc, string video, string ram, string drives) : base(namecompany, name, price, year)

        {
            this.ConsoleProc = proc;
            this.ConsoleRAM = ram;
            this.ConsoleVideo = video;
            this._consoleDrives = drives;
        }
    }




    [Serializable]
    public class PlayStation : Console
    {
        private string _consoleView;         //Вид игровой консоли
        public string ConsoleView
        {
            get { return _consoleView; }
            set { _consoleView = value; }
        }

        public PlayStation(string namecompany, string name, string proc, string video, string ram, string drives, string price, string year,  string views) : base(namecompany, name, proc, video, ram, drives, price, year)
        {
            this.ConsoleView = views;
        }

        public PlayStation()
        { }

        static public string TextOut(PlayStation n)
        {
            string s = $"Название компании: '{n.CompNameCompany}',\t Название: '{n.CompName}',\t Год: '{n.CompYear}',\t Вид: '{n.ConsoleView}'";
            return s;
        }

        //Cортировка
        static public int SortCompany(PlayStation p1, PlayStation p2)
        {
            return p1.CompNameCompany.CompareTo(p2.CompNameCompany);
        }
        static public int SortYear(PlayStation p1, PlayStation p2)
        {
            return p1.CompYear.CompareTo(p2.CompYear);
        }
    }




    [Serializable]
    public class Xbox : Console
    {
        private string _consoleView;         //Вид игровой консоли
        public string ConsoleView
        {
            get { return _consoleView; }
            set { _consoleView = value; }
        }

        public Xbox(string namecompany, string name, string proc, string video, string ram, string drives, string price, string year,  string views) : base(namecompany, name, proc, video, ram, drives, price, year)
        {
            this.ConsoleView = views;
        }

        public Xbox()
        {
         
        }

        static public string TextOut(Xbox n)
        {
            string s = $"Название компании: '{n.CompNameCompany}', Название: '{n.CompName}', Год выпуска: '{n.CompYear}',Вид компьютера: '{n.ConsoleView}'";
            return s;
        }

        //Cортировка
        static public int SortCompany(Xbox x1, Xbox x2)
        {
            return x1.CompNameCompany.CompareTo(x2.CompNameCompany);
        }
        static public int SortYear(Xbox x1, Xbox x2)
        {
            return x1.CompYear.CompareTo(x2.CompYear);
        }
    }
}
