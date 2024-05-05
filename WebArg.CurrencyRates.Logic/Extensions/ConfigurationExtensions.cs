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
    /// <returns>Строка подключения к БД</returns>
    /// <exception cref="LogicException">Данные не найдены</exception>
    public static string GetDefaultConnectionString(this IConfiguration configuration)
    {
        var stringConnection = configuration.GetConnectionString("DefaultConnection");
        return !string.IsNullOrEmpty(stringConnection)
            ? stringConnection
            : throw new LogicException("DefaultConnection не найден или пуст");
    }
}
