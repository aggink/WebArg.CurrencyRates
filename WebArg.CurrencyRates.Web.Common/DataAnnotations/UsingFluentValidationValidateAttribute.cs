using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using WebArg.CurrencyRates.Web.Common.DataAnnotations.DtoModels;

namespace WebArg.CurrencyRates.Web.Common.DataAnnotations;

/// <summary>
/// Настройка автоматической валидации входных параметров через FluentValidation
/// </summary>
/// <remarks>Доступен для переопределения</remarks>
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Class)]
public class ValidateUsingFluentValidationAttribute : Attribute, IAsyncActionFilter
{
    public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
    {
        if (context.Controller is Controller)
        {
            var serviceProvider = context.HttpContext.RequestServices;

            foreach (var parameter in context.ActionDescriptor.Parameters)
            {
                if (context.ActionArguments.TryGetValue(parameter.Name, out var parameterToValidate)
                    && parameterToValidate != null && IsCustomType(parameter.ParameterType)
                    && serviceProvider.GetService(typeof(IValidator<>).MakeGenericType(parameter.ParameterType)) is IValidator validator)
                {
                    var validationContext = new ValidationContext<object>(parameterToValidate);
                    var validationResult = await validator.ValidateAsync(validationContext, context.HttpContext.RequestAborted);

                    if (!validationResult.IsValid)
                    {
                        context.Result = new BadRequestObjectResult(GetBadRequestResult(validationResult));
                        return;
                    }
                }
            }
        }

        await next();
    }

    /// <summary>
    /// Переопределение фильтров возвращаемых через BadRequestObjectResult
    /// </summary>
    /// <param name="validationResult">Результат валидации</param>
    /// <returns>Объект, который используется в конструкторе</returns>
    protected virtual object GetBadRequestResult(ValidationResult validationResult)
    {
        return ToFluentModelState(validationResult);
    }

    /// <summary>
    /// Проверка является ли тип DTO
    /// </summary>
    /// <param name="type">Тип модели</param>
    /// <returns>True - тип является DTO</returns>
    private static bool IsCustomType(Type type)
    {
        return type != null && type.IsClass
            && !type.IsEnum && !type.IsValueType
            && !type.IsPrimitive
            && type != typeof(string);
    }

    /// <summary>
    /// Получить модуль с описанием ошибок
    /// </summary>
    /// <param name="validationResult">Результат валидации</param>
    /// <returns>Описание ошибок</returns>
    private static FluentValidationModelState ToFluentModelState(ValidationResult validationResult)
    {
        return new FluentValidationModelState
        {
            Errors = validationResult.Errors.ToDictionary(x => x.PropertyName, x => x.ErrorMessage),
        };
    }
}