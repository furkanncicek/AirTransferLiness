﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AirTransferLines.Dall
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AirTransferLinessDBEntities : DbContext
    {
        public AirTransferLinessDBEntities()
            : base("name=AirTransferLinessDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Acente> Acente { get; set; }
        public virtual DbSet<Arac> Arac { get; set; }
        public virtual DbSet<Dil> Dil { get; set; }
        public virtual DbSet<Rezervasyon> Rezervasyon { get; set; }
        public virtual DbSet<Sehir> Sehir { get; set; }
        public virtual DbSet<Surucu> Surucu { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Transfer> Transfer { get; set; }
        public virtual DbSet<Ulke> Ulke { get; set; }
        public virtual DbSet<Uye> Uye { get; set; }
    }
}