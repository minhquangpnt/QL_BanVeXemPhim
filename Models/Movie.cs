using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
namespace BaiTapLonWeb.Models
{
    public class Movie
    {
        public String MovieID { get; set; }
        public String MovieName { get; set; }
        public Int32 Price { get; set; }
        public String Image { get; set; }


        public List<Movie> Movies(string keyword)
        {
            List<Movie> danhmucMovie = new List<Movie>();
            String connectString = "Data Source=LAPTOP-SDLMECNT\\SQLEXPRESS;Initial Catalog=MovieTickets;Integrated Security=True";
            SqlConnection connect = new SqlConnection(connectString);
            connect.Open();

            String sql = "select * from Movies ";
            SqlCommand comm = new SqlCommand();
            comm.Connection = connect;
            comm.CommandText = sql;

            SqlDataReader rd = comm.ExecuteReader();
            while (rd.Read())
            {
                danhmucMovie.Add(new Movie
                {
                    MovieID = rd["MovieID"].ToString(),
                    MovieName = rd["MovieName"].ToString(),
                    Price = Convert.ToInt32(rd["Price"]),
                    Image = rd["Image"].ToString()
                   
                });
            }
            return danhmucMovie;
        }

    }
}