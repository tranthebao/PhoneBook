using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using HS.Farm.Authorization.Roles;
using HS.Farm.Authorization.Users;
using HS.Farm.MultiTenancy;

namespace HS.Farm.EntityFrameworkCore
{
    public class FarmDbContext : AbpZeroDbContext<Tenant, Role, User, FarmDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public FarmDbContext(DbContextOptions<FarmDbContext> options)
            : base(options)
        {
        }
    }
}
