﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DEV0102
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DEV0102Entities : DbContext
    {
        public DEV0102Entities()
            : base("name=DEV0102Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tabUsuario> tabUsuario { get; set; }
        public virtual DbSet<tabXml> tabXml { get; set; }
        public virtual DbSet<TB_VENDAS_NF> TB_VENDAS_NF { get; set; }
    }
}