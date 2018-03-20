using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.SqlClient;


namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<Accommodations2> GetListSQL(string SqlQuery)
        {
            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = "Data Source=DESKTOP-575EBG3\\SQL2017;Initial Catalog=Uppgift3;Integrated Security=True"; //Lokal SQL källa.


            conn.Open();

            SqlCommand myQuery = new SqlCommand(SqlQuery, conn);

            SqlDataReader myReader = myQuery.ExecuteReader();

            List<Accommodations2> Accommodations = new List<Accommodations2>();


            while (myReader.Read())
            {


                int Room_id = Convert.ToInt32(myReader["Room_id"]);
                int Host_id = Convert.ToInt32(myReader["Host_id"]);
                string Room_type = (string)myReader["Room_type"];
                string Borough = myReader["borough"].ToString();
                string Neighborhood = (string)myReader["Neighborhood"];
                int Reviews = Convert.ToInt32(myReader["Reviews"]);
                double Overall_satisfaction = double.TryParse(myReader["Overall_satisfaction"].ToString(), out double OS) ? OS : 0;
                int Accommodates = Convert.ToInt32(myReader["Accommodates"]);
                double Bedrooms = double.TryParse(myReader["Bedrooms"].ToString(), out double BD) ? BD : 0;
                double Price = double.TryParse(myReader["Price"].ToString(), out double PR) ? PR : 0;
                double Minstay = double.TryParse(myReader["Minstay"].ToString(), out double MS) ? MS : 0;
                double Latitude = int.TryParse(myReader["Latitude"].ToString(), out int LT) ? LT : 0;
                double Longitude = int.TryParse(myReader["Longitude"].ToString(), out int LOT) ? LOT : 0;
                string Last_modified = myReader["Last_modified"].ToString();


                Accommodations.Add(new Accommodations2(Room_id,
                    Host_id,
                    Room_type,
                    Borough,
                    Neighborhood,
                    Reviews,
                    Overall_satisfaction,
                    Accommodates,
                    (int)Bedrooms,
                    (int)Price,
                    (int)Minstay,
                    Latitude,
                    Longitude,
                    Last_modified));

            }
            return Accommodations;
        }
        private void Form1_Load(object sender, EventArgs e)

            
        {


            List<Accommodations2> ListaBoston = GetListSQL("SELECT * FROM Boston WHERE Room_type = 'Private room'");
            List<Accommodations2> ListaAmsterdam = GetListSQL("SELECT * FROM Amsterdam WHERE Room_type = 'Private room'");
            List<Accommodations2> ListaBarcelona = GetListSQL("SELECT * FROM Barcelona WHERE Room_type = 'Private room'");
            List<Accommodations2> ListaBarcelona2 = GetListSQL("SELECT * FROM Barcelona WHERE Overall_Satisfaction <4.5");
            List<Accommodations2> ListaAmsterdam2 = GetListSQL("SELECT * FROM Amsterdam WHERE Overall_Satisfaction <4.5");
            List<Accommodations2> ListaBoston2 = GetListSQL("SELECT * FROM Boston WHERE Overall_Satisfaction <4.5");


            City Boston = new City ("Boston", 100000, 3000, ListaBoston);
            City Amsterdam = new City("Amsterdam", 500000, 5000, ListaAmsterdam);
            City Barcelona = new City("Barcelona", 200000, 7000, ListaBarcelona);

            List<City> Cities = new List<City> { Boston, Amsterdam, Barcelona };

            Country USA = new Country("USA", 400000000, 600000, Cities);
            Country Holland = new Country("Holland", 8000000, 300000, Cities);
            Country Spanien = new Country("Spanien", 25000000, 80000, Cities);


            foreach (Accommodations2 a in ListaBoston)
            {
                chart1.Series["Series1"].Points.AddY(a.Price);
            }

            chart1.Series["Series1"].ChartType = SeriesChartType.Column;
            chart1.Titles.Add("Boston");
            chart1.ChartAreas[0].AxisX.Title = "Rum";
            chart1.ChartAreas[0].AxisY.Title = "Pris";

            foreach (Accommodations2 a in ListaAmsterdam)
            {
                chart2.Series["Series1"].Points.AddY(a.Price);
            }

            chart2.Series["Series1"].ChartType = SeriesChartType.Column;
            chart2.Titles.Add("Amsterdam");
            chart2.ChartAreas[0].AxisX.Title = "Rum";
            chart2.ChartAreas[0].AxisY.Title = "Pris";

            foreach (Accommodations2 a in ListaBarcelona)
            {
                chart3.Series["Series1"].Points.AddY(a.Price);
            }

            chart3.Series["Series1"].ChartType = SeriesChartType.Column;
            chart3.Titles.Add("Barcelona");
            chart3.ChartAreas[0].AxisX.Title = "Rum";
            chart3.ChartAreas[0].AxisY.Title = "Pris";

            foreach (Accommodations2 a in ListaBoston2)
            {
                chart4.Series["Series1"].Points.AddXY(a.Price, a.Overall_satisfaction);
            }

            chart4.Series["Series1"].ChartType = SeriesChartType.Point;
            chart4.Titles.Add("Boston");
            chart4.ChartAreas[0].AxisX.Title = "Pris";
            chart4.ChartAreas[0].AxisY.Title = "Kund nöjdhet";

            foreach (Accommodations2 a in ListaAmsterdam2)
            {
                chart5.Series["Series1"].Points.AddXY(a.Price, a.Overall_satisfaction);
            }

            chart5.Series["Series1"].ChartType = SeriesChartType.Point;
            chart5.Titles.Add("Amsterdam");
            chart5.ChartAreas[0].AxisX.Title = "Pris";
            chart5.ChartAreas[0].AxisY.Title = "Kund nöjdhet";


            foreach (Accommodations2 a in ListaBarcelona2)
            {
                chart6.Series["Series1"].Points.AddXY(a.Price, a.Overall_satisfaction);
            }

            chart6.Series["Series1"].ChartType = SeriesChartType.Point;
            chart6.Titles.Add("Barcelona");
            chart6.ChartAreas[0].AxisX.Title = "Pris";
            chart6.ChartAreas[0].AxisY.Title = "Kund nöjdhet";






        }




    }

}
    


