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
        private DbSet<UserModel> users { get; set; } = null!;
        private DbSet<RoleModel> roles { get; set; } = null!;
        private DbSet<CompanyModel> companies { get; set; } = null!;

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

        public List<CompanyModel> SelectCompanies()
        {
            return companies.ToList();
        }

        public List<RoleModel> Roles()
        {
            return roles.ToList();
        }

        public List<UserModel> SelectUsers()
        {
            return users.ToList();
        }

        public void RegistrUser(UserModel user)
        {
            users.Add(user);
            SaveChanges();
        }

        public void RegistrCompany(CompanyModel company)
        {
            companies.Add(company);
            SaveChanges();
        }
    }
}
