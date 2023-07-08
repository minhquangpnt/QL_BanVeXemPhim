using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BaiTapLonWeb.Models;


namespace BaiTapLonWeb.Models
{
    public class GioHang
    {
        MovieDataContext db = new MovieDataContext();
        public string MaPhim { get; set; }
        public string TenPhim { get; set; }
        public string AnhBia { get; set; }
        public double Gia { get; set; }
        public int SoLuong { get; set; }
        public double ThanhTien
        {
            get { return SoLuong * Gia; }
        }
        public GioHang (string maphim)
        {
            MaPhim = maphim;
            Movy phim = db.Movies.Single(n => n.MovieID == MaPhim);
            TenPhim = phim.MovieName;
            AnhBia = phim.Image;
            Gia = double.Parse(phim.Price.ToString());
            SoLuong = 1;

        }
    }
}