namespace WebArg.CurrencyRates.Quartz.Exceptions;

/// <summary>
/// Ошибка выброшенная разработчиком
/// </summary>
public class QuartzException : Exception
{
    public QuartzException(string message) : base(message) { }

    public QuartzException(string message, Exception innerException) : base(message, innerException) { }
}
