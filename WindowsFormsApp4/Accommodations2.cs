using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class Accommodations2
    {
        
        
        private int room_id;
        private int host_id;
        private string room_type;
        private string borough;
        private string neighbourhood;
        private int reviews;
        private double overall_satisfaction;
        private int accommodates;
        private int bedrooms;
        private int price;
        private int minstay;
        private double latitude;
        private double longitude;
        private string last_modified;


        public Accommodations2(int Room_id, int Host_id, string Room_type, string Borough, string Neighbourhood, int Reviews, double Overall_satisfaction, int Accommodates, int Bedrooms, int Price, int Minstay, double Latitude, double Longitude, string Last_modified)
        {
            room_type = Room_type;
            host_id = Host_id;
            room_type = Room_type;
            borough = Borough;
            neighbourhood = Neighbourhood;
            reviews = Reviews;
            overall_satisfaction = Overall_satisfaction;
            accommodates = Accommodates;
            bedrooms = Bedrooms;
            price = Price;
            minstay = Minstay;
            latitude = Latitude;
            longitude = Longitude;
            last_modified = Last_modified;

        }



        public int Room_id { get => room_id; set => room_id = value; }
        public int Host_id { get => host_id; set => host_id = value; }
        public string Room_type { get => room_type; set => room_type = value; }
        public string Borough { get => borough; set => borough = value; }
        public string Neighbourhood { get => neighbourhood; set => neighbourhood = value; }
        public int Reviews { get => reviews; set => reviews = value; }
        public double Overall_satisfaction { get => overall_satisfaction; set => overall_satisfaction = value; }
        public int Accommodates { get => accommodates; set => accommodates = value; }
        public int Bedrooms { get => bedrooms; set => bedrooms = value; }
        public int Price { get => price; set => price = value; }
        public int Minstay { get => minstay; set => minstay = value; }
        public double Latitude { get => latitude; set => latitude = value; }
        public double Longitude { get => longitude; set => longitude = value; }
        public string Last_modified { get => last_modified; set => last_modified = value; }



    }
}
   
