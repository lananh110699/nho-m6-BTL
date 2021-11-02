using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace nhóm6_BTL.Models
{
    public partial class QuanLyKhoDBContext : DbContext
    {
        public QuanLyKhoDBContext()
            : base("name=QuanLyKhoDBContext")
        {
        }

        public virtual DbSet<DangNhap> DangNhaps { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DangNhap>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<DangNhap>()
                .Property(e => e.Password)
                .IsUnicode(false);
        }
    }
}
