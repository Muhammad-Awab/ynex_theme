
//  Cart Data Start 
public class CartListService
{
    private List<CartList> CartListsData = new List<CartList>()
    {
        new CartList { 
            CartId = "1",
            Img = "../assets/images/ecommerce/png/1.png",
            Title = "Hiroma grey Hoodie (Unisex wear)", 
            Size ="Large",
            Color ="Grey",
            Badge ="In Offer",
            BadgeClass ="bg-success-transparent",
            Price ="$459",
            Total ="$918",
        },
        new CartList { 
            CartId = "2",
            Img = "../assets/images/ecommerce/png/7.png",
            Title = "Blue Demin Jacket for Women", 
            Size ="Medium",
            Color ="Blue",
            Badge ="25% discount",
            BadgeClass ="bg-secondary",
            Price ="$129",
            Total ="$129",
        },
        new CartList { 
            CartId = "3",
            Img = "../assets/images/ecommerce/png/15.png",
            Title = "Orange smart watch(44mm dial)", 
            Size ="44mm dial",
            Color ="BronzeOn ",
            Badge ="On Offer",
            BadgeClass ="bg-success-transparent",
            Price ="249",
            Total ="498",
        },
        new CartList { 
            CartId = "4",
            Img = "../assets/images/ecommerce/png/12.png",
            Title = "Sweater for winter", 
            Size ="Medium",
            Color ="Light Pink",
            Badge ="On Offer",
            BadgeClass ="bg-success-transparent",
            Price ="249",
            Total ="498",
        },
        new CartList { 
            CartId = "5",
            Img = "../assets/images/ecommerce/png/3.png",
            Title = "Snow coat from demin Corporation", 
            Size ="Large",
            Color ="Green",
            Badge ="",
            BadgeClass ="",
            Price ="1,299",
            Total ="1,299",
        },
    };

    public List<CartList> GetCartList()
    {
        return CartListsData;
    }

    public void DeleteCartList(string? CartId)
    {
        var CartListToDelete = CartListsData.FirstOrDefault(i => i.CartId == CartId);
        if (CartListToDelete != null)
        {
            CartListsData.Remove(CartListToDelete);
        }
    }
}

//  Cart Data End 