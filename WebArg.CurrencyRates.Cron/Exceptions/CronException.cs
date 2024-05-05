namespace WebArg.CurrencyRates.Cron.Exceptions;

/// <summary>
/// Выброшенная ошибка разработчиком
/// </summary>
public class CronException : Exception
{
    public CronException(string message) : base(message) { }

    public CronException(string message, Exception innerException) : base(message, innerException) { }
}
