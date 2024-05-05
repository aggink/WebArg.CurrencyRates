using Microsoft.Extensions.Configuration;
using WebArg.CurrencyRates.Logic.Exceptions;

namespace WebArg.CurrencyRates.Logic.Extensions;

/// <summary>
/// Получение данных из файла настроек
/// </summary>
public static class ConfigurationExtensions
{
    /// <summary>
    /// Получить строку подключения к БД
    /// </summary>
    /// <param name="configuration">Набор свойств конфигурации</param>
    /// <returns></returns>
    /// <exception cref="LogicException">Данные не найдены</exception>
    public static string GetDefaultConnectionString(this IConfiguration configuration)
    {
        return configuration.GetConnectionString("DefaultConnection")
            ?? throw new LogicException("DefaultConnection не найдено");
    }
}
