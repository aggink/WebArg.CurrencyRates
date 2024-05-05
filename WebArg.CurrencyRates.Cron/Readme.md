<a name='assembly'></a>
# WebArg.CurrencyRates.Cron

## Contents

- [CronException](#T-WebArg-CurrencyRates-Cron-Exceptions-CronException 'WebArg.CurrencyRates.Cron.Exceptions.CronException')
- [CronService](#T-WebArg-CurrencyRates-Cron-Services-CronService 'WebArg.CurrencyRates.Cron.Services.CronService')
  - [Parse(report)](#M-WebArg-CurrencyRates-Cron-Services-CronService-Parse-System-String- 'WebArg.CurrencyRates.Cron.Services.CronService.Parse(System.String)')
- [Generated](#T-Refit-Implementation-Generated 'Refit.Implementation.Generated')
- [IApiCronService](#T-WebArg-CurrencyRates-Cron-Refit-IApiCronService 'WebArg.CurrencyRates.Cron.Refit.IApiCronService')
  - [GetDailyReport(date,cancellationToken)](#M-WebArg-CurrencyRates-Cron-Refit-IApiCronService-GetDailyReport-System-String,System-Threading-CancellationToken- 'WebArg.CurrencyRates.Cron.Refit.IApiCronService.GetDailyReport(System.String,System.Threading.CancellationToken)')
- [ICronService](#T-WebArg-CurrencyRates-Cron-Interfaces-Services-ICronService 'WebArg.CurrencyRates.Cron.Interfaces.Services.ICronService')
  - [DownloadReportAsync(date,cancellationToken)](#M-WebArg-CurrencyRates-Cron-Interfaces-Services-ICronService-DownloadReportAsync-System-DateOnly,System-Threading-CancellationToken- 'WebArg.CurrencyRates.Cron.Interfaces.Services.ICronService.DownloadReportAsync(System.DateOnly,System.Threading.CancellationToken)')
- [RefitException](#T-WebArg-CurrencyRates-Cron-Exceptions-RefitException 'WebArg.CurrencyRates.Cron.Exceptions.RefitException')
- [RefitExtensions](#T-WebArg-CurrencyRates-Cron-Extensions-RefitExtensions 'WebArg.CurrencyRates.Cron.Extensions.RefitExtensions')
  - [GetRequestMessage\`\`1(response)](#M-WebArg-CurrencyRates-Cron-Extensions-RefitExtensions-GetRequestMessage``1-Refit-IApiResponse{``0}- 'WebArg.CurrencyRates.Cron.Extensions.RefitExtensions.GetRequestMessage``1(Refit.IApiResponse{``0})')
  - [GetResponseMessage\`\`1(response)](#M-WebArg-CurrencyRates-Cron-Extensions-RefitExtensions-GetResponseMessage``1-Refit-IApiResponse{``0}- 'WebArg.CurrencyRates.Cron.Extensions.RefitExtensions.GetResponseMessage``1(Refit.IApiResponse{``0})')
  - [RefitResponseValidate\`\`1(response,logger,checkContent)](#M-WebArg-CurrencyRates-Cron-Extensions-RefitExtensions-RefitResponseValidate``1-Refit-IApiResponse{``0},Microsoft-Extensions-Logging-ILogger,System-Boolean- 'WebArg.CurrencyRates.Cron.Extensions.RefitExtensions.RefitResponseValidate``1(Refit.IApiResponse{``0},Microsoft.Extensions.Logging.ILogger,System.Boolean)')
- [ReportDailyDto](#T-WebArg-CurrencyRates-Cron-DtoModels-ReportDailyDto 'WebArg.CurrencyRates.Cron.DtoModels.ReportDailyDto')
  - [Date](#P-WebArg-CurrencyRates-Cron-DtoModels-ReportDailyDto-Date 'WebArg.CurrencyRates.Cron.DtoModels.ReportDailyDto.Date')
  - [Reports](#P-WebArg-CurrencyRates-Cron-DtoModels-ReportDailyDto-Reports 'WebArg.CurrencyRates.Cron.DtoModels.ReportDailyDto.Reports')
- [ReportDataDto](#T-WebArg-CurrencyRates-Cron-DtoModels-ReportDataDto 'WebArg.CurrencyRates.Cron.DtoModels.ReportDataDto')
  - [Amount](#P-WebArg-CurrencyRates-Cron-DtoModels-ReportDataDto-Amount 'WebArg.CurrencyRates.Cron.DtoModels.ReportDataDto.Amount')
  - [Code](#P-WebArg-CurrencyRates-Cron-DtoModels-ReportDataDto-Code 'WebArg.CurrencyRates.Cron.DtoModels.ReportDataDto.Code')
  - [Country](#P-WebArg-CurrencyRates-Cron-DtoModels-ReportDataDto-Country 'WebArg.CurrencyRates.Cron.DtoModels.ReportDataDto.Country')
  - [Currency](#P-WebArg-CurrencyRates-Cron-DtoModels-ReportDataDto-Currency 'WebArg.CurrencyRates.Cron.DtoModels.ReportDataDto.Currency')
  - [Rate](#P-WebArg-CurrencyRates-Cron-DtoModels-ReportDataDto-Rate 'WebArg.CurrencyRates.Cron.DtoModels.ReportDataDto.Rate')
- [ServiceCollectionExtensions](#T-WebArg-CurrencyRates-Cron-Extensions-ServiceCollectionExtensions 'WebArg.CurrencyRates.Cron.Extensions.ServiceCollectionExtensions')
  - [AddCronRefitServices(services)](#M-WebArg-CurrencyRates-Cron-Extensions-ServiceCollectionExtensions-AddCronRefitServices-Microsoft-Extensions-DependencyInjection-IServiceCollection- 'WebArg.CurrencyRates.Cron.Extensions.ServiceCollectionExtensions.AddCronRefitServices(Microsoft.Extensions.DependencyInjection.IServiceCollection)')
  - [AddCronServices(services)](#M-WebArg-CurrencyRates-Cron-Extensions-ServiceCollectionExtensions-AddCronServices-Microsoft-Extensions-DependencyInjection-IServiceCollection- 'WebArg.CurrencyRates.Cron.Extensions.ServiceCollectionExtensions.AddCronServices(Microsoft.Extensions.DependencyInjection.IServiceCollection)')
- [WebArgCurrencyRatesCronRefitIApiCronService](#T-Refit-Implementation-Generated-WebArgCurrencyRatesCronRefitIApiCronService 'Refit.Implementation.Generated.WebArgCurrencyRatesCronRefitIApiCronService')
  - [#ctor()](#M-Refit-Implementation-Generated-WebArgCurrencyRatesCronRefitIApiCronService-#ctor-System-Net-Http-HttpClient,Refit-IRequestBuilder- 'Refit.Implementation.Generated.WebArgCurrencyRatesCronRefitIApiCronService.#ctor(System.Net.Http.HttpClient,Refit.IRequestBuilder)')
  - [Client](#P-Refit-Implementation-Generated-WebArgCurrencyRatesCronRefitIApiCronService-Client 'Refit.Implementation.Generated.WebArgCurrencyRatesCronRefitIApiCronService.Client')
  - [GetDailyReport()](#M-Refit-Implementation-Generated-WebArgCurrencyRatesCronRefitIApiCronService-GetDailyReport-System-String,System-Threading-CancellationToken- 'Refit.Implementation.Generated.WebArgCurrencyRatesCronRefitIApiCronService.GetDailyReport(System.String,System.Threading.CancellationToken)')
  - [WebArg#CurrencyRates#Cron#Refit#IApiCronService#GetDailyReport()](#M-Refit-Implementation-Generated-WebArgCurrencyRatesCronRefitIApiCronService-WebArg#CurrencyRates#Cron#Refit#IApiCronService#GetDailyReport-System-String,System-Threading-CancellationToken- 'Refit.Implementation.Generated.WebArgCurrencyRatesCronRefitIApiCronService.WebArg#CurrencyRates#Cron#Refit#IApiCronService#GetDailyReport(System.String,System.Threading.CancellationToken)')

<a name='T-WebArg-CurrencyRates-Cron-Exceptions-CronException'></a>
## CronException `type`

##### Namespace

WebArg.CurrencyRates.Cron.Exceptions

##### Summary

Выброшенная ошибка разработчиком

<a name='T-WebArg-CurrencyRates-Cron-Services-CronService'></a>
## CronService `type`

##### Namespace

WebArg.CurrencyRates.Cron.Services

##### Summary

Получение данных о курсе чешской кроны

<a name='M-WebArg-CurrencyRates-Cron-Services-CronService-Parse-System-String-'></a>
### Parse(report) `method`

##### Summary

Распарсить отчет от API чешского банка с данными о курсе чешской кроны

##### Returns

Отчет о курсе чешской кроны

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| report | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Отчет о курсе чешской кроны |

<a name='T-Refit-Implementation-Generated'></a>
## Generated `type`

##### Namespace

Refit.Implementation

##### Summary

*Inherit from parent.*

<a name='T-WebArg-CurrencyRates-Cron-Refit-IApiCronService'></a>
## IApiCronService `type`

##### Namespace

WebArg.CurrencyRates.Cron.Refit

##### Summary

Запросы к API Чешского банка

<a name='M-WebArg-CurrencyRates-Cron-Refit-IApiCronService-GetDailyReport-System-String,System-Threading-CancellationToken-'></a>
### GetDailyReport(date,cancellationToken) `method`

##### Summary

Получить курс чешской кроны за определенную дату

##### Returns

Курс чешской кроны

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| date | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Дата |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='T-WebArg-CurrencyRates-Cron-Interfaces-Services-ICronService'></a>
## ICronService `type`

##### Namespace

WebArg.CurrencyRates.Cron.Interfaces.Services

##### Summary

Сервис запросов данных о курсе чешской кроны

<a name='M-WebArg-CurrencyRates-Cron-Interfaces-Services-ICronService-DownloadReportAsync-System-DateOnly,System-Threading-CancellationToken-'></a>
### DownloadReportAsync(date,cancellationToken) `method`

##### Summary

Получить курс чешской кроны за определенную дату

##### Returns

Курс чешской кроны за запрашиваемую дату

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| date | [System.DateOnly](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateOnly 'System.DateOnly') | Дата |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='T-WebArg-CurrencyRates-Cron-Exceptions-RefitException'></a>
## RefitException `type`

##### Namespace

WebArg.CurrencyRates.Cron.Exceptions

##### Summary

Ошибка выброшенная разработчиком

<a name='T-WebArg-CurrencyRates-Cron-Extensions-RefitExtensions'></a>
## RefitExtensions `type`

##### Namespace

WebArg.CurrencyRates.Cron.Extensions

<a name='M-WebArg-CurrencyRates-Cron-Extensions-RefitExtensions-GetRequestMessage``1-Refit-IApiResponse{``0}-'></a>
### GetRequestMessage\`\`1(response) `method`

##### Summary

Получить описание запроса

##### Returns

Описание запроса

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| response | [Refit.IApiResponse{\`\`0}](#T-Refit-IApiResponse{``0} 'Refit.IApiResponse{``0}') | Ответ от сервера |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Тип ответа |

<a name='M-WebArg-CurrencyRates-Cron-Extensions-RefitExtensions-GetResponseMessage``1-Refit-IApiResponse{``0}-'></a>
### GetResponseMessage\`\`1(response) `method`

##### Summary

Получить описание ответа

##### Returns

Описание ответа

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| response | [Refit.IApiResponse{\`\`0}](#T-Refit-IApiResponse{``0} 'Refit.IApiResponse{``0}') | Ответ от сервера |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Тип ответа |

<a name='M-WebArg-CurrencyRates-Cron-Extensions-RefitExtensions-RefitResponseValidate``1-Refit-IApiResponse{``0},Microsoft-Extensions-Logging-ILogger,System-Boolean-'></a>
### RefitResponseValidate\`\`1(response,logger,checkContent) `method`

##### Summary

Проверка ответа сервера

##### Returns

True - проверка завершилась успешно

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| response | [Refit.IApiResponse{\`\`0}](#T-Refit-IApiResponse{``0} 'Refit.IApiResponse{``0}') | Ответ |
| logger | [Microsoft.Extensions.Logging.ILogger](#T-Microsoft-Extensions-Logging-ILogger 'Microsoft.Extensions.Logging.ILogger') | Журнал логирования |
| checkContent | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Проверить наличие контента |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [WebArg.CurrencyRates.Cron.Exceptions.RefitException](#T-WebArg-CurrencyRates-Cron-Exceptions-RefitException 'WebArg.CurrencyRates.Cron.Exceptions.RefitException') | В ходе выполнения запроса произошла ошибка |

<a name='T-WebArg-CurrencyRates-Cron-DtoModels-ReportDailyDto'></a>
## ReportDailyDto `type`

##### Namespace

WebArg.CurrencyRates.Cron.DtoModels

##### Summary

Ежедневный отчет о курсе чешской кроны

<a name='P-WebArg-CurrencyRates-Cron-DtoModels-ReportDailyDto-Date'></a>
### Date `property`

##### Summary

Дата

<a name='P-WebArg-CurrencyRates-Cron-DtoModels-ReportDailyDto-Reports'></a>
### Reports `property`

##### Summary

Информация о курсе

<a name='T-WebArg-CurrencyRates-Cron-DtoModels-ReportDataDto'></a>
## ReportDataDto `type`

##### Namespace

WebArg.CurrencyRates.Cron.DtoModels

##### Summary

Информация о курсе

<a name='P-WebArg-CurrencyRates-Cron-DtoModels-ReportDataDto-Amount'></a>
### Amount `property`

##### Summary

Номинал

<a name='P-WebArg-CurrencyRates-Cron-DtoModels-ReportDataDto-Code'></a>
### Code `property`

##### Summary

Код валюты

<a name='P-WebArg-CurrencyRates-Cron-DtoModels-ReportDataDto-Country'></a>
### Country `property`

##### Summary

Страна

<a name='P-WebArg-CurrencyRates-Cron-DtoModels-ReportDataDto-Currency'></a>
### Currency `property`

##### Summary

Валюта

<a name='P-WebArg-CurrencyRates-Cron-DtoModels-ReportDataDto-Rate'></a>
### Rate `property`

##### Summary

Курс

<a name='T-WebArg-CurrencyRates-Cron-Extensions-ServiceCollectionExtensions'></a>
## ServiceCollectionExtensions `type`

##### Namespace

WebArg.CurrencyRates.Cron.Extensions

##### Summary

Регистрация сервисов в DI

<a name='M-WebArg-CurrencyRates-Cron-Extensions-ServiceCollectionExtensions-AddCronRefitServices-Microsoft-Extensions-DependencyInjection-IServiceCollection-'></a>
### AddCronRefitServices(services) `method`

##### Summary

Регистрация Refit Cron API

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') | Коллекция дескрипторов служб |

<a name='M-WebArg-CurrencyRates-Cron-Extensions-ServiceCollectionExtensions-AddCronServices-Microsoft-Extensions-DependencyInjection-IServiceCollection-'></a>
### AddCronServices(services) `method`

##### Summary

Регистрация сервисов библиотеки Cron в DI

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') | Коллекция дескрипторов служб |

<a name='T-Refit-Implementation-Generated-WebArgCurrencyRatesCronRefitIApiCronService'></a>
## WebArgCurrencyRatesCronRefitIApiCronService `type`

##### Namespace

Refit.Implementation.Generated

##### Summary

*Inherit from parent.*

<a name='M-Refit-Implementation-Generated-WebArgCurrencyRatesCronRefitIApiCronService-#ctor-System-Net-Http-HttpClient,Refit-IRequestBuilder-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='P-Refit-Implementation-Generated-WebArgCurrencyRatesCronRefitIApiCronService-Client'></a>
### Client `property`

##### Summary

*Inherit from parent.*

<a name='M-Refit-Implementation-Generated-WebArgCurrencyRatesCronRefitIApiCronService-GetDailyReport-System-String,System-Threading-CancellationToken-'></a>
### GetDailyReport() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Refit-Implementation-Generated-WebArgCurrencyRatesCronRefitIApiCronService-WebArg#CurrencyRates#Cron#Refit#IApiCronService#GetDailyReport-System-String,System-Threading-CancellationToken-'></a>
### WebArg#CurrencyRates#Cron#Refit#IApiCronService#GetDailyReport() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.
