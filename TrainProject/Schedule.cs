//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TrainProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class Schedule
    {
        public Schedule()
        {
            this.StopsAscs = new HashSet<StopsAsc>();
            this.Tickets = new HashSet<Ticket>();
        }
    
        public int TrainRouteID { get; set; }
    
        public virtual Train TrainID { get; set; }
        public virtual ICollection<StopsAsc> StopsAscs { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
