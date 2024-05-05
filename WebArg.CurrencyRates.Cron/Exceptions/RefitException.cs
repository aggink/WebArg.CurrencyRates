namespace WebArg.CurrencyRates.Cron.Exceptions;

/// <summary>
/// Ошибка выброшенная разработчиком
/// </summary>
public class RefitException : Exception
{
    public RefitException(string message) : base(message) { }

    public RefitException(string message, Exception innerException) : base(message, innerException) { }
}
