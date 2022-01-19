using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace curs_vp
{
    [Serializable]
    abstract public class Comp
    {
        private string _compNameCompany;
        private string _compName;
        private string _compPrice;
        private string _compYear;
        public string CompNameCompany
        {
            get { return _compNameCompany; }
            set { _compNameCompany = value; }
        }
        public string CompName
        {
            get { return _compName; }
            set { _compName = value; }
        }
        public string CompPrice
        {
            get { return _compPrice; }
            set { _compPrice = value; }
        }
        public string CompYear
        {
            get { return _compYear; }
            set { _compYear = value; }
        }
        public Comp()
        { }
        public Comp(string namecompany, string name, string price, string year)
        {
            _compNameCompany = namecompany;
            _compName = name;
            _compPrice = price;
            _compYear = year;
        }
    }


}