namespace WebArg.CurrencyRates.WebAPI.Exceptions;

/// <summary>
/// Ошибка параметра запроса
/// </summary>
public class ArgumentQueryException : Exception
{
    public ArgumentQueryException(string message) : base(message) { }

    public ArgumentQueryException(string message, Exception innerException) : base(message, innerException) { }
}
