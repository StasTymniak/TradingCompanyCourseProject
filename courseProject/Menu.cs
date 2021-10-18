using Commands;
using Domain;
using System;
using System.Configuration;

namespace courseProject
{
    public static class Menu
    {
        static bool isTrue = true;
        static private string _connection = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        static AuctionCommands cmdAuction = new AuctionCommands(_connection);
        static ProductCommands cmdproduct = new ProductCommands(_connection);
        static void SwitchMenu()
        {
            Console.WriteLine(@"1)Auctions
2)Products
Exit");
            while (isTrue)
            {
                string choise = Console.ReadLine();
                switch (choise)
                {
                    case "1":
                        AuctionChoise(choise);
                        break;
                    case "2":
                        ProductsChoise(choise);
                        break;
                    default:
                        isTrue = false;
                        break;
                }
            }
        }
        static void AuctionChoise(string choise)
        {
            Console.WriteLine(@"1)Browse all auctions
2)Browse active auctions
3)Activate auction
4)Deactivate auction
0)Go back");
            AuctionChoiseSwitch(choise);
        }
        static void AuctionChoiseSwitch(string choise)
        {
            string case1choise = Console.ReadLine();
            bool case1isTrue = true;
            while (case1isTrue)
            {
                switch (case1choise)
                {
                    case "1":
                        Console.Clear();
                        cmdAuction.ShowAllAuctions();
                        AuctionChoise(choise);
                        case1choise = Console.ReadLine();
                        break;
                    case "2":
                        Console.Clear();
                        cmdAuction.ShowAllActiveAuctions();
                        AuctionChoise(choise);
                        case1choise = Console.ReadLine();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Enter auction id");
                        int auctionId = Convert.ToInt32(Console.ReadLine());
                        cmdAuction.ActivateAuction(auctionId);
                        AuctionChoise(choise);
                        case1choise = Console.ReadLine();
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Enter auction id");
                        int _auctionId = Convert.ToInt32(Console.ReadLine());
                        cmdAuction.DeactivateAuction(_auctionId);
                        AuctionChoise(choise);
                        case1choise = Console.ReadLine();
                        break;
                    case "0":
                        case1isTrue = false;
                        SwitchMenu();
                        choise = Console.ReadLine();
                        Console.Clear();
                        break;
                    default:
                        break;
                }
            }
        }
        static void ProductsChoise(string choise)
        {
            Console.WriteLine(@"1)Browse all products
2)Sort by category
3)Browse all products by category
4)Create auction
0)Go back");

            ProductChoiseSwitch(choise);
        }

        static void ProductChoiseSwitch(string choise)
        {
            string case2choise = Console.ReadLine();
            bool case2isTrue = true;
            while (case2isTrue)
            {
                switch (case2choise)
                {
                    case "1":
                        Console.Clear();
                        cmdproduct.ShowAllProducts();
                        ProductsChoise(choise);
                        case2choise = Console.ReadLine();
                        break;
                    case "2":
                        Console.Clear();
                        cmdproduct.SortProductsByCategory();
                        ProductsChoise(choise);
                        case2choise = Console.ReadLine();
                        break;
                    case "3":
                        Console.Clear();
                        Console.Write("Enter category -- ");
                        string categoryname = Console.ReadLine();
                        cmdproduct.PrintProducts(cmdproduct.FindProductsByCategory(categoryname));
                        ProductsChoise(choise);
                        case2choise = Console.ReadLine();
                        break;
                    case "4":
                        Console.Clear();
                        float startupPrice;
                        float redemptionPrice;
                        DateTime endtime;
                        Console.Write("Enter product ID -- ");
                        int productID = Convert.ToInt32(Console.ReadLine());
                        Product product = cmdproduct.GetProduct(productID);
                        string auctionName = product.ProductName + " Auction";
                        Console.Write("Enter startup price -- "); startupPrice = float.Parse(Console.ReadLine());
                        Console.Write("Enter redemption price -- "); redemptionPrice = float.Parse(Console.ReadLine());
                        Console.Write("Enter end time (format yyyy-mm-dd HH:mm:ss ) -- "); endtime = Convert.ToDateTime(Console.ReadLine());
                        cmdAuction.AddProductAuction(productID, auctionName, startupPrice, redemptionPrice, endtime);
                        ProductsChoise(choise);
                        case2choise = Console.ReadLine();
                        break;
                    case "0":
                        case2isTrue = false;
                        SwitchMenu();
                        choise = Console.ReadLine();
                        Console.Clear();
                        break;
                    default:
                        break;
                }
            }
        }
        public static void ShowMenu()
        {
            SwitchMenu();
        }

    }
}
