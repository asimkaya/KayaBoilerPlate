using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Kaya.Authorization.Roles;
using Kaya.Authorization.Users;
using Kaya.MultiTenancy;

namespace Kaya.EntityFrameworkCore
{
    public class KayaDbContext : AbpZeroDbContext<Tenant, Role, User, KayaDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public KayaDbContext(DbContextOptions<KayaDbContext> options)
            : base(options)
        {
        }
    }
}
