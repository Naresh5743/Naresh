using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EPassport.Models
{
    public partial class EPassportContext : DbContext
    {
        public EPassportContext()
        {
        }

        public EPassportContext(DbContextOptions<EPassportContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AddressDetail> AddressDetails { get; set; } = null!;
        public virtual DbSet<ApplicationDetail> ApplicationDetails { get; set; } = null!;
        public virtual DbSet<AppointmentDetail> AppointmentDetails { get; set; } = null!;
        public virtual DbSet<FamilyDetail> FamilyDetails { get; set; } = null!;
        public virtual DbSet<LoginCredential> LoginCredentials { get; set; } = null!;
        public virtual DbSet<PassportOffice> PassportOffices { get; set; } = null!;
        public virtual DbSet<ReferenceDetail> ReferenceDetails { get; set; } = null!;
        public virtual DbSet<RegistrationDetail> RegistrationDetails { get; set; } = null!;
        public virtual DbSet<SupportingDocumentDetail> SupportingDocumentDetails { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AddressDetail>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ApplicantId).HasColumnName("ApplicantID");

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.District).HasMaxLength(50);

                entity.Property(e => e.EmailId)
                    .HasMaxLength(50)
                    .HasColumnName("EmailID");

                entity.Property(e => e.HouseNo).HasMaxLength(50);

                entity.Property(e => e.State).HasMaxLength(50);

                entity.Property(e => e.StreetName).HasMaxLength(50);

                entity.Property(e => e.TelephoneNumber).HasMaxLength(50);

                entity.HasOne(d => d.Applicant)
                    .WithMany(p => p.AddressDetails)
                    .HasForeignKey(d => d.ApplicantId)
                    .HasConstraintName("FK_AddressDetails_ApplicationDetails");
            });

            modelBuilder.Entity<ApplicationDetail>(entity =>
            {
                entity.HasKey(e => e.ApplicantId);

                entity.Property(e => e.ApplicantId)
                    .ValueGeneratedNever()
                    .HasColumnName("ApplicantID");

                entity.Property(e => e.District).HasMaxLength(50);

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("DOB");

                entity.Property(e => e.EducationalQualification).HasMaxLength(50);

                entity.Property(e => e.EmploymentType).HasMaxLength(50);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.Gender).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.LoginId)
                    .HasMaxLength(50)
                    .HasColumnName("LoginID");

                entity.Property(e => e.MaritalStatus).HasMaxLength(50);

                entity.Property(e => e.Pan)
                    .HasMaxLength(50)
                    .HasColumnName("PAN");

                entity.Property(e => e.PlaceOfBirth).HasMaxLength(50);

                entity.Property(e => e.State).HasMaxLength(50);

                entity.HasOne(d => d.Login)
                    .WithMany(p => p.ApplicationDetails)
                    .HasForeignKey(d => d.LoginId)
                    .HasConstraintName("FK_ApplicationDetails_RegistrationDetails");
            });

            modelBuilder.Entity<AppointmentDetail>(entity =>
            {
                entity.HasKey(e => e.MonthId);

                entity.Property(e => e.MonthId)
                    .ValueGeneratedNever()
                    .HasColumnName("MonthID");

                entity.Property(e => e.ApplicantId).HasColumnName("ApplicantID");

                entity.Property(e => e.AvailableDays).HasMaxLength(50);

                entity.Property(e => e.MonthName).HasMaxLength(50);

                entity.Property(e => e.TimeSlots).HasMaxLength(50);

                entity.HasOne(d => d.Applicant)
                    .WithMany(p => p.AppointmentDetails)
                    .HasForeignKey(d => d.ApplicantId)
                    .HasConstraintName("FK_AppointmentDetails_ApplicationDetails");
            });

            modelBuilder.Entity<FamilyDetail>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ApplicantId).HasColumnName("ApplicantID");

                entity.Property(e => e.FathersName).HasMaxLength(50);

                entity.Property(e => e.MothersName).HasMaxLength(50);

                entity.HasOne(d => d.Applicant)
                    .WithMany(p => p.FamilyDetails)
                    .HasForeignKey(d => d.ApplicantId)
                    .HasConstraintName("FK_FamilyDetails_ApplicationDetails");
            });

            modelBuilder.Entity<LoginCredential>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.LoginId)
                    .HasMaxLength(50)
                    .HasColumnName("LoginID");

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.UserType).HasMaxLength(50);

                entity.HasOne(d => d.Login)
                    .WithMany()
                    .HasForeignKey(d => d.LoginId)
                    .HasConstraintName("FK_LoginCredentials_RegistrationDetails");
            });

            modelBuilder.Entity<PassportOffice>(entity =>
            {
                entity.HasKey(e => e.OfficeId);

                entity.ToTable("PassportOffice");

                entity.Property(e => e.OfficeId)
                    .ValueGeneratedNever()
                    .HasColumnName("OfficeID");

                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.ApplicantId).HasColumnName("ApplicantID");

                entity.Property(e => e.Jurisdiction).HasMaxLength(50);

                entity.Property(e => e.OfficeName).HasMaxLength(50);

                entity.Property(e => e.PhoneNumber).HasMaxLength(50);

                entity.HasOne(d => d.Applicant)
                    .WithMany(p => p.PassportOffices)
                    .HasForeignKey(d => d.ApplicantId)
                    .HasConstraintName("FK_PassportOffice_ApplicationDetails");
            });

            modelBuilder.Entity<ReferenceDetail>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.ApplicantId).HasColumnName("ApplicantID");

                entity.Property(e => e.ReferenceName).HasMaxLength(50);

                entity.Property(e => e.TelephoneNumber).HasMaxLength(50);

                entity.HasOne(d => d.Applicant)
                    .WithMany(p => p.ReferenceDetails)
                    .HasForeignKey(d => d.ApplicantId)
                    .HasConstraintName("FK_ReferenceDetails_ApplicationDetails");
            });

            modelBuilder.Entity<RegistrationDetail>(entity =>
            {
                entity.HasKey(e => e.LoginId);

                entity.Property(e => e.LoginId)
                    .HasMaxLength(50)
                    .HasColumnName("LoginID");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("DOB");

                entity.Property(e => e.EmailId)
                    .HasMaxLength(50)
                    .HasColumnName("EmailID");

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.Gender).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.PhoneNo).HasMaxLength(50);
            });

            modelBuilder.Entity<SupportingDocumentDetail>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ApplicantId).HasColumnName("ApplicantID");

                entity.HasOne(d => d.Applicant)
                    .WithMany(p => p.SupportingDocumentDetails)
                    .HasForeignKey(d => d.ApplicantId)
                    .HasConstraintName("FK_SupportingDocumentDetails_ApplicationDetails");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
