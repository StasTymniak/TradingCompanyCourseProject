using DTO;
using Microsoft.EntityFrameworkCore;
using System;

namespace DAL.EntityFramework
{
    public class TradingCompanyContext : DbContext
    {
        public DbSet<CategoryDTO> Categories { get; set; }
        public DbSet<ProductDTO> Products { get; set; }
        public DbSet<AuctionDTO> Auctions { get; set; }
        public TradingCompanyContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            try
            {
                optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=tradingCompany;Trusted_Connection=True;");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

        }
    }
}
