﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class EventHubEntities : DbContext
    {
        public EventHubEntities()
            : base("name=EventHubEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<BookingMedia> BookingMedias { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Caterer> Caterers { get; set; }
        public DbSet<CatererBooking> CatererBookings { get; set; }
        public DbSet<Check> Checks { get; set; }
        public DbSet<hall> halls { get; set; }
        public DbSet<Medium> Media { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<User> Users { get; set; }
    
        public virtual ObjectResult<CustomerApprovedRequests_Result> CustomerApprovedRequests(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CustomerApprovedRequests_Result>("CustomerApprovedRequests", idParameter);
        }
    
        public virtual ObjectResult<CustomerApprovedRequestsMedia_Result> CustomerApprovedRequestsMedia(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CustomerApprovedRequestsMedia_Result>("CustomerApprovedRequestsMedia", idParameter);
        }
    
        public virtual ObjectResult<CustomerCompletedRequests_Result> CustomerCompletedRequests(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CustomerCompletedRequests_Result>("CustomerCompletedRequests", idParameter);
        }
    
        public virtual ObjectResult<CustomerCompletedRequestsCaterer_Result> CustomerCompletedRequestsCaterer(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CustomerCompletedRequestsCaterer_Result>("CustomerCompletedRequestsCaterer", idParameter);
        }
    
        public virtual ObjectResult<CustomerCompletedRequestsMedia_Result> CustomerCompletedRequestsMedia(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CustomerCompletedRequestsMedia_Result>("CustomerCompletedRequestsMedia", idParameter);
        }
    
        public virtual ObjectResult<CustomerContinueRequestsCaterer_Result> CustomerContinueRequestsCaterer(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CustomerContinueRequestsCaterer_Result>("CustomerContinueRequestsCaterer", idParameter);
        }
    
        public virtual ObjectResult<CustomerPendingRequestsCaterer_Result> CustomerPendingRequestsCaterer(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CustomerPendingRequestsCaterer_Result>("CustomerPendingRequestsCaterer", idParameter);
        }
    
        public virtual ObjectResult<CustomerPendingRequestsMedia_Result> CustomerPendingRequestsMedia(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CustomerPendingRequestsMedia_Result>("CustomerPendingRequestsMedia", idParameter);
        }
    
        public virtual ObjectResult<CutomerPendingRequests_Result> CutomerPendingRequests(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CutomerPendingRequests_Result>("CutomerPendingRequests", idParameter);
        }
    
        public virtual ObjectResult<CutomerReview_Result> CutomerReview(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CutomerReview_Result>("CutomerReview", idParameter);
        }
    
        public virtual ObjectResult<GetCaterer_Result> GetCaterer()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetCaterer_Result>("GetCaterer");
        }
    
        public virtual ObjectResult<GetHalls_Result> GetHalls()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetHalls_Result>("GetHalls");
        }
    
        public virtual ObjectResult<GetMedia_Result> GetMedia()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetMedia_Result>("GetMedia");
        }
    
        public virtual ObjectResult<GetUser_Result> GetUser()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetUser_Result>("GetUser");
        }
    
        public virtual ObjectResult<OwnerApprovedReqquests_Result> OwnerApprovedReqquests(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<OwnerApprovedReqquests_Result>("OwnerApprovedReqquests", idParameter);
        }
    
        public virtual ObjectResult<OwnerApprovedReqquestsMedia_Result> OwnerApprovedReqquestsMedia(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<OwnerApprovedReqquestsMedia_Result>("OwnerApprovedReqquestsMedia", idParameter);
        }
    
        public virtual ObjectResult<OwnerCompletedReqquests_Result> OwnerCompletedReqquests(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<OwnerCompletedReqquests_Result>("OwnerCompletedReqquests", idParameter);
        }
    
        public virtual ObjectResult<OwnerCompletedReqquestsCaterer_Result> OwnerCompletedReqquestsCaterer(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<OwnerCompletedReqquestsCaterer_Result>("OwnerCompletedReqquestsCaterer", idParameter);
        }
    
        public virtual ObjectResult<OwnerCompletedReqquestsMedia_Result> OwnerCompletedReqquestsMedia(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<OwnerCompletedReqquestsMedia_Result>("OwnerCompletedReqquestsMedia", idParameter);
        }
    
        public virtual ObjectResult<OwnerContinueReqquestsCaterer_Result> OwnerContinueReqquestsCaterer(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<OwnerContinueReqquestsCaterer_Result>("OwnerContinueReqquestsCaterer", idParameter);
        }
    
        public virtual ObjectResult<OwnerIndex_Result> OwnerIndex(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<OwnerIndex_Result>("OwnerIndex", idParameter);
        }
    
        public virtual ObjectResult<OwnerIndexCaterer_Result> OwnerIndexCaterer(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<OwnerIndexCaterer_Result>("OwnerIndexCaterer", idParameter);
        }
    
        public virtual ObjectResult<OwnerIndexMedia_Result> OwnerIndexMedia(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<OwnerIndexMedia_Result>("OwnerIndexMedia", idParameter);
        }
    
        public virtual ObjectResult<OwnerPendingReqquests_Result> OwnerPendingReqquests(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<OwnerPendingReqquests_Result>("OwnerPendingReqquests", idParameter);
        }
    
        public virtual ObjectResult<OwnerPendingReqquestsCaterer_Result> OwnerPendingReqquestsCaterer(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<OwnerPendingReqquestsCaterer_Result>("OwnerPendingReqquestsCaterer", idParameter);
        }
    
        public virtual ObjectResult<OwnerPendingReqquestsMedia_Result> OwnerPendingReqquestsMedia(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<OwnerPendingReqquestsMedia_Result>("OwnerPendingReqquestsMedia", idParameter);
        }
    
        public virtual ObjectResult<UserIndex_Result> UserIndex(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UserIndex_Result>("UserIndex", idParameter);
        }
    
        public virtual ObjectResult<UserIndexCaterer_Result> UserIndexCaterer(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UserIndexCaterer_Result>("UserIndexCaterer", idParameter);
        }
    
        public virtual ObjectResult<UserIndexMedia_Result> UserIndexMedia(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UserIndexMedia_Result>("UserIndexMedia", idParameter);
        }
    
        public virtual ObjectResult<UserLogin_Result> UserLogin(string email, string password)
        {
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UserLogin_Result>("UserLogin", emailParameter, passwordParameter);
        }
    }
}
