using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Kaya.Configuration;
using Kaya.Web;

namespace Kaya.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class KayaDbContextFactory : IDesignTimeDbContextFactory<KayaDbContext>
    {
        public KayaDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<KayaDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            KayaDbContextConfigurer.Configure(builder, configuration.GetConnectionString(KayaConsts.ConnectionStringName));

            return new KayaDbContext(builder.Options);
        }
    }
}
