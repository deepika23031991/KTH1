﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CandidateApplication.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CandidateContext : DbContext
    {
        public CandidateContext()
            : base("name=CandidateContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Candidate> Candidates { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<Outcome> Outcomes { get; set; }
        public virtual DbSet<SubOutcome> SubOutcomes { get; set; }
    }
}