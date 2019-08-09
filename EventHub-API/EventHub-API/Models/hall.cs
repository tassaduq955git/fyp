//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EventHub_API.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class hall
    {
        public hall()
        {
            this.Bookings = new HashSet<Booking>();
        }
    
        public int companyID { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public Nullable<System.DateTime> startDate { get; set; }
        public Nullable<System.TimeSpan> totalTime { get; set; }
        public Nullable<int> streetNo { get; set; }
        public Nullable<int> houseNo { get; set; }
        public string townName { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public Nullable<int> price_per_head { get; set; }
        public Nullable<int> b_capacity { get; set; }
        public Nullable<int> p_capacity { get; set; }
        public string wifi { get; set; }
        public string dj { get; set; }
        public string b_mackup { get; set; }
        public Nullable<int> U_id { get; set; }
        public string chicken_main { get; set; }
        public string chicken_rice { get; set; }
        public string chicken_sweet { get; set; }
        public string chicken_starter { get; set; }
        public string mutton_main { get; set; }
        public string mutton_rice { get; set; }
        public string mutton_sweet { get; set; }
        public string mutton_starter { get; set; }
        public string beef_main { get; set; }
        public string beef_rice { get; set; }
        public string beef_sweet { get; set; }
        public string beef_starter { get; set; }
        public Nullable<int> chickenPrice { get; set; }
        public Nullable<int> muttonPrice { get; set; }
        public Nullable<int> beefPrice { get; set; }
    
        public virtual ICollection<Booking> Bookings { get; set; }
        public virtual User User { get; set; }
    }
}
