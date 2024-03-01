using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using WelcomeToTheClub.Models;
using Microsoft.EntityFrameworkCore;

namespace WelcomeToTheClub.Controllers
{
    // В этом классе находится логика работы с базой данных
    public class DataBaseController: DbContext
    {
        public DbSet<UserModel> users { get; set; } = null!;
        public DbSet<RoleModel> roles { get; set; } = null!;
        public DbSet<CompanyModel> companies { get; set; } = null!;

        public DataBaseController()
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserModel>().HasKey(u => u.user_id);
            modelBuilder.Entity<RoleModel>().HasKey(u => u.role_id);
            modelBuilder.Entity<CompanyModel>().HasKey(u => u.company_id);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=project;Username=postgres;Password=1234");
        }

        
    }
}
