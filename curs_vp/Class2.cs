using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace curs_vp
{
    //Сервер
    [Serializable]

    abstract public class Server : Comp          //Настольные компьтеры
    {
        private string _serverProc;      
        private string _serverRAM;
        private string _serverDrives;
        private string _serverFormFactor;
        public string serverProc
        {
            get { return _serverProc; }
            set { _serverProc = value; }
        }
        public string serverFormFactor
        {
            get { return _serverFormFactor; }
            set { _serverFormFactor = value; }
        }
        public string serverRAM
        {
            get { return _serverRAM; }
            set { _serverRAM = value; }
        }
        public string serverDrives
        {
            get { return _serverDrives; }
            set { _serverDrives = value; }
        }
        public Server()
        { }

        public Server(string namecompany, string name, string price, string year, string proc, string formfactor, string ram, string drives) : base(namecompany, name, price, year)
        {
            this.serverProc = proc;
            this.serverRAM = ram;
            this.serverFormFactor = formfactor;
            this.serverDrives = drives;
        }
    }
    [Serializable]
    public class Entry : Server
    {
        private string _serverView;         //Виды стационарных компьютеров
        public string ServerView
        {
            get { return _serverView; }
            set { _serverView = value; }
        }

        public Entry(string namecompany, string name, string price, string year, string proc, string formfactor, string ram, string drives, string views) : base(namecompany, name, price, year, proc, formfactor, ram, drives)
        {
            this.ServerView = views;
        }
        static public string TextOut(Stationary n)
        {
            string s = $"Название компании: '{n.CompNameCompany}',\t Название: '{n.CompName}',\t Год: '{n.CompYear}',\t Вид: '{n.StationaryView}'";
            return s;
        }
    }

    public class Working : Server
    {
        private string _serverView;         //Виды стационарных компьютеров
        public string ServerView
        {
            get { return _serverView; }
            set { _serverView = value; }
        }

        public Working(string namecompany, string name, string price, string year, string proc, string formfactor, string ram, string drives, string views) : base(namecompany, name, price, year, proc, formfactor, ram, drives)
        {
            this.ServerView = views;
        }
        static public string TextOut(Stationary n)
        {
            string s = $"Название компании: '{n.CompNameCompany}',Название: '{n.CompName}',Год выпуска: '{n.CompYear}',Вид компьютера: '{n.StationaryView}'";
            return s;
        }
    }

}
