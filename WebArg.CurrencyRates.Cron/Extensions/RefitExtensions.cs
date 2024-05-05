using Microsoft.Extensions.Logging;
using Refit;
using System.Net;
using System.Text;
using System.Text.Json;
using WebArg.CurrencyRates.Cron.Exceptions;

namespace WebArg.CurrencyRates.Cron.Extensions;

public static class RefitExtensions
{
    /// <summary>
    /// Проверка ответа сервера
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="response">Ответ</param>
    /// <param name="logger">Журнал логирования</param>
    /// <param name="checkContent">Проверить наличие контента</param>
    /// <returns>True - проверка завершилась успешно</returns>
    /// <exception cref="RefitException">В ходе выполнения запроса произошла ошибка</exception>
    public static bool RefitResponseValidate<T>(this IApiResponse<T> response, ILogger logger, bool checkContent = true)
        where T : class
    {
        if (response.StatusCode != HttpStatusCode.OK)
        {
            logger.LogError(response.Error, "Запрос завершился с ошибкой: {0}", response.GetResponseMessage());
            throw new RefitException($"При обработке ответа произошла ошибка. Статус код: {response.StatusCode}", response.Error);
        }

        if (!response.IsSuccessStatusCode)
        {
            logger.LogError(response.Error, "Запрос завершился с ошибкой: {0}", response.GetResponseMessage());
            throw new RefitException($"Запрос завершился с ошибкой. Статус код: {response.StatusCode}", response.Error);
        }

        if (response.Error != null)
        {
            logger.LogError(response.Error, "Запрос выполнен успешно, но в процессе обработки ответа произошла ошибка: {0}", response.GetResponseMessage());
            throw new RefitException($"При обработке ответа произошла ошибка. Статус код: {response.StatusCode}", response.Error);
        }

        if (checkContent && response.Content == null)
        {
            logger.LogError("Запрос выполнен успешно, но пришел пустой ответ: {0}", response.GetResponseMessage());
            throw new RefitException("Контент пуст");
        }

        return true;
    }

    /// <summary>
    /// Получить описание запроса
    /// </summary>
    /// <typeparam name="T">Тип ответа</typeparam>
    /// <param name="response">Ответ от сервера</param>
    /// <returns>Описание запроса</returns>
    public static string GetRequestMessage<T>(this IApiResponse<T> response)
        where T : class
    {
        var stringBuilder = new StringBuilder();

        stringBuilder.AppendJoin(", ", $"StatusCode: {response.StatusCode}");
        stringBuilder.AppendJoin(", ", $"Method: {response.RequestMessage.Method}");
        stringBuilder.AppendJoin(", ", $"Uri: {response.RequestMessage.RequestUri}");

        if (response.RequestMessage.Content != null)
            stringBuilder.AppendJoin(", ", $"RequestContent: {JsonSerializer.Serialize(response.RequestMessage.Content)}");

        return stringBuilder.ToString();
    }

    /// <summary>
    /// Получить описание ответа
    /// </summary>
    /// <typeparam name="T">Тип ответа</typeparam>
    /// <param name="response">Ответ от сервера</param>
    /// <returns>Описание ответа</returns>
    public static string GetResponseMessage<T>(this IApiResponse<T> response)
        where T : class
    {
        var stringBuilder = new StringBuilder();

        stringBuilder.AppendJoin(", ", $"StatusCode: {response.StatusCode}");
        stringBuilder.AppendJoin(", ", $"Method: {response.RequestMessage.Method}");
        stringBuilder.AppendJoin(", ", $"Uri: {response.RequestMessage.RequestUri}");

        if (response.RequestMessage.Content != null)
            stringBuilder.AppendJoin(", ", $"RequestContent: {JsonSerializer.Serialize(response.RequestMessage.Content)}");

        if (response.Content != null)
            stringBuilder.AppendJoin(", ", $"RequestContent: {JsonSerializer.Serialize(response.Content)}");

        return stringBuilder.ToString();
    }
}
