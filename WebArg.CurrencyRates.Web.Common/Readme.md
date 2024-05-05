<a name='assembly'></a>
# WebArg.CurrencyRates.Web.Common

## Contents

- [ArgumentQueryException](#T-WebArg-CurrencyRates-WebAPI-Exceptions-ArgumentQueryException 'WebArg.CurrencyRates.WebAPI.Exceptions.ArgumentQueryException')
- [ErrorResponse](#T-WebArg-CurrencyRates-Web-Common-Middlewares-DtoModels-ErrorResponse 'WebArg.CurrencyRates.Web.Common.Middlewares.DtoModels.ErrorResponse')
  - [Code](#P-WebArg-CurrencyRates-Web-Common-Middlewares-DtoModels-ErrorResponse-Code 'WebArg.CurrencyRates.Web.Common.Middlewares.DtoModels.ErrorResponse.Code')
  - [Details](#P-WebArg-CurrencyRates-Web-Common-Middlewares-DtoModels-ErrorResponse-Details 'WebArg.CurrencyRates.Web.Common.Middlewares.DtoModels.ErrorResponse.Details')
  - [Message](#P-WebArg-CurrencyRates-Web-Common-Middlewares-DtoModels-ErrorResponse-Message 'WebArg.CurrencyRates.Web.Common.Middlewares.DtoModels.ErrorResponse.Message')
- [ErrorResponseDto](#T-WebArg-CurrencyRates-Web-Common-Middlewares-DtoModels-ErrorResponseDto 'WebArg.CurrencyRates.Web.Common.Middlewares.DtoModels.ErrorResponseDto')
  - [Response](#P-WebArg-CurrencyRates-Web-Common-Middlewares-DtoModels-ErrorResponseDto-Response 'WebArg.CurrencyRates.Web.Common.Middlewares.DtoModels.ErrorResponseDto.Response')
  - [StatusCode](#P-WebArg-CurrencyRates-Web-Common-Middlewares-DtoModels-ErrorResponseDto-StatusCode 'WebArg.CurrencyRates.Web.Common.Middlewares.DtoModels.ErrorResponseDto.StatusCode')
- [ExceptionBaseMiddleware](#T-WebArg-CurrencyRates-Web-Common-Middlewares-ExceptionBaseMiddleware 'WebArg.CurrencyRates.Web.Common.Middlewares.ExceptionBaseMiddleware')
  - [GetErrorResponse(context,ex)](#M-WebArg-CurrencyRates-Web-Common-Middlewares-ExceptionBaseMiddleware-GetErrorResponse-Microsoft-AspNetCore-Http-HttpContext,System-Exception- 'WebArg.CurrencyRates.Web.Common.Middlewares.ExceptionBaseMiddleware.GetErrorResponse(Microsoft.AspNetCore.Http.HttpContext,System.Exception)')
  - [GetErrorResponseBase(context,ex)](#M-WebArg-CurrencyRates-Web-Common-Middlewares-ExceptionBaseMiddleware-GetErrorResponseBase-Microsoft-AspNetCore-Http-HttpContext,System-Exception- 'WebArg.CurrencyRates.Web.Common.Middlewares.ExceptionBaseMiddleware.GetErrorResponseBase(Microsoft.AspNetCore.Http.HttpContext,System.Exception)')
- [FluentValidationModelState](#T-WebArg-CurrencyRates-Web-Common-DataAnnotations-DtoModels-FluentValidationModelState 'WebArg.CurrencyRates.Web.Common.DataAnnotations.DtoModels.FluentValidationModelState')
  - [Errors](#P-WebArg-CurrencyRates-Web-Common-DataAnnotations-DtoModels-FluentValidationModelState-Errors 'WebArg.CurrencyRates.Web.Common.DataAnnotations.DtoModels.FluentValidationModelState.Errors')
- [ValidateUsingFluentValidationAttribute](#T-WebArg-CurrencyRates-Web-Common-DataAnnotations-ValidateUsingFluentValidationAttribute 'WebArg.CurrencyRates.Web.Common.DataAnnotations.ValidateUsingFluentValidationAttribute')
  - [GetBadRequestResult(validationResult)](#M-WebArg-CurrencyRates-Web-Common-DataAnnotations-ValidateUsingFluentValidationAttribute-GetBadRequestResult-FluentValidation-Results-ValidationResult- 'WebArg.CurrencyRates.Web.Common.DataAnnotations.ValidateUsingFluentValidationAttribute.GetBadRequestResult(FluentValidation.Results.ValidationResult)')
  - [IsCustomType(type)](#M-WebArg-CurrencyRates-Web-Common-DataAnnotations-ValidateUsingFluentValidationAttribute-IsCustomType-System-Type- 'WebArg.CurrencyRates.Web.Common.DataAnnotations.ValidateUsingFluentValidationAttribute.IsCustomType(System.Type)')
  - [ToFluentModelState(validationResult)](#M-WebArg-CurrencyRates-Web-Common-DataAnnotations-ValidateUsingFluentValidationAttribute-ToFluentModelState-FluentValidation-Results-ValidationResult- 'WebArg.CurrencyRates.Web.Common.DataAnnotations.ValidateUsingFluentValidationAttribute.ToFluentModelState(FluentValidation.Results.ValidationResult)')

<a name='T-WebArg-CurrencyRates-WebAPI-Exceptions-ArgumentQueryException'></a>
## ArgumentQueryException `type`

##### Namespace

WebArg.CurrencyRates.WebAPI.Exceptions

##### Summary

Ошибка параметра запроса

<a name='T-WebArg-CurrencyRates-Web-Common-Middlewares-DtoModels-ErrorResponse'></a>
## ErrorResponse `type`

##### Namespace

WebArg.CurrencyRates.Web.Common.Middlewares.DtoModels

##### Summary

Сообщение об ошибке

<a name='P-WebArg-CurrencyRates-Web-Common-Middlewares-DtoModels-ErrorResponse-Code'></a>
### Code `property`

##### Summary

Код ошибки

<a name='P-WebArg-CurrencyRates-Web-Common-Middlewares-DtoModels-ErrorResponse-Details'></a>
### Details `property`

##### Summary

Детали ошибки

<a name='P-WebArg-CurrencyRates-Web-Common-Middlewares-DtoModels-ErrorResponse-Message'></a>
### Message `property`

##### Summary

Сообщение об ошибке

<a name='T-WebArg-CurrencyRates-Web-Common-Middlewares-DtoModels-ErrorResponseDto'></a>
## ErrorResponseDto `type`

##### Namespace

WebArg.CurrencyRates.Web.Common.Middlewares.DtoModels

##### Summary

Информация об ошибке

<a name='P-WebArg-CurrencyRates-Web-Common-Middlewares-DtoModels-ErrorResponseDto-Response'></a>
### Response `property`

##### Summary

Сообщение об ошибке

<a name='P-WebArg-CurrencyRates-Web-Common-Middlewares-DtoModels-ErrorResponseDto-StatusCode'></a>
### StatusCode `property`

##### Summary

HTTP-статус

<a name='T-WebArg-CurrencyRates-Web-Common-Middlewares-ExceptionBaseMiddleware'></a>
## ExceptionBaseMiddleware `type`

##### Namespace

WebArg.CurrencyRates.Web.Common.Middlewares

##### Summary

Обработчик ошибок

<a name='M-WebArg-CurrencyRates-Web-Common-Middlewares-ExceptionBaseMiddleware-GetErrorResponse-Microsoft-AspNetCore-Http-HttpContext,System-Exception-'></a>
### GetErrorResponse(context,ex) `method`

##### Summary

Получить сообщение об ошибке

##### Returns

Сообщение об ошибке

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Microsoft.AspNetCore.Http.HttpContext](#T-Microsoft-AspNetCore-Http-HttpContext 'Microsoft.AspNetCore.Http.HttpContext') | HTTP-контекст |
| ex | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | Ошибка |

<a name='M-WebArg-CurrencyRates-Web-Common-Middlewares-ExceptionBaseMiddleware-GetErrorResponseBase-Microsoft-AspNetCore-Http-HttpContext,System-Exception-'></a>
### GetErrorResponseBase(context,ex) `method`

##### Summary

Получить описание ошибки

##### Returns

Описание ошибки

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Microsoft.AspNetCore.Http.HttpContext](#T-Microsoft-AspNetCore-Http-HttpContext 'Microsoft.AspNetCore.Http.HttpContext') | HttpContext |
| ex | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | Ошибка |

<a name='T-WebArg-CurrencyRates-Web-Common-DataAnnotations-DtoModels-FluentValidationModelState'></a>
## FluentValidationModelState `type`

##### Namespace

WebArg.CurrencyRates.Web.Common.DataAnnotations.DtoModels

##### Summary

Описание ошибок

<a name='P-WebArg-CurrencyRates-Web-Common-DataAnnotations-DtoModels-FluentValidationModelState-Errors'></a>
### Errors `property`

##### Summary

Ошибки валидации

<a name='T-WebArg-CurrencyRates-Web-Common-DataAnnotations-ValidateUsingFluentValidationAttribute'></a>
## ValidateUsingFluentValidationAttribute `type`

##### Namespace

WebArg.CurrencyRates.Web.Common.DataAnnotations

##### Summary

Настройка автоматической валидации входных параметров через FluentValidation

##### Remarks

Доступен для переопределения

<a name='M-WebArg-CurrencyRates-Web-Common-DataAnnotations-ValidateUsingFluentValidationAttribute-GetBadRequestResult-FluentValidation-Results-ValidationResult-'></a>
### GetBadRequestResult(validationResult) `method`

##### Summary

Переопределение фильтров возвращаемых через BadRequestObjectResult

##### Returns

Объект, который используется в конструкторе

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| validationResult | [FluentValidation.Results.ValidationResult](#T-FluentValidation-Results-ValidationResult 'FluentValidation.Results.ValidationResult') | Результат валидации |

<a name='M-WebArg-CurrencyRates-Web-Common-DataAnnotations-ValidateUsingFluentValidationAttribute-IsCustomType-System-Type-'></a>
### IsCustomType(type) `method`

##### Summary

Проверка является ли тип DTO

##### Returns

True - тип является DTO

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Тип модели |

<a name='M-WebArg-CurrencyRates-Web-Common-DataAnnotations-ValidateUsingFluentValidationAttribute-ToFluentModelState-FluentValidation-Results-ValidationResult-'></a>
### ToFluentModelState(validationResult) `method`

##### Summary

Получить модуль с описанием ошибок

##### Returns

Описание ошибок

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| validationResult | [FluentValidation.Results.ValidationResult](#T-FluentValidation-Results-ValidationResult 'FluentValidation.Results.ValidationResult') | Результат валидации |
