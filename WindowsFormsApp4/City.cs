using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class City
    {
        private string namn;
        private int antalinvånare;
        private int medelinkomstperinvånare;
        private int antalturisterperår;
        private List<Accommodations2> accommodations;
        private int antalaccomodations;
        private double medelkostnadförennatt;



        //Construktor
        public City(string Namn, int Antalinvånare, int Antalturisterperår, List<Accommodations2> Accommodations)
        {
            namn = Namn;
            antalinvånare = Antalinvånare;
            antalturisterperår = Antalturisterperår;
            medelinkomstperinvånare = antalinvånare*antalturisterperår;
            accommodations = Accommodations;
            antalaccomodations = accommodations.Count;
            medelkostnadförennatt = accommodations.Average(x => x.Price);
      

        }

     

        public string Namn { get => namn; set => namn = value; }
        public int Antalinvånare { get => antalinvånare; set => antalinvånare = value; }
        public int Medelinkomstperinvånare { get => medelinkomstperinvånare; set => medelinkomstperinvånare = value; }
        public int Antalturisterperår { get => antalturisterperår; set => antalturisterperår = value; }
        internal List<Accommodations2> Accommodations { get => accommodations; set => accommodations = value; }
        public int Antalaccomodations { get => antalaccomodations; set => antalaccomodations = value; }
        public double Medelkostnadförennatt { get => medelkostnadförennatt; set => medelkostnadförennatt = value; }

    }

}

