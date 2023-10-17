using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DAL.Data
{
    public class EntityDatabase : DbContext
    {
        public DbSet<AccountModel> Accounts { get; set; }
        public DbSet<UserModel> Users { get; set; }
        public DbSet<GameModel> Games { get; set; }
        public DbSet<OrderModel> Orders { get; set; }
        public DbSet<CompanyModel> Companies { get; set; }
        public DbSet<SettingsModel> SettingsModel { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS01;Database=SteamSupreme;Trusted_Connection=True;");
        }
    }
}
