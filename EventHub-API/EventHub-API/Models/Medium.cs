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
    
    public partial class Medium
    {
        public Medium()
        {
            this.BookingMedias = new HashSet<BookingMedia>();
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
        public Nullable<bool> droneCamera { get; set; }
        public Nullable<bool> hdCam { get; set; }
        public Nullable<int> noOfCams { get; set; }
        public Nullable<bool> albums { get; set; }
        public Nullable<bool> photoGraphy { get; set; }
        public Nullable<bool> filmGraphy { get; set; }
        public Nullable<int> U_id { get; set; }
        public Nullable<int> CamsOne { get; set; }
        public Nullable<int> PriceOne { get; set; }
        public Nullable<int> DroneOne { get; set; }
        public Nullable<int> AlbumOne { get; set; }
        public Nullable<int> CamsTwo { get; set; }
        public Nullable<int> PriceTwo { get; set; }
        public Nullable<int> DroneTwo { get; set; }
        public Nullable<int> AlbumTwo { get; set; }
        public Nullable<int> CamsThree { get; set; }
        public Nullable<int> PriceThree { get; set; }
        public Nullable<int> DroneThree { get; set; }
        public Nullable<int> AlbumThree { get; set; }
    
        public virtual ICollection<BookingMedia> BookingMedias { get; set; }
        public virtual User User { get; set; }
    }
}
