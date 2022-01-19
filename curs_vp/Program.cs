using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace curs_vp
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {

       
            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Главная_форма());


       
          
        }
        public class AllLists
        {
            List<Stationary> stationarys = new List<Stationary>();
            List<Portable> portables = new List<Portable>();
            List<PlayStation> playStations = new List<PlayStation>();
            List<Xbox> xboxs = new List<Xbox>();

            public List<Portable> Portables { get => portables; set => portables = value; }
        }




    }
}
