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
    
    public partial class Room
    {
        public Room()
        {
            this.Movies = new HashSet<Movie>();
            this.ShowTimes = new HashSet<ShowTime>();
        }
    
        public string RoomID { get; set; }
        public string RoomName { get; set; }
        public string KindRoom { get; set; }
        public Nullable<int> NumberSeats { get; set; }
    
        public virtual ICollection<Movie> Movies { get; set; }
        public virtual ICollection<ShowTime> ShowTimes { get; set; }
    }
}
