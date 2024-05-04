using Microsoft.EntityFrameworkCore;
using WebArg.CurrencyRates.Storage.Models;

namespace WebArg.CurrencyRates.Storage.Database;

/// <summary>
/// Контекст базы данных
/// </summary>
public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

    }

    /// <summary>
    /// Курс валют
    /// </summary>
    public DbSet<ReportDaily> Reports { get; set; }
}
