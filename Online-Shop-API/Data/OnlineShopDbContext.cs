using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Online_Shop_API.Data;

public class OnlineShopDbContext : IdentityDbContext<IdentityUser>
{
    public OnlineShopDbContext(DbContextOptions options) : base(options)
    {
    }
}