using DAL.EntityFramework;
using DAL.Interfaces;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseProject
{
    public class Command
    {
        IAuctionDAL auction = new AuctionDAL();
        ICategoryDAL category = new CategoryDAL();
        IProductDAL product = new ProductDAL();
        public Command()
        {

        }
        public void PrintProduct(ProductDTO product)
        {
            Console.WriteLine($"ID--{product.ProductId}\nName--{product.ProductName}\nCategory--{category.Get(product.CategoryId).CategoryName}");
        }
        public ProductDTO GetProduct(int id)
        {
            return product.Get(id);
        }
        public void PrintProducts(List<ProductDTO> products)
        {
            foreach (ProductDTO product in products)
            {
                Console.WriteLine($"ID--{product.ProductId}\nName--{product.ProductName}\nCategory--{category.Get(product.CategoryId).CategoryName}");
            }
        }
        public void ShowAllProducts()
        {
            List<ProductDTO> products = product.GetAll();
            foreach (ProductDTO product in products)
            {
                Console.WriteLine($"ID--{product.ProductId}\nName--{product.ProductName}\nCategory--{category.Get(product.CategoryId).CategoryName}\n");
            }
        }
        public void SortProductsByCategory()
        {
            List<ProductDTO> products = product.GetAll();
            var productsSorted = from product in products
                                 orderby product.CategoryId ascending
                                 select product;
            foreach (ProductDTO product in productsSorted)
            {
                Console.WriteLine($"ID--{product.ProductId}\nName--{product.ProductName}\nCategory--{category.Get(product.CategoryId).CategoryName}\n");
            }
        }
        public List<ProductDTO> FindProductsByCategory(string requestedCategory)
        {
            List<ProductDTO> products = product.GetAll();
            var selectedproducts = from product in products
                                   where category.Get(product.CategoryId).CategoryName == requestedCategory
                                   select product;
            List<ProductDTO> findedproducts = new List<ProductDTO>();
            foreach (ProductDTO item in selectedproducts)
            {
                findedproducts.Add(item);
            }
            return findedproducts;
        }


        public void ShowAllAuctions()
        {
            List<AuctionDTO> auctions = auction.GetAll();
            foreach (AuctionDTO auction in auctions)
            {
                Console.WriteLine($"ID--{auction.AuctionId}\nName--{auction.AuctionName}\nStartup price--{auction.StrtupPrice}\nRedemption price--{auction.RedemptionPrice}\n is Active--{auction.isActive}\nEnd time--{auction.EndTime}\n");
            }
        }

        public void ShowAllActiveAuctions()
        {
            List<AuctionDTO> auctions = auction.GetAll();
            var selectedauctions = from auction in auctions
                                   where auction.isActive == true
                                   select auction;
            List<AuctionDTO> findedauctions = new List<AuctionDTO>();
            foreach (AuctionDTO item in selectedauctions)
            {
                findedauctions.Add(item);
            }
            foreach (AuctionDTO auction in findedauctions)
            {
                Console.WriteLine($"ID--{auction.AuctionId}\nName--{auction.AuctionName}\nStartup price--{auction.StrtupPrice}\nRedemption price--{auction.RedemptionPrice}\n is Active--{auction.isActive}\nEnd time--{auction.EndTime}\nActivate time--{auction.ActivateTime}\n");
            }
        }

        public void ActivateAuction(int id)
        {
            AuctionDTO auctionDTO = new AuctionDTO();
            auctionDTO.AuctionName = auction.Get(id).AuctionName;
            auctionDTO.StrtupPrice = auction.Get(id).StrtupPrice;
            auctionDTO.RedemptionPrice = auction.Get(id).RedemptionPrice;
            auctionDTO.ActivateTime = DateTime.Now;
            auctionDTO.DeactivateTime = auction.Get(id).DeactivateTime;
            auctionDTO.EndTime = DateTime.Today;
            auctionDTO.isActive = true;
            auctionDTO.ProductId = auction.Get(id).ProductId;
            auction.Update(id, auctionDTO);
        }

        public void DeactivateAuction(int id)
        {
            AuctionDTO auctionDTO = new AuctionDTO();
            auctionDTO.AuctionName = auction.Get(id).AuctionName;
            auctionDTO.StrtupPrice = auction.Get(id).StrtupPrice;
            auctionDTO.RedemptionPrice = auction.Get(id).RedemptionPrice;
            auctionDTO.ActivateTime = auction.Get(id).ActivateTime;
            auctionDTO.DeactivateTime = DateTime.Now;
            auctionDTO.EndTime = DateTime.Today;
            auctionDTO.isActive = false;
            auctionDTO.ProductId = auction.Get(id).ProductId;
            auction.Update(id, auctionDTO);
        }

        public void AddProductAuction(int productId,string auctionName,float startupPrice,float redemptionPrice,DateTime endtime)
        {
            AuctionDTO auctionDTO = new AuctionDTO();
            auctionDTO.AuctionName = auctionName;
            auctionDTO.StrtupPrice = startupPrice;
            auctionDTO.RedemptionPrice = redemptionPrice;
            auctionDTO.EndTime = endtime;
            auctionDTO.isActive = false;
            auctionDTO.ProductId = productId;
            auction.Create(auctionDTO);
        }
    }
}

/* AuctionDTO auctionDTO = new AuctionDTO()
            {
                auctionDTO.AuctionName = auction.Get(id).AuctionName,
                auctionDTO.StrtupPrice = auction.Get(id).StrtupPrice,
                auctionDTO.RedemptionPrice = auction.Get(id).RedemptionPrice,
                auctionDTO.ActivateTime = auction.Get(id).ActivateTime,
                auctionDTO.DeactivateTime = auction.Get(id).DeactivateTime,
                auctionDTO.ProductId = auction.Get(id).ProductId,
             };*/