﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GuestEaseHMS
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class guesteaseEntities15 : DbContext
    {
        public guesteaseEntities15()
            : base("name=guesteaseEntities15")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<admin> admins { get; set; }
        public virtual DbSet<billingdetl> billingdetls { get; set; }
        public virtual DbSet<customerdetl> customerdetls { get; set; }
        public virtual DbSet<receptionistdetl> receptionistdetls { get; set; }
        public virtual DbSet<reservdetl> reservdetls { get; set; }
        public virtual DbSet<roomdetl> roomdetls { get; set; }
    }
}
