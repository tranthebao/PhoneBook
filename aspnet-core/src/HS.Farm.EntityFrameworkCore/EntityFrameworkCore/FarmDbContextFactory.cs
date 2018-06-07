using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using HS.Farm.Configuration;
using HS.Farm.Web;

namespace HS.Farm.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class FarmDbContextFactory : IDesignTimeDbContextFactory<FarmDbContext>
    {
        public FarmDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<FarmDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            FarmDbContextConfigurer.Configure(builder, configuration.GetConnectionString(FarmConsts.ConnectionStringName));

            return new FarmDbContext(builder.Options);
        }
    }
}
