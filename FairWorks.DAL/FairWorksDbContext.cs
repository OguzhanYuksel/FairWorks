using System;
using System.Collections.Generic;
using System.Text;
using FairWorks.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace FairWorks.DAL
{
    public class FairWorksDbContext : DbContext
    {
        public FairWorksDbContext(DbContextOptions<FairWorksDbContext> options) : base(options)
        {
        }
        public FairWorksDbContext()
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=FairWorksDb;Trusted_Connection=True;");
        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<CompanyProfile> CompanyProfiles { get; set; }
        public DbSet<CompanyCompanyProfile> CompanyCompanyProfiles { get; set; }
        public DbSet<CompanySector> CompanySectors { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<ContractType> ContractTypes { get; set; }
        public DbSet<Fair> Fairs { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Interview> Interviews { get; set; }
        public DbSet<Interviewer> Interviewers { get; set; }
        public DbSet<InterviewFair> InterviewFairs { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<ParticipantHandBook> ParticipantHandBooks { get; set; }
        public DbSet<Personel> Personels { get; set; }
        public DbSet<PersonelType> PersonelTypes { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductGroup> ProductGroups { get; set; }
        public DbSet<SalesPerson> SalesPersons { get; set; }
        public DbSet<Salon> Salons { get; set; }
        public DbSet<Sector> Sectors { get; set; }
        public DbSet<Stand> Stands { get; set; }
        public DbSet<StandType> StandTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CompanyCompanyProfile>()
                .HasKey(ccp => new { ccp.CompanyId, ccp.CompanyProfileId });
            modelBuilder.Entity<CompanyCompanyProfile>()
                .HasOne(ccp => ccp.Company)
                .WithMany(ccp => ccp.CompanyCompanyProfiles)
                .HasForeignKey(ccp => ccp.CompanyId);
            modelBuilder.Entity<CompanyCompanyProfile>()
                .HasOne(ccp => ccp.CompanyProfile)
                .WithMany(ccp => ccp.CompanyCompanyProfiles)
                .HasForeignKey(ccp => ccp.CompanyProfileId);

            modelBuilder.Entity<CompanySector>()
                .HasKey(cs => new { cs.CompanyId, cs.SectorId });
            modelBuilder.Entity<CompanySector>()
                .HasOne(cs => cs.Company)
                .WithMany(cs => cs.CompanySectors)
                .HasForeignKey(cs => cs.CompanyId);
            modelBuilder.Entity<CompanySector>()
                .HasOne(cs => cs.Sector)
                .WithMany(cs => cs.CompanySectors)
                .HasForeignKey(cs => cs.SectorId);

            modelBuilder.Entity<Company>()
                .HasMany(c => c.Contracts)
                .WithOne(con => con.Company);

            modelBuilder.Entity<Contract>()
                .HasOne(con => con.Company)
                .WithMany(c => c.Contracts);

            modelBuilder.Entity<Contract>()
                .HasOne(con => con.Company)
                .WithMany(c => c.Contracts);

            modelBuilder.Entity<Contract>()
                .HasOne(con => con.ContractType);

            modelBuilder.Entity<Contract>()
                .HasOne(con => con.Stand)
                .WithOne(s => s.Contract)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Fair>()
                .HasMany(f => f.Salons)
                .WithOne(s => s.Fair)
                .HasForeignKey(s => s.FairId);

            modelBuilder.Entity<Salon>()
                .HasOne(s => s.Fair)
                .WithMany(f => f.Salons)
                .HasForeignKey(s => s.FairId);

            modelBuilder.Entity<Salon>()
                .HasMany(s => s.Stands)
                .WithOne(st => st.Salon)
                .HasForeignKey(st => st.SalonId);

            modelBuilder.Entity<Salon>()
                .HasOne(s => s.Sector);

            modelBuilder.Entity<Stand>()
                .HasOne(st => st.Salon)
                .WithMany(s => s.Stands)
                .HasForeignKey(st => st.SalonId);

            modelBuilder.Entity<Stand>()
                .HasOne(st => st.StandType);

            modelBuilder.Entity<Stand>()
                .HasOne(st => st.Company);

            modelBuilder.Entity<Interview>()
                .HasOne(i => i.SalesPerson)
                .WithMany(sp => sp.Interviews)
                .HasForeignKey(i => i.SalesPersonId);

            modelBuilder.Entity<Interview>()
                .HasOne(i => i.Interviewer)
                .WithMany(iv => iv.Interviews)
                .HasForeignKey(i => i.InterviewerId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Interview>()
               .HasOne(i => i.Sector);

            modelBuilder.Entity<Interview>()
                .HasOne(i => i.Salon);

            modelBuilder.Entity<Interview>()
                .HasOne(i => i.CompanyProfile);

            modelBuilder.Entity<Interview>()
                .HasOne(i => i.Company);

            modelBuilder.Entity<Interviewer>()
                .HasMany(iv => iv.Interviews)
                .WithOne(i => i.Interviewer)
                .HasForeignKey(i => i.InterviewerId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Interviewer>()
               .HasMany(iv => iv.Contracts)
               .WithOne(c => c.Interviewer)
               .HasForeignKey(c => c.InterviewerId)
               .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<SalesPerson>()
                .HasMany(sp => sp.Interviews)
                .WithOne(i => i.SalesPerson)
                .HasForeignKey(i => i.SalesPersonId);

            modelBuilder.Entity<InterviewFair>()
                .HasKey(ivf => new { ivf.InterviewId, ivf.FairId });
            modelBuilder.Entity<InterviewFair>()
                .HasOne(ivf => ivf.Interview)
                .WithMany(i => i.InterviewFairs)
                .HasForeignKey(ivf => ivf.InterviewId)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<InterviewFair>()
                .HasOne(ivf => ivf.Fair)
                .WithMany(f => f.InterviewFairs)
                .HasForeignKey(ivf => ivf.FairId)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<InterviewFair>()
                .HasOne(ivf => ivf.Company);
        }
    }
}
