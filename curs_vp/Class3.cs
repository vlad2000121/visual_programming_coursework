using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curs_vp
{
    //Настольные компьтеры
    [Serializable]

    abstract public class Desktop : Comp          //Настольные компьтеры
    {
        private string _desktopProc;
        private string _desktopVideo;
        private string _desktopRAM;
        private string _desktopDrives;
        public string desktopProc
        {
            get { return _desktopProc; }
            set { _desktopProc = value; }
        }
        public string desktopVideo
        {
            get { return _desktopVideo; }
            set { _desktopVideo = value; }
        }
        public string desktopRAM
        {
            get { return _desktopRAM; }
            set { _desktopRAM = value; }
        }
        public string desktopDrives
        {
            get { return _desktopDrives; }
            set { _desktopDrives = value; }
        }
        public Desktop()
        { }

        public Desktop(string namecompany, string name, string price, string year, string proc, string video, string ram, string drives) : base(namecompany, name, price, year)
        {
            this.desktopProc = proc;
            this.desktopRAM = ram;
            this.desktopVideo = video;
            this.desktopDrives = drives;
        }
    }

    [Serializable]
    public class Stationary : Desktop
    {
        private string _stationaryView;         //Виды стационарных компьютеров
        public string StationaryView
        {
            get { return _stationaryView; }
            set { _stationaryView = value; }
        }

        public Stationary(string namecompany, string name, string proc, string video, string ram, string drives, string price, string year,  string views) : base(namecompany, name, proc, video, ram, drives, price, year)
        {
            this.StationaryView = views;
        }
        public Stationary()
        {

        }
        static public string TextOut(Stationary n)
        {
            string s = $"Название компании: '{n.CompNameCompany}',\t Название: '{n.CompName}',\t Год выпуска: '{n.CompYear}',\tВид компьютера: '{n.StationaryView}'\t";



            return s;
        }


        //Cортировка
        static public int SortCompany(Stationary s1, Stationary s2)
        {
            return s1.CompNameCompany.CompareTo(s2.CompNameCompany);
        }
        static public int SortYear(Stationary s1, Stationary s2)
        {
            return s1.CompYear.CompareTo(s2.CompYear);
        }

    }


    [Serializable]
    public class Portable : Desktop
    {
        private string _portableView;         //Виды портативных компьютеров
        public string PortableView
        {
            get { return _portableView; }
            set { _portableView = value; }
        }

        public Portable(string namecompany, string name, string proc, string video, string ram, string drives, string price, string year, string views) : base(namecompany, name, proc, video, ram, drives, price, year)
        {
            this.PortableView = views;
        }

        public Portable()
        {

        }


        static public string TextOut(Portable n)
        {
            return $"Название компании:'{n.CompNameCompany}',\t Название:'{n.CompName}',\t Год: '{n.CompYear}',\t Вид: '{n.PortableView}'\t";

        }

        //Cортировка
        static public int SortCompany(Portable p1, Portable p2)
        {
            return p1.CompNameCompany.CompareTo(p2.CompNameCompany);
        }
        static public int SortYear(Portable p1, Portable p2)
        {
            return p1.CompYear.CompareTo(p2.CompYear);
        }
    }

}
