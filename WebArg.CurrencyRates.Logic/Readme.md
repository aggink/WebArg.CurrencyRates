<a name='assembly'></a>
# WebArg.CurrencyRates.Logic

## Contents

- [ConfigurationExtensions](#T-WebArg-CurrencyRates-Logic-Extensions-ConfigurationExtensions 'WebArg.CurrencyRates.Logic.Extensions.ConfigurationExtensions')
  - [GetDefaultConnectionString(configuration)](#M-WebArg-CurrencyRates-Logic-Extensions-ConfigurationExtensions-GetDefaultConnectionString-Microsoft-Extensions-Configuration-IConfiguration- 'WebArg.CurrencyRates.Logic.Extensions.ConfigurationExtensions.GetDefaultConnectionString(Microsoft.Extensions.Configuration.IConfiguration)')
- [IReportDailyService](#T-WebArg-CurrencyRates-Logic-Interfaces-Services-IReportDailyService 'WebArg.CurrencyRates.Logic.Interfaces.Services.IReportDailyService')
  - [AddReportAsync(dataContext,start,end,cancellationToken)](#M-WebArg-CurrencyRates-Logic-Interfaces-Services-IReportDailyService-AddReportAsync-WebArg-CurrencyRates-Storage-Database-DataContext,System-DateOnly,System-DateOnly,System-Threading-CancellationToken- 'WebArg.CurrencyRates.Logic.Interfaces.Services.IReportDailyService.AddReportAsync(WebArg.CurrencyRates.Storage.Database.DataContext,System.DateOnly,System.DateOnly,System.Threading.CancellationToken)')
  - [GetReportAsync(dataContext,start,end,codes,cancellationToken)](#M-WebArg-CurrencyRates-Logic-Interfaces-Services-IReportDailyService-GetReportAsync-WebArg-CurrencyRates-Storage-Database-DataContext,System-DateOnly,System-DateOnly,System-String[],System-Threading-CancellationToken- 'WebArg.CurrencyRates.Logic.Interfaces.Services.IReportDailyService.GetReportAsync(WebArg.CurrencyRates.Storage.Database.DataContext,System.DateOnly,System.DateOnly,System.String[],System.Threading.CancellationToken)')
- [IRepository](#T-WebArg-CurrencyRates-Logic-Interfaces-Repositories-IRepository 'WebArg.CurrencyRates.Logic.Interfaces.Repositories.IRepository')
  - [AddReportAsync(dataContext,report,cancellationToken)](#M-WebArg-CurrencyRates-Logic-Interfaces-Repositories-IRepository-AddReportAsync-WebArg-CurrencyRates-Storage-Database-DataContext,WebArg-CurrencyRates-Cron-DtoModels-ReportDailyDto,System-Threading-CancellationToken- 'WebArg.CurrencyRates.Logic.Interfaces.Repositories.IRepository.AddReportAsync(WebArg.CurrencyRates.Storage.Database.DataContext,WebArg.CurrencyRates.Cron.DtoModels.ReportDailyDto,System.Threading.CancellationToken)')
- [LogicException](#T-WebArg-CurrencyRates-Logic-Exceptions-LogicException 'WebArg.CurrencyRates.Logic.Exceptions.LogicException')
- [ReportDailyService](#T-WebArg-CurrencyRates-Logic-Services-ReportDailyService 'WebArg.CurrencyRates.Logic.Services.ReportDailyService')
  - [GetDays(start,end)](#M-WebArg-CurrencyRates-Logic-Services-ReportDailyService-GetDays-System-DateOnly,System-DateOnly- 'WebArg.CurrencyRates.Logic.Services.ReportDailyService.GetDays(System.DateOnly,System.DateOnly)')
- [ReportDto](#T-WebArg-CurrencyRates-Logic-DtoModels-ReportDto 'WebArg.CurrencyRates.Logic.DtoModels.ReportDto')
  - [Avg](#P-WebArg-CurrencyRates-Logic-DtoModels-ReportDto-Avg 'WebArg.CurrencyRates.Logic.DtoModels.ReportDto.Avg')
  - [Code](#P-WebArg-CurrencyRates-Logic-DtoModels-ReportDto-Code 'WebArg.CurrencyRates.Logic.DtoModels.ReportDto.Code')
  - [DateFrom](#P-WebArg-CurrencyRates-Logic-DtoModels-ReportDto-DateFrom 'WebArg.CurrencyRates.Logic.DtoModels.ReportDto.DateFrom')
  - [DateTo](#P-WebArg-CurrencyRates-Logic-DtoModels-ReportDto-DateTo 'WebArg.CurrencyRates.Logic.DtoModels.ReportDto.DateTo')
  - [Max](#P-WebArg-CurrencyRates-Logic-DtoModels-ReportDto-Max 'WebArg.CurrencyRates.Logic.DtoModels.ReportDto.Max')
  - [Min](#P-WebArg-CurrencyRates-Logic-DtoModels-ReportDto-Min 'WebArg.CurrencyRates.Logic.DtoModels.ReportDto.Min')
- [ServiceCollectionExtensions](#T-WebArg-CurrencyRates-Logic-Extensions-ServiceCollectionExtensions 'WebArg.CurrencyRates.Logic.Extensions.ServiceCollectionExtensions')
  - [AddLogicServices(services)](#M-WebArg-CurrencyRates-Logic-Extensions-ServiceCollectionExtensions-AddLogicServices-Microsoft-Extensions-DependencyInjection-IServiceCollection- 'WebArg.CurrencyRates.Logic.Extensions.ServiceCollectionExtensions.AddLogicServices(Microsoft.Extensions.DependencyInjection.IServiceCollection)')

<a name='T-WebArg-CurrencyRates-Logic-Extensions-ConfigurationExtensions'></a>
## ConfigurationExtensions `type`

##### Namespace

WebArg.CurrencyRates.Logic.Extensions

##### Summary

Получение данных из файла настроек

<a name='M-WebArg-CurrencyRates-Logic-Extensions-ConfigurationExtensions-GetDefaultConnectionString-Microsoft-Extensions-Configuration-IConfiguration-'></a>
### GetDefaultConnectionString(configuration) `method`

##### Summary

Получить строку подключения к БД

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configuration | [Microsoft.Extensions.Configuration.IConfiguration](#T-Microsoft-Extensions-Configuration-IConfiguration 'Microsoft.Extensions.Configuration.IConfiguration') | Набор свойств конфигурации |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [WebArg.CurrencyRates.Logic.Exceptions.LogicException](#T-WebArg-CurrencyRates-Logic-Exceptions-LogicException 'WebArg.CurrencyRates.Logic.Exceptions.LogicException') | Данные не найдены |

<a name='T-WebArg-CurrencyRates-Logic-Interfaces-Services-IReportDailyService'></a>
## IReportDailyService `type`

##### Namespace

WebArg.CurrencyRates.Logic.Interfaces.Services

##### Summary

Сервис обработки данные для [ReportDaily](#T-WebArg-CurrencyRates-Storage-Models-ReportDaily 'WebArg.CurrencyRates.Storage.Models.ReportDaily')

<a name='M-WebArg-CurrencyRates-Logic-Interfaces-Services-IReportDailyService-AddReportAsync-WebArg-CurrencyRates-Storage-Database-DataContext,System-DateOnly,System-DateOnly,System-Threading-CancellationToken-'></a>
### AddReportAsync(dataContext,start,end,cancellationToken) `method`

##### Summary

Сохранить данные о курсе валют

##### Returns

[Task](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.Task 'System.Threading.Tasks.Task')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dataContext | [WebArg.CurrencyRates.Storage.Database.DataContext](#T-WebArg-CurrencyRates-Storage-Database-DataContext 'WebArg.CurrencyRates.Storage.Database.DataContext') | Контекст базы данных |
| start | [System.DateOnly](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateOnly 'System.DateOnly') | Начало периода |
| end | [System.DateOnly](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateOnly 'System.DateOnly') | Конец периода |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='M-WebArg-CurrencyRates-Logic-Interfaces-Services-IReportDailyService-GetReportAsync-WebArg-CurrencyRates-Storage-Database-DataContext,System-DateOnly,System-DateOnly,System-String[],System-Threading-CancellationToken-'></a>
### GetReportAsync(dataContext,start,end,codes,cancellationToken) `method`

##### Summary

Получить данные о курсе валют за период

##### Returns

Данные о курсе валют за период

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dataContext | [WebArg.CurrencyRates.Storage.Database.DataContext](#T-WebArg-CurrencyRates-Storage-Database-DataContext 'WebArg.CurrencyRates.Storage.Database.DataContext') | Контекст базы данных |
| start | [System.DateOnly](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateOnly 'System.DateOnly') | Начала периода |
| end | [System.DateOnly](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateOnly 'System.DateOnly') | Конец периода |
| codes | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | Коды валют |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='T-WebArg-CurrencyRates-Logic-Interfaces-Repositories-IRepository'></a>
## IRepository `type`

##### Namespace

WebArg.CurrencyRates.Logic.Interfaces.Repositories

##### Summary

CRUD методы для таблицы [ReportDaily](#T-WebArg-CurrencyRates-Storage-Models-ReportDaily 'WebArg.CurrencyRates.Storage.Models.ReportDaily')

<a name='M-WebArg-CurrencyRates-Logic-Interfaces-Repositories-IRepository-AddReportAsync-WebArg-CurrencyRates-Storage-Database-DataContext,WebArg-CurrencyRates-Cron-DtoModels-ReportDailyDto,System-Threading-CancellationToken-'></a>
### AddReportAsync(dataContext,report,cancellationToken) `method`

##### Summary

Сохранить данные о курсе валюты

##### Returns

[Task](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.Task 'System.Threading.Tasks.Task')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dataContext | [WebArg.CurrencyRates.Storage.Database.DataContext](#T-WebArg-CurrencyRates-Storage-Database-DataContext 'WebArg.CurrencyRates.Storage.Database.DataContext') | Контекст базы данных |
| report | [WebArg.CurrencyRates.Cron.DtoModels.ReportDailyDto](#T-WebArg-CurrencyRates-Cron-DtoModels-ReportDailyDto 'WebArg.CurrencyRates.Cron.DtoModels.ReportDailyDto') | Курс валюты |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='T-WebArg-CurrencyRates-Logic-Exceptions-LogicException'></a>
## LogicException `type`

##### Namespace

WebArg.CurrencyRates.Logic.Exceptions

##### Summary

Ошибка выброшенная разработчиком

<a name='T-WebArg-CurrencyRates-Logic-Services-ReportDailyService'></a>
## ReportDailyService `type`

##### Namespace

WebArg.CurrencyRates.Logic.Services

<a name='M-WebArg-CurrencyRates-Logic-Services-ReportDailyService-GetDays-System-DateOnly,System-DateOnly-'></a>
### GetDays(start,end) `method`

##### Summary

Получить список дат

##### Returns

Список дат

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| start | [System.DateOnly](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateOnly 'System.DateOnly') | Начало периода |
| end | [System.DateOnly](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateOnly 'System.DateOnly') | Конец периода |

<a name='T-WebArg-CurrencyRates-Logic-DtoModels-ReportDto'></a>
## ReportDto `type`

##### Namespace

WebArg.CurrencyRates.Logic.DtoModels

##### Summary

Отчет о курсе валюты за период

<a name='P-WebArg-CurrencyRates-Logic-DtoModels-ReportDto-Avg'></a>
### Avg `property`

##### Summary

Среднее значение

<a name='P-WebArg-CurrencyRates-Logic-DtoModels-ReportDto-Code'></a>
### Code `property`

##### Summary

Код валюты

<a name='P-WebArg-CurrencyRates-Logic-DtoModels-ReportDto-DateFrom'></a>
### DateFrom `property`

##### Summary

Начало периода

<a name='P-WebArg-CurrencyRates-Logic-DtoModels-ReportDto-DateTo'></a>
### DateTo `property`

##### Summary

Конец периода

<a name='P-WebArg-CurrencyRates-Logic-DtoModels-ReportDto-Max'></a>
### Max `property`

##### Summary

Максимальное значение

<a name='P-WebArg-CurrencyRates-Logic-DtoModels-ReportDto-Min'></a>
### Min `property`

##### Summary

Минимальное значение

<a name='T-WebArg-CurrencyRates-Logic-Extensions-ServiceCollectionExtensions'></a>
## ServiceCollectionExtensions `type`

##### Namespace

WebArg.CurrencyRates.Logic.Extensions

##### Summary

Регистрация сервисов в DI

<a name='M-WebArg-CurrencyRates-Logic-Extensions-ServiceCollectionExtensions-AddLogicServices-Microsoft-Extensions-DependencyInjection-IServiceCollection-'></a>
### AddLogicServices(services) `method`

##### Summary

Регистрация сервисов библиотеки Logic в DI

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') | Коллекция дескрипторов служб |
