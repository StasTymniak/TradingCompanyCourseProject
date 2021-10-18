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
        
        private string _connStr { get; set; }
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
