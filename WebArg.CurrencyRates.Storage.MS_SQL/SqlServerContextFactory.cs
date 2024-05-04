using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using WebArg.CurrencyRates.Storage.Database;

namespace WebArg.CurrencyRates.Storage.MS_SQL;

public sealed class SqlServerContextFactory : IDesignTimeDbContextFactory<DataContext>
{
    private const string DbConnectionString = "Server=localhost,1433;Database=CurrencyRatesDb;User ID=sa;Password=<YourStrong@Passw0rd>;MultipleActiveResultSets=true;TrustServerCertificate=True";

    public DataContext CreateDbContext(string[] args)
    {
        var optionBuilder = new DbContextOptionsBuilder<DataContext>();

        optionBuilder.UseSqlServer(DbConnectionString, b => b.MigrationsAssembly(typeof(SqlServerContextFactory).Namespace));

        return new DataContext(optionBuilder.Options);
    }
}
