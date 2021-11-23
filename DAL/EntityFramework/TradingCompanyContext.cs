using System;

using Microsoft.EntityFrameworkCore;

using DTO;

namespace DAL.EntityFramework
{
    public class TradingCompanyContext : DbContext
    {
        private string _connStr { get; set; }

        public DbSet<CategoryDTO> Categories { get; set; }
        public DbSet<ProductDTO> Products { get; set; }
        public DbSet<AuctionDTO> Auctions { get; set; }

        public TradingCompanyContext(string conn)
        {
            _connStr = conn;
            Database.EnsureCreated();  
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            try
            {
                optionsBuilder.UseSqlServer(_connStr);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}
