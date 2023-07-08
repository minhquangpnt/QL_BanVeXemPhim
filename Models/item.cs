using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiTapLonWeb.Models
{
    public class item
    {
        MovieDataContext db = new MovieDataContext();
        public string MaDD { get; set; }
        public string TenDD { get; set; }
        public string AnhDD { get; set; }
        public double GiaBan { get; set; }
        public int SoLuongMua { get; set; }
        public item(string mdd, int sl)
        {
            MaDD = mdd;
            Movy t = db.Movies.FirstOrDefault(i => i.MovieID == mdd);
            TenDD = t.MovieName;
            AnhDD = t.Image;
            GiaBan = Convert.ToDouble(t.Price.ToString());
            SoLuongMua = sl;
        }
        public double ThanhTien
        {
            get { return SoLuongMua * GiaBan; }
        }
    }
}