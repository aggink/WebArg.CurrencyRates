<a name='assembly'></a>
# WebArg.CurrencyRates.WebAPI

## Contents

- [CurrencyRate](#T-WebArg-CurrencyRates-WebAPI-Features-DtoModels-CurrencyRate 'WebArg.CurrencyRates.WebAPI.Features.DtoModels.CurrencyRate')
  - [Code](#P-WebArg-CurrencyRates-WebAPI-Features-DtoModels-CurrencyRate-Code 'WebArg.CurrencyRates.WebAPI.Features.DtoModels.CurrencyRate.Code')
  - [Date](#P-WebArg-CurrencyRates-WebAPI-Features-DtoModels-CurrencyRate-Date 'WebArg.CurrencyRates.WebAPI.Features.DtoModels.CurrencyRate.Date')
  - [Value](#P-WebArg-CurrencyRates-WebAPI-Features-DtoModels-CurrencyRate-Value 'WebArg.CurrencyRates.WebAPI.Features.DtoModels.CurrencyRate.Value')
- [ExceptionMiddleware](#T-WebArg-CurrencyRates-WebAPI-Middlewares-ExceptionMiddleware 'WebArg.CurrencyRates.WebAPI.Middlewares.ExceptionMiddleware')
- [GetCurrencyCodesQuery](#T-WebArg-CurrencyRates-WebAPI-Features-Queries-GetCurrencyCodesQuery 'WebArg.CurrencyRates.WebAPI.Features.Queries.GetCurrencyCodesQuery')
- [GetCurrencyRateTodayQuery](#T-WebArg-CurrencyRates-WebAPI-Features-Queries-GetCurrencyRateTodayQuery 'WebArg.CurrencyRates.WebAPI.Features.Queries.GetCurrencyRateTodayQuery')
  - [Code](#P-WebArg-CurrencyRates-WebAPI-Features-Queries-GetCurrencyRateTodayQuery-Code 'WebArg.CurrencyRates.WebAPI.Features.Queries.GetCurrencyRateTodayQuery.Code')
- [GetReportQuery](#T-WebArg-CurrencyRates-WebAPI-Features-Queries-GetReportQuery 'WebArg.CurrencyRates.WebAPI.Features.Queries.GetReportQuery')
  - [Codes](#P-WebArg-CurrencyRates-WebAPI-Features-Queries-GetReportQuery-Codes 'WebArg.CurrencyRates.WebAPI.Features.Queries.GetReportQuery.Codes')
  - [EndDate](#P-WebArg-CurrencyRates-WebAPI-Features-Queries-GetReportQuery-EndDate 'WebArg.CurrencyRates.WebAPI.Features.Queries.GetReportQuery.EndDate')
  - [StartDate](#P-WebArg-CurrencyRates-WebAPI-Features-Queries-GetReportQuery-StartDate 'WebArg.CurrencyRates.WebAPI.Features.Queries.GetReportQuery.StartDate')
- [ManageController](#T-WebArg-CurrencyRates-WebAPI-Controllers-ManageController 'WebArg.CurrencyRates.WebAPI.Controllers.ManageController')
  - [GetCurrencyCodes(cancellationToken)](#M-WebArg-CurrencyRates-WebAPI-Controllers-ManageController-GetCurrencyCodes-System-Threading-CancellationToken- 'WebArg.CurrencyRates.WebAPI.Controllers.ManageController.GetCurrencyCodes(System.Threading.CancellationToken)')
  - [GetCurrencyRateToday(query,cancellationToken)](#M-WebArg-CurrencyRates-WebAPI-Controllers-ManageController-GetCurrencyRateToday-WebArg-CurrencyRates-WebAPI-Features-Queries-GetCurrencyRateTodayQuery,System-Threading-CancellationToken- 'WebArg.CurrencyRates.WebAPI.Controllers.ManageController.GetCurrencyRateToday(WebArg.CurrencyRates.WebAPI.Features.Queries.GetCurrencyRateTodayQuery,System.Threading.CancellationToken)')
  - [GetReport(query,cancellationToken)](#M-WebArg-CurrencyRates-WebAPI-Controllers-ManageController-GetReport-WebArg-CurrencyRates-WebAPI-Features-Queries-GetReportQuery,System-Threading-CancellationToken- 'WebArg.CurrencyRates.WebAPI.Controllers.ManageController.GetReport(WebArg.CurrencyRates.WebAPI.Features.Queries.GetReportQuery,System.Threading.CancellationToken)')
  - [SaveReport(command,cancellationToken)](#M-WebArg-CurrencyRates-WebAPI-Controllers-ManageController-SaveReport-WebArg-CurrencyRates-WebAPI-Features-Commands-SaveReportCommand,System-Threading-CancellationToken- 'WebArg.CurrencyRates.WebAPI.Controllers.ManageController.SaveReport(WebArg.CurrencyRates.WebAPI.Features.Commands.SaveReportCommand,System.Threading.CancellationToken)')
- [ReportResponseDto](#T-WebArg-CurrencyRates-WebAPI-Features-DtoModels-ReportResponseDto 'WebArg.CurrencyRates.WebAPI.Features.DtoModels.ReportResponseDto')
  - [Avg](#P-WebArg-CurrencyRates-WebAPI-Features-DtoModels-ReportResponseDto-Avg 'WebArg.CurrencyRates.WebAPI.Features.DtoModels.ReportResponseDto.Avg')
  - [Code](#P-WebArg-CurrencyRates-WebAPI-Features-DtoModels-ReportResponseDto-Code 'WebArg.CurrencyRates.WebAPI.Features.DtoModels.ReportResponseDto.Code')
  - [Max](#P-WebArg-CurrencyRates-WebAPI-Features-DtoModels-ReportResponseDto-Max 'WebArg.CurrencyRates.WebAPI.Features.DtoModels.ReportResponseDto.Max')
  - [Min](#P-WebArg-CurrencyRates-WebAPI-Features-DtoModels-ReportResponseDto-Min 'WebArg.CurrencyRates.WebAPI.Features.DtoModels.ReportResponseDto.Min')
- [ReportResponseMapper](#T-WebArg-CurrencyRates-WebAPI-Features-Mappers-ReportResponseMapper 'WebArg.CurrencyRates.WebAPI.Features.Mappers.ReportResponseMapper')
- [SaveReportCommand](#T-WebArg-CurrencyRates-WebAPI-Features-Commands-SaveReportCommand 'WebArg.CurrencyRates.WebAPI.Features.Commands.SaveReportCommand')
  - [Report](#P-WebArg-CurrencyRates-WebAPI-Features-Commands-SaveReportCommand-Report 'WebArg.CurrencyRates.WebAPI.Features.Commands.SaveReportCommand.Report')
- [SaveReportRequestDto](#T-WebArg-CurrencyRates-WebAPI-Features-DtoModels-SaveReportRequestDto 'WebArg.CurrencyRates.WebAPI.Features.DtoModels.SaveReportRequestDto')
  - [EndDate](#P-WebArg-CurrencyRates-WebAPI-Features-DtoModels-SaveReportRequestDto-EndDate 'WebArg.CurrencyRates.WebAPI.Features.DtoModels.SaveReportRequestDto.EndDate')
  - [StartDate](#P-WebArg-CurrencyRates-WebAPI-Features-DtoModels-SaveReportRequestDto-StartDate 'WebArg.CurrencyRates.WebAPI.Features.DtoModels.SaveReportRequestDto.StartDate')
- [ServiceCollectionExtensions](#T-WebArg-CurrencyRates-WebAPI-Extensions-ServiceCollectionExtensions 'WebArg.CurrencyRates.WebAPI.Extensions.ServiceCollectionExtensions')
  - [AddDataContext(services,configuration)](#M-WebArg-CurrencyRates-WebAPI-Extensions-ServiceCollectionExtensions-AddDataContext-Microsoft-Extensions-DependencyInjection-IServiceCollection,Microsoft-Extensions-Configuration-IConfiguration- 'WebArg.CurrencyRates.WebAPI.Extensions.ServiceCollectionExtensions.AddDataContext(Microsoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.Configuration.IConfiguration)')
  - [AddFluentValidationSetup(services,type)](#M-WebArg-CurrencyRates-WebAPI-Extensions-ServiceCollectionExtensions-AddFluentValidationSetup-Microsoft-Extensions-DependencyInjection-IServiceCollection,System-Type- 'WebArg.CurrencyRates.WebAPI.Extensions.ServiceCollectionExtensions.AddFluentValidationSetup(Microsoft.Extensions.DependencyInjection.IServiceCollection,System.Type)')
  - [AddSwaggerSetup(services)](#M-WebArg-CurrencyRates-WebAPI-Extensions-ServiceCollectionExtensions-AddSwaggerSetup-Microsoft-Extensions-DependencyInjection-IServiceCollection- 'WebArg.CurrencyRates.WebAPI.Extensions.ServiceCollectionExtensions.AddSwaggerSetup(Microsoft.Extensions.DependencyInjection.IServiceCollection)')
  - [AddWebMappers(services)](#M-WebArg-CurrencyRates-WebAPI-Extensions-ServiceCollectionExtensions-AddWebMappers-Microsoft-Extensions-DependencyInjection-IServiceCollection- 'WebArg.CurrencyRates.WebAPI.Extensions.ServiceCollectionExtensions.AddWebMappers(Microsoft.Extensions.DependencyInjection.IServiceCollection)')
  - [AddWebServices(services)](#M-WebArg-CurrencyRates-WebAPI-Extensions-ServiceCollectionExtensions-AddWebServices-Microsoft-Extensions-DependencyInjection-IServiceCollection- 'WebArg.CurrencyRates.WebAPI.Extensions.ServiceCollectionExtensions.AddWebServices(Microsoft.Extensions.DependencyInjection.IServiceCollection)')

<a name='T-WebArg-CurrencyRates-WebAPI-Features-DtoModels-CurrencyRate'></a>
## CurrencyRate `type`

##### Namespace

WebArg.CurrencyRates.WebAPI.Features.DtoModels

##### Summary

Курс валюты

<a name='P-WebArg-CurrencyRates-WebAPI-Features-DtoModels-CurrencyRate-Code'></a>
### Code `property`

##### Summary

Код валюты

<a name='P-WebArg-CurrencyRates-WebAPI-Features-DtoModels-CurrencyRate-Date'></a>
### Date `property`

##### Summary

Дата

<a name='P-WebArg-CurrencyRates-WebAPI-Features-DtoModels-CurrencyRate-Value'></a>
### Value `property`

##### Summary

Курс валюты

<a name='T-WebArg-CurrencyRates-WebAPI-Middlewares-ExceptionMiddleware'></a>
## ExceptionMiddleware `type`

##### Namespace

WebArg.CurrencyRates.WebAPI.Middlewares

##### Summary

Обработчик ошибок

<a name='T-WebArg-CurrencyRates-WebAPI-Features-Queries-GetCurrencyCodesQuery'></a>
## GetCurrencyCodesQuery `type`

##### Namespace

WebArg.CurrencyRates.WebAPI.Features.Queries

##### Summary

Получить коды валют

<a name='T-WebArg-CurrencyRates-WebAPI-Features-Queries-GetCurrencyRateTodayQuery'></a>
## GetCurrencyRateTodayQuery `type`

##### Namespace

WebArg.CurrencyRates.WebAPI.Features.Queries

##### Summary

Получить код валюты за текущее число

<a name='P-WebArg-CurrencyRates-WebAPI-Features-Queries-GetCurrencyRateTodayQuery-Code'></a>
### Code `property`

##### Summary

Код валюты

<a name='T-WebArg-CurrencyRates-WebAPI-Features-Queries-GetReportQuery'></a>
## GetReportQuery `type`

##### Namespace

WebArg.CurrencyRates.WebAPI.Features.Queries

##### Summary

Получить отчет о курсах валют за период

<a name='P-WebArg-CurrencyRates-WebAPI-Features-Queries-GetReportQuery-Codes'></a>
### Codes `property`

##### Summary

Коды валют

<a name='P-WebArg-CurrencyRates-WebAPI-Features-Queries-GetReportQuery-EndDate'></a>
### EndDate `property`

##### Summary

Дата конца периода

<a name='P-WebArg-CurrencyRates-WebAPI-Features-Queries-GetReportQuery-StartDate'></a>
### StartDate `property`

##### Summary

Дата начала периода

<a name='T-WebArg-CurrencyRates-WebAPI-Controllers-ManageController'></a>
## ManageController `type`

##### Namespace

WebArg.CurrencyRates.WebAPI.Controllers

##### Summary

Курс валюты чешской кроны

<a name='M-WebArg-CurrencyRates-WebAPI-Controllers-ManageController-GetCurrencyCodes-System-Threading-CancellationToken-'></a>
### GetCurrencyCodes(cancellationToken) `method`

##### Summary

Получить коды валют

##### Returns

Коды валют

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='M-WebArg-CurrencyRates-WebAPI-Controllers-ManageController-GetCurrencyRateToday-WebArg-CurrencyRates-WebAPI-Features-Queries-GetCurrencyRateTodayQuery,System-Threading-CancellationToken-'></a>
### GetCurrencyRateToday(query,cancellationToken) `method`

##### Summary

Получить курс валюты за текущий день

##### Returns

Курс валюты за текущий день

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| query | [WebArg.CurrencyRates.WebAPI.Features.Queries.GetCurrencyRateTodayQuery](#T-WebArg-CurrencyRates-WebAPI-Features-Queries-GetCurrencyRateTodayQuery 'WebArg.CurrencyRates.WebAPI.Features.Queries.GetCurrencyRateTodayQuery') | Dto параметр |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='M-WebArg-CurrencyRates-WebAPI-Controllers-ManageController-GetReport-WebArg-CurrencyRates-WebAPI-Features-Queries-GetReportQuery,System-Threading-CancellationToken-'></a>
### GetReport(query,cancellationToken) `method`

##### Summary

Получить отчет о курсах валют за период

##### Returns

Отчет о курсах валют за период

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| query | [WebArg.CurrencyRates.WebAPI.Features.Queries.GetReportQuery](#T-WebArg-CurrencyRates-WebAPI-Features-Queries-GetReportQuery 'WebArg.CurrencyRates.WebAPI.Features.Queries.GetReportQuery') | Dto параметр |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='M-WebArg-CurrencyRates-WebAPI-Controllers-ManageController-SaveReport-WebArg-CurrencyRates-WebAPI-Features-Commands-SaveReportCommand,System-Threading-CancellationToken-'></a>
### SaveReport(command,cancellationToken) `method`

##### Summary

Запросить отчет за период

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| command | [WebArg.CurrencyRates.WebAPI.Features.Commands.SaveReportCommand](#T-WebArg-CurrencyRates-WebAPI-Features-Commands-SaveReportCommand 'WebArg.CurrencyRates.WebAPI.Features.Commands.SaveReportCommand') | Dto параметр |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='T-WebArg-CurrencyRates-WebAPI-Features-DtoModels-ReportResponseDto'></a>
## ReportResponseDto `type`

##### Namespace

WebArg.CurrencyRates.WebAPI.Features.DtoModels

##### Summary

Отчет о курсе валюты за период

<a name='P-WebArg-CurrencyRates-WebAPI-Features-DtoModels-ReportResponseDto-Avg'></a>
### Avg `property`

##### Summary

Среднее значение курса

<a name='P-WebArg-CurrencyRates-WebAPI-Features-DtoModels-ReportResponseDto-Code'></a>
### Code `property`

##### Summary

Код валюты

<a name='P-WebArg-CurrencyRates-WebAPI-Features-DtoModels-ReportResponseDto-Max'></a>
### Max `property`

##### Summary

Максимальный курс

<a name='P-WebArg-CurrencyRates-WebAPI-Features-DtoModels-ReportResponseDto-Min'></a>
### Min `property`

##### Summary

Минимальный курс

<a name='T-WebArg-CurrencyRates-WebAPI-Features-Mappers-ReportResponseMapper'></a>
## ReportResponseMapper `type`

##### Namespace

WebArg.CurrencyRates.WebAPI.Features.Mappers

##### Summary

Mapper Report DtoModels

<a name='T-WebArg-CurrencyRates-WebAPI-Features-Commands-SaveReportCommand'></a>
## SaveReportCommand `type`

##### Namespace

WebArg.CurrencyRates.WebAPI.Features.Commands

##### Summary

Запросить отчет за период

<a name='P-WebArg-CurrencyRates-WebAPI-Features-Commands-SaveReportCommand-Report'></a>
### Report `property`

##### Summary

Данные для формирования отчета

<a name='T-WebArg-CurrencyRates-WebAPI-Features-DtoModels-SaveReportRequestDto'></a>
## SaveReportRequestDto `type`

##### Namespace

WebArg.CurrencyRates.WebAPI.Features.DtoModels

##### Summary

Данные формирования отчета

<a name='P-WebArg-CurrencyRates-WebAPI-Features-DtoModels-SaveReportRequestDto-EndDate'></a>
### EndDate `property`

##### Summary

Дата конца периода

<a name='P-WebArg-CurrencyRates-WebAPI-Features-DtoModels-SaveReportRequestDto-StartDate'></a>
### StartDate `property`

##### Summary

Дата начала периода

<a name='T-WebArg-CurrencyRates-WebAPI-Extensions-ServiceCollectionExtensions'></a>
## ServiceCollectionExtensions `type`

##### Namespace

WebArg.CurrencyRates.WebAPI.Extensions

##### Summary

Регистрация сервисов в DI

<a name='M-WebArg-CurrencyRates-WebAPI-Extensions-ServiceCollectionExtensions-AddDataContext-Microsoft-Extensions-DependencyInjection-IServiceCollection,Microsoft-Extensions-Configuration-IConfiguration-'></a>
### AddDataContext(services,configuration) `method`

##### Summary

Регистрация Контекста базы данных

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') | Коллекция дескрипторов служб |
| configuration | [Microsoft.Extensions.Configuration.IConfiguration](#T-Microsoft-Extensions-Configuration-IConfiguration 'Microsoft.Extensions.Configuration.IConfiguration') | Набор свойств конфигурации |

<a name='M-WebArg-CurrencyRates-WebAPI-Extensions-ServiceCollectionExtensions-AddFluentValidationSetup-Microsoft-Extensions-DependencyInjection-IServiceCollection,System-Type-'></a>
### AddFluentValidationSetup(services,type) `method`

##### Summary

Регистрация FluentValidation в DI

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') | Коллекция дескрипторов служб |
| type | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Глобальный тип для поиска валидаторов |

<a name='M-WebArg-CurrencyRates-WebAPI-Extensions-ServiceCollectionExtensions-AddSwaggerSetup-Microsoft-Extensions-DependencyInjection-IServiceCollection-'></a>
### AddSwaggerSetup(services) `method`

##### Summary

Регистрация Swagger

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') | Коллекция дескрипторов служб |

<a name='M-WebArg-CurrencyRates-WebAPI-Extensions-ServiceCollectionExtensions-AddWebMappers-Microsoft-Extensions-DependencyInjection-IServiceCollection-'></a>
### AddWebMappers(services) `method`

##### Summary

Регистрация Mapper

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') | Коллекция дескрипторов служб |

<a name='M-WebArg-CurrencyRates-WebAPI-Extensions-ServiceCollectionExtensions-AddWebServices-Microsoft-Extensions-DependencyInjection-IServiceCollection-'></a>
### AddWebServices(services) `method`

##### Summary

Регистрация сервисов

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') | Коллекция дескрипторов служб |
