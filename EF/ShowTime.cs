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
    
    public partial class ShowTime
    {
        public ShowTime()
        {
            this.Tickets = new HashSet<Ticket>();
        }
    
        public string ShowTimeID { get; set; }
        public Nullable<System.DateTime> ShowTime1 { get; set; }
        public string RoomID { get; set; }
        public string MovieID { get; set; }
    
        public virtual Movie Movy { get; set; }
        public virtual Room Room { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
