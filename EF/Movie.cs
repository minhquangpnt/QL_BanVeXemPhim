//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BaiTapLonWeb.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Movie
    {
        public Movie()
        {
            this.ShowTimes = new HashSet<ShowTime>();
        }
    
        public string MovieID { get; set; }
        public string MovieName { get; set; }
        public string CategoryID { get; set; }
        public string RoomID { get; set; }
        public string Director { get; set; }
        public string Trailer { get; set; }
        public Nullable<float> Price { get; set; }
        public string Image { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual Room Room { get; set; }
        public virtual ICollection<ShowTime> ShowTimes { get; set; }
    }
}
