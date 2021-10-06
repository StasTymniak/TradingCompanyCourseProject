using System;
using System.Collections.Generic;
using System.Linq;
using DAL.EntityFramework;
using DTO;
namespace courseProject
{
    class Program
    {

        static void SwitchMenu()
        {
            Console.WriteLine(@"1)Auctions
2)Products
0)Exit");
        }
        static void AuctionChoice()
        {
            Console.WriteLine(@"1)Browse all auctions
2)Browse active auctions
3)Activate auction
4)Deactivate auction
0)Go back");
        }

        static void ProductsChoice()
        {
            Console.WriteLine(@"1)Browse all products
2)Sort by category
3)Browse all products by category
4)Create auction
0)Go back");
        }
        static void Main(string[] args)
        {
            Command cmd = new Command();
            SwitchMenu();
            bool isTrue = true;
            while (isTrue)
            {
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        AuctionChoice();
                        string case1choice = Console.ReadLine();
                        bool case1isTrue = true;
                        while (case1isTrue)
                        {
                            switch (case1choice)
                            {
                                case "1":
                                    Console.Clear();
                                    cmd.ShowAllAuctions();
                                    AuctionChoice();
                                    case1choice = Console.ReadLine();
                                    break;
                                case "2":
                                    Console.Clear();
                                    cmd.ShowAllActiveAuctions();
                                    AuctionChoice();
                                    case1choice = Console.ReadLine();
                                    break;
                                case "3":
                                    Console.Clear();
                                    Console.WriteLine("Enter auction id");
                                    int auctionId = Convert.ToInt32(Console.ReadLine());
                                    cmd.ActivateAuction(auctionId);
                                    AuctionChoice();
                                    case1choice = Console.ReadLine();
                                    break;
                                case "4":
                                    Console.Clear();
                                    Console.WriteLine("Enter auction id");
                                    int _auctionId = Convert.ToInt32(Console.ReadLine());
                                    cmd.DeactivateAuction(_auctionId);
                                    AuctionChoice();
                                    case1choice = Console.ReadLine();
                                    break;
                                case "0":
                                    case1isTrue = false;
                                    SwitchMenu();
                                    choice = Console.ReadLine();
                                    Console.Clear();
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;
                    case "2":
                        ProductsChoice();
                        string case2choice = Console.ReadLine();
                        bool case2isTrue = true;
                        while (case2isTrue)
                        {
                            switch (case2choice)
                            {
                                case "1":
                                    Console.Clear();
                                    cmd.ShowAllProducts();
                                    ProductsChoice();
                                    case2choice = Console.ReadLine();
                                    break;
                                case "2":
                                    Console.Clear();
                                    cmd.SortProductsByCategory();
                                    ProductsChoice();
                                    case2choice = Console.ReadLine();
                                    break;
                                case "3":
                                    Console.Clear();
                                    Console.Write("Enter category -- ");
                                    string categoryname =Console.ReadLine();
                                    cmd.PrintProducts(cmd.FindProductsByCategory(categoryname));
                                    ProductsChoice();
                                    case2choice = Console.ReadLine();
                                    break;
                                case "4":
                                    Console.Clear();
                                    float startupPrice;
                                    float redemptionPrice;
                                    DateTime endtime;
                                    Console.Write("Enter product ID -- ");
                                    int productID = Convert.ToInt32(Console.ReadLine());
                                    ProductDTO product = cmd.GetProduct(productID);
                                    string auctionName = product.ProductName + " Auction";
                                    Console.Write("Enter startup price -- ");startupPrice = float.Parse(Console.ReadLine());
                                    Console.Write("Enter redemption price -- "); redemptionPrice = float.Parse(Console.ReadLine());
                                    Console.Write("Enter end time (format yyyy-mm-dd HH:mm:ss ) -- "); endtime = Convert.ToDateTime(Console.ReadLine());
                                    cmd.AddProductAuction(productID,auctionName,startupPrice,redemptionPrice,endtime);
                                    ProductsChoice();
                                    case2choice = Console.ReadLine();
                                    break;
                                case "0":
                                    case2isTrue = false;
                                    SwitchMenu();
                                    choice = Console.ReadLine();
                                    Console.Clear();
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;
                    case "0":
                        isTrue = false;
                        break;
                    default:
                        isTrue = false;
                        break;
                }
            }
            
        }
    }
}
