using DTO;
using System;
using DAL.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EntityFramework
{
    public class AuctionDAL : IAuctionDAL
    {
        public AuctionDTO Get(int id)
        {
            using (TradingCompanyContext db = new TradingCompanyContext())
            {
                return db.Auctions.Find(id);
            }
        }
        public List<AuctionDTO> GetAll()
        {
            using (TradingCompanyContext db = new TradingCompanyContext())
            {
                return db.Auctions.ToList();
            }
        }
        public void Create(AuctionDTO tmp)
        {
            using (TradingCompanyContext db = new TradingCompanyContext())
            {
                db.Auctions.Add(tmp);
                db.SaveChanges();
            }
        }
        public void Update(int id, AuctionDTO tmp)
        {
            using (TradingCompanyContext db = new TradingCompanyContext())
            {
                AuctionDTO auction = db.Auctions.Where(x => x.AuctionId == id).SingleOrDefault();
                auction.AuctionName = tmp.AuctionName;
                auction.StrtupPrice = tmp.StrtupPrice;
                auction.RedemptionPrice = tmp.RedemptionPrice;
                auction.ActivateTime = tmp.ActivateTime;
                auction.DeactivateTime = tmp.DeactivateTime;
                auction.isActive = tmp.isActive;
                auction.ProductId = tmp.ProductId;
                db.SaveChanges();
            }
        }
        public void Delete(int id)
        {
            using (TradingCompanyContext db = new TradingCompanyContext())
            {
                var auction = db.Auctions.Where(x => x.AuctionId == id).SingleOrDefault();
                if (auction != null)
                {
                    db.Auctions.Remove(auction);
                    db.SaveChanges();
                }
            }
        }
    }
}
