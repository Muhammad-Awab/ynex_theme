
public class ProductListService
{
    private List<ProductList> ProductLists = new List<ProductList>()
    {
        
        new ProductList { ProductId = "1", Product = "../assets/images/ecommerce/png/1.png", ProductTitle = "Dapzem & Co", Description = "Branded hoodie ethnic style", ActualPrice = "1799", Price = "229", Badge = "72% off", BadgeClass = "bg-secondary-transparent", Rating = 4.2M, Category = "clothing", Stock = "283", Gender = "Male", Seller = "Apilla.co.in", Published = "24,Nov 2022 - 04:42PM", },
        new ProductList { ProductId = "2", Product = "../assets/images/ecommerce/png/2.png", ProductTitle = "Denim Winjo", Description = "Vintage pure leather Jacket", ActualPrice = "2499", Price = "599", Badge = "75% off", BadgeClass = "bg-secondary-transparent", Rating = 4.0M, Category = "Clothing", Stock = "98", Gender = "Male", Seller = "Donzo Company", Published = "18,Nov 2022 - 06:53AM", },
        new ProductList { ProductId = "3", Product = "../assets/images/ecommerce/png/3.png", ProductTitle = "Winter Coat For Women", Description = "Winter Coat For Women", ActualPrice = "299", Price = "189", Badge = "50% off", BadgeClass = "bg-primary-transparent", Rating = 3.6M, Category = "Clothing", Stock = "322", Gender = "Female", Seller = "WoodHill.co.in", Published = "16,Oct 2022 - 12:45AM", },
        new ProductList { ProductId = "4", Product = "../assets/images/ecommerce/png/4.png", ProductTitle = "Bluberry Co.In", Description = "Vintage White Full Sleeve Tee-Shirt", ActualPrice = "2,699", Price = "2,499", Badge = "10% off", BadgeClass = "bg-secondary-transparent", Rating = 4.6M, Category = "Clothing", Stock = "194", Gender = "Male,Female", Seller = "Watches.co.in", Published = "12,Aug 2022 - 11:21AM", },
        new ProductList { ProductId = "5", Product = "../assets/images/ecommerce/png/15.png", ProductTitle = "Orange Smart Watch", Description = "Orange Smart Watch", ActualPrice = "999", Price = "349", Badge = "40% off", BadgeClass = "bg-secondary-transparent", Rating = 4.3M, Category = "Watches", Stock = "1293", Gender = "Male,Female", Seller = "SlowTrack Company", Published = "21,Oct 2022 - 11:36AM", },
        new ProductList { ProductId = "6", Product = "../assets/images/ecommerce/png/13.png", ProductTitle = "Watch series (44mm)", Description = "series (44mm)", ActualPrice = "1800", Price = "899", Badge = "50% off", BadgeClass = "bg-primary-transparent", Rating = 3.4M, Category = "Watches", Stock = "267", Gender = "Male,Female", Seller = "Watches.co.in", Published = "05,Sep 2022 - 10:14AM", },
        new ProductList { ProductId = "7", Product = "../assets/images/ecommerce/png/16.png", ProductTitle = "Ikonic Smart Watch(40mm)", Description = "Smart Watch(40mm)", ActualPrice = "1499", Price = "999", Badge = "30% off", BadgeClass = "bg-primary-transparent", Rating = 4.3M, Category = "Watches", Stock = "365", Gender = "Female", Seller = "Kohino.zaps.com", Published = "27,Nov 2022 - 05:12AM", },
        new ProductList { ProductId = "8", Product = "../assets/images/ecommerce/png/23.png", ProductTitle = "Apple Watch Series 5", Description = "Apple Watch Series 5", ActualPrice = "2099", Price = "1499", Badge = "20% off", BadgeClass = "bg-secondary-transparent", Rating = 4.8M, Category = "Watches", Stock = "257", Gender = "Male,Female", Seller = "Apple Corporation", Published = "29,Nov 2022 - 16:32PM", },
        new ProductList { ProductId = "9", Product = "../assets/images/ecommerce/png/12.png", ProductTitle = "Sweater For Women", Description = "Sweater For Women", ActualPrice = "599", Price = "499", Badge = "10% off", BadgeClass = "bg-secondary-transparent", Rating = 3.5M, Category = "Clothing", Stock = "143", Gender = "Female", Seller = "Louie Philippe", Published = "18,Nov 2022 - 14:35PM", },
        new ProductList { ProductId = "10", Product = "../assets/images/ecommerce/png/8.png", ProductTitle = "Pufa", Description = "Ergonic designed full sleeve coat", ActualPrice = "5699", Price = "2399", Badge = "72% off", BadgeClass = "bg-primary-transparent", Rating = 4.0M, Category = "Clothing", Stock = "375", Gender = "Male,Female", Seller = "SlowTrack ", Published = "21,Oct 2022 - 11:36AM", },
        new ProductList { ProductId = "11", Product = "../assets/images/ecommerce/png/11.png", ProductTitle = "Garage & Co", Description = "Full sleeve sweat shirt", ActualPrice = "1299", Price = "249", Badge = "70% off", BadgeClass = "bg-primary-transparent", Rating = 4.0M, Category = "Clothing", Stock = "145", Gender = "Male,Female", Seller = "WoodHill", Published = "24,Nov 2022 - 04:42PM", },
        new ProductList { ProductId = "12", Product = "../assets/images/ecommerce/png/9.png", ProductTitle = "Louie Phillippe", Description = "Ergonic green colored full sleeve jacket", ActualPrice = "3299", Price = "1899", Badge = "60% off", BadgeClass = "bg-secondary-transparent", Rating = 4.0M, Category = "Clothing", Stock = "214", Gender = "Male,Female", Seller = "Donzo", Published = "18,Nov 2022 - 14:35PM", },
    };

    public List<ProductList> GetProductLists()
    {
        return ProductLists;
    }

    public void DeleteProductList(string? ProductId)
    {
        var  ProductToDelete = ProductLists.FirstOrDefault(i => i.ProductId == ProductId);
        if (ProductToDelete != null)
        {
            ProductLists.Remove(ProductToDelete);
        }
    }
}


