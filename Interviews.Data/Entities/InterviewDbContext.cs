using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Interviews.Data.Entities
{
    public partial class InterviewDbContext : DbContext
    {
        public InterviewDbContext()
        {
        }

        public InterviewDbContext(DbContextOptions<InterviewDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Applicants> Applicants { get; set; }
        public virtual DbSet<InterviewTypes> InterviewTypes { get; set; }
        public virtual DbSet<Interviews> Interviews { get; set; }
        public virtual DbSet<RecruiterProcessTechnologies> RecruiterProcessTechnologies { get; set; }
        public virtual DbSet<RecruiterProcesses> RecruiterProcesses { get; set; }
        public virtual DbSet<Technologies> Technologies { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-UN7E7G8\\SQLExpress;Database=interviewdb;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Applicants>(entity =>
            {
                entity.HasKey(e => e.ApplicantId);

                entity.Property(e => e.ApplicantId).ValueGeneratedNever();

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Street)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Suite)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InterviewTypes>(entity =>
            {
                entity.HasKey(e => e.InterviewTypeId);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Interviews>(entity =>
            {
                entity.HasKey(e => e.InterviewId)
                    .HasName("PK_Interviews_1");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Applicant)
                    .WithMany(p => p.Interviews)
                    .HasForeignKey(d => d.ApplicantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ApplicantId_Interviews");

                entity.HasOne(d => d.InterviewType)
                    .WithMany(p => p.Interviews)
                    .HasForeignKey(d => d.InterviewTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InterviewTypeId_Interviews");

                entity.HasOne(d => d.RecruiterProcess)
                    .WithMany(p => p.Interviews)
                    .HasForeignKey(d => d.RecruiterProcessId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RecruiterProcessId_Interviews");
            });

            modelBuilder.Entity<RecruiterProcessTechnologies>(entity =>
            {
                entity.HasKey(e => e.RecruiterProcessTechnologyId);

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.RecruiterProcess)
                    .WithMany(p => p.RecruiterProcessTechnologies)
                    .HasForeignKey(d => d.RecruiterProcessId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RecruiterProcessId_RecruiterProcessesTechnologies");

                entity.HasOne(d => d.Technology)
                    .WithMany(p => p.RecruiterProcessTechnologies)
                    .HasForeignKey(d => d.TechnologyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TechnologyId_RecruiterProcessesTechnologies");
            });

            modelBuilder.Entity<RecruiterProcesses>(entity =>
            {
                entity.HasKey(e => e.RecruiterProcessId)
                    .HasName("PK_Interviews");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.ParentTechnology)
                    .WithMany(p => p.RecruiterProcesses)
                    .HasForeignKey(d => d.ParentTechnologyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ParentTechnology_RecruiterProcess");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RecruiterProcesses)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserId_RecruiterProcesses");
            });

            modelBuilder.Entity<Technologies>(entity =>
            {
                entity.HasKey(e => e.TechnologyId);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Role)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });
        }
    }
}
