using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class Country
    {
        private string namn;
        private int antalinvånare;
        private int bnppercapita;
        private List<City> cities;



        public Country(string Namn, int Antalinvånare, int Bnppercapita, List<City> Cities)
        {
            namn = Namn;
            antalinvånare = Antalinvånare;
            bnppercapita = Bnppercapita;
            cities = Cities;
        }

        public string Namn { get => namn; set => namn = value; }
        public int Antalinvånare { get => antalinvånare; set => antalinvånare = value; }
        public int Bnppercapita { get => bnppercapita; set => bnppercapita = value; }
        internal List<City> Cities { get => cities; set => cities = value; }


    }
}
