using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace API_StoreUserLogin.Models
{
    public partial class SGAContext : DbContext
    {
        public SGAContext()
        {
        }

        public SGAContext(DbContextOptions<SGAContext> options)
            : base(options)
        {
        }

        public virtual DbSet<UsersLogin> UsersLogins { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=192.168.56.101; Database=SGA; Trusted_Connection=false; User=sa; Password = 123456");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<UsersLogin>(entity =>
            {
                entity.ToTable("usersLogin");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IPAddress");

                entity.Property(e => e.LoginDate)
                    .HasColumnType("datetime")
                    .HasColumnName("loginDate");

                entity.Property(e => e.Source)
                    .IsUnicode(false)
                    .HasColumnName("source");

                entity.Property(e => e.Username)
                    .IsUnicode(false)
                    .HasColumnName("username");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
