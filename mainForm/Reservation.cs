//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mainForm
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reservation
    {
        public string ReservationID { get; set; }
        public int BookID { get; set; }
        public string MemberID { get; set; }
        public System.DateTime ReservedOn { get; set; }
        public System.DateTime ReservedUntil { get; set; }
        public string ReservationStatus { get; set; }
        public string Remarks { get; set; }
    
        public virtual Book Book { get; set; }
        public virtual Member Member { get; set; }
    }
}
