﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JOBPORTAL.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class JOB_PORTAL_3Entities : DbContext
    {
        public JOB_PORTAL_3Entities()
            : base("name=JOB_PORTAL_3Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Employer> Employers { get; set; }
        public virtual DbSet<EmployerSelectsSeeker> EmployerSelectsSeekers { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<JobAppoinment> JobAppoinments { get; set; }
        public virtual DbSet<JobCategory> JobCategories { get; set; }
        public virtual DbSet<JobSeeked> JobSeekeds { get; set; }
        public virtual DbSet<JobSeeker> JobSeekers { get; set; }
        public virtual DbSet<Resume> Resumes { get; set; }
        public virtual DbSet<ContactU> ContactUs { get; set; }
    }
}
