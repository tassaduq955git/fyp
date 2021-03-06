using System;

namespace coreProject.Controllers.Resources
{
    public class CatererBookingResources
    {
        public int BId { get; set; }
        public string PrefferedTime { get; set; }
        public int? NoOfDays { get; set; }
        public DateTime? EventDate { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public int? CompanyId { get; set; }
        public int? Status { get; set; }
        public int? Packege { get; set; }
        public int? UId { get; set; }
        public int? StarToCustomer { get; set; }
        public int? StarToOwner { get; set; }
        public string ReviewToCustomer { get; set; }
        public string ReviewToOwner { get; set; }

        public CatererResources Company { get; set; }
        public UserResources U { get; set; }
    }
}