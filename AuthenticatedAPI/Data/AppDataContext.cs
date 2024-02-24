// using Microsoft.EntityFrameworkCore;
using AuthenticatedAPI;
using Microsoft.EntityFrameworkCore;

namespace Authenticated.Data;

public class AppDataContext : DbContext
{
    public AppDataContext(DbContextOptions<AppDataContext> options)
    : base(options)
    {}
       public DbSet<ProductModel> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShopCart> ShoppingCarts { get; set; 
    

}

public class ProductModel
{
}
public class ShopCart
{
}
}