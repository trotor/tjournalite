﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TJournal
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class tjournalEntities : DbContext
    {
        public tjournalEntities()
            : base("name=tjournalEntities")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tj_mouse> tj_mouse { get; set; }
        public virtual DbSet<tj_programs> tj_programs { get; set; }
        public virtual DbSet<tj_blog> tj_blog { get; set; }
    }
}
