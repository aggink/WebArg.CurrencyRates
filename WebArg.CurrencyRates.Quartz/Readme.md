<a name='assembly'></a>
# WebArg.CurrencyRates.Quartz

## Contents

- [BaseJob](#T-WebArg-CurrencyRates-Quartz-Jobs-Base-BaseJob 'WebArg.CurrencyRates.Quartz.Jobs.Base.BaseJob')
- [ConfigurationExtensions](#T-WebArg-CurrencyRates-Quartz-Extensions-ConfigurationExtensions 'WebArg.CurrencyRates.Quartz.Extensions.ConfigurationExtensions')
  - [GetReportDailyCronSchedule(configuration)](#M-WebArg-CurrencyRates-Quartz-Extensions-ConfigurationExtensions-GetReportDailyCronSchedule-Microsoft-Extensions-Configuration-IConfiguration- 'WebArg.CurrencyRates.Quartz.Extensions.ConfigurationExtensions.GetReportDailyCronSchedule(Microsoft.Extensions.Configuration.IConfiguration)')
- [ExceptionMiddleware](#T-WebArg-CurrencyRates-Quartz-Middlewares-ExceptionMiddleware 'WebArg.CurrencyRates.Quartz.Middlewares.ExceptionMiddleware')
- [JobContext](#T-WebArg-CurrencyRates-Quartz-Jobs-Base-JobContext 'WebArg.CurrencyRates.Quartz.Jobs.Base.JobContext')
- [QuartzController](#T-WebArg-CurrencyRates-Quartz-Controllers-QuartzController 'WebArg.CurrencyRates.Quartz.Controllers.QuartzController')
- [QuartzException](#T-WebArg-CurrencyRates-Quartz-Exceptions-QuartzException 'WebArg.CurrencyRates.Quartz.Exceptions.QuartzException')
- [ReportDailyJob](#T-WebArg-CurrencyRates-Quartz-Jobs-ReportDailyJob 'WebArg.CurrencyRates.Quartz.Jobs.ReportDailyJob')
- [ServiceCollectionExtensions](#T-WebArg-CurrencyRates-Quartz-Extensions-ServiceCollectionExtensions 'WebArg.CurrencyRates.Quartz.Extensions.ServiceCollectionExtensions')
  - [MaxQuartzConcurrency](#F-WebArg-CurrencyRates-Quartz-Extensions-ServiceCollectionExtensions-MaxQuartzConcurrency 'WebArg.CurrencyRates.Quartz.Extensions.ServiceCollectionExtensions.MaxQuartzConcurrency')
  - [AddDataContext(services,configuration)](#M-WebArg-CurrencyRates-Quartz-Extensions-ServiceCollectionExtensions-AddDataContext-Microsoft-Extensions-DependencyInjection-IServiceCollection,Microsoft-Extensions-Configuration-IConfiguration- 'WebArg.CurrencyRates.Quartz.Extensions.ServiceCollectionExtensions.AddDataContext(Microsoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.Configuration.IConfiguration)')
  - [AddFluentValidationSetup(services,type)](#M-WebArg-CurrencyRates-Quartz-Extensions-ServiceCollectionExtensions-AddFluentValidationSetup-Microsoft-Extensions-DependencyInjection-IServiceCollection,System-Type- 'WebArg.CurrencyRates.Quartz.Extensions.ServiceCollectionExtensions.AddFluentValidationSetup(Microsoft.Extensions.DependencyInjection.IServiceCollection,System.Type)')
  - [AddQuartzServices(services)](#M-WebArg-CurrencyRates-Quartz-Extensions-ServiceCollectionExtensions-AddQuartzServices-Microsoft-Extensions-DependencyInjection-IServiceCollection- 'WebArg.CurrencyRates.Quartz.Extensions.ServiceCollectionExtensions.AddQuartzServices(Microsoft.Extensions.DependencyInjection.IServiceCollection)')
  - [AddSwaggerSetup(services)](#M-WebArg-CurrencyRates-Quartz-Extensions-ServiceCollectionExtensions-AddSwaggerSetup-Microsoft-Extensions-DependencyInjection-IServiceCollection- 'WebArg.CurrencyRates.Quartz.Extensions.ServiceCollectionExtensions.AddSwaggerSetup(Microsoft.Extensions.DependencyInjection.IServiceCollection)')
  - [RegisterJobs(services,configuration)](#M-WebArg-CurrencyRates-Quartz-Extensions-ServiceCollectionExtensions-RegisterJobs-Quartz-IServiceCollectionQuartzConfigurator,Microsoft-Extensions-Configuration-IConfiguration- 'WebArg.CurrencyRates.Quartz.Extensions.ServiceCollectionExtensions.RegisterJobs(Quartz.IServiceCollectionQuartzConfigurator,Microsoft.Extensions.Configuration.IConfiguration)')
  - [RegisterQuartzServices(services,configuration)](#M-WebArg-CurrencyRates-Quartz-Extensions-ServiceCollectionExtensions-RegisterQuartzServices-Microsoft-Extensions-DependencyInjection-IServiceCollection,Microsoft-Extensions-Configuration-IConfiguration- 'WebArg.CurrencyRates.Quartz.Extensions.ServiceCollectionExtensions.RegisterQuartzServices(Microsoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.Configuration.IConfiguration)')

<a name='T-WebArg-CurrencyRates-Quartz-Jobs-Base-BaseJob'></a>
## BaseJob `type`

##### Namespace

WebArg.CurrencyRates.Quartz.Jobs.Base

##### Summary

Базовый класс фоновой задачи

<a name='T-WebArg-CurrencyRates-Quartz-Extensions-ConfigurationExtensions'></a>
## ConfigurationExtensions `type`

##### Namespace

WebArg.CurrencyRates.Quartz.Extensions

##### Summary

Получение данных из файла настроек

<a name='M-WebArg-CurrencyRates-Quartz-Extensions-ConfigurationExtensions-GetReportDailyCronSchedule-Microsoft-Extensions-Configuration-IConfiguration-'></a>
### GetReportDailyCronSchedule(configuration) `method`

##### Summary

Получить расписание для фоновой задачи обновления курса валют

##### Returns

Расписание запуска фоновой задачи обновления курса валют

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configuration | [Microsoft.Extensions.Configuration.IConfiguration](#T-Microsoft-Extensions-Configuration-IConfiguration 'Microsoft.Extensions.Configuration.IConfiguration') | Набор свойств конфигурации |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [WebArg.CurrencyRates.Quartz.Exceptions.QuartzException](#T-WebArg-CurrencyRates-Quartz-Exceptions-QuartzException 'WebArg.CurrencyRates.Quartz.Exceptions.QuartzException') | Данные не найдены |

<a name='T-WebArg-CurrencyRates-Quartz-Middlewares-ExceptionMiddleware'></a>
## ExceptionMiddleware `type`

##### Namespace

WebArg.CurrencyRates.Quartz.Middlewares

##### Summary

Обработчик ошибок

<a name='T-WebArg-CurrencyRates-Quartz-Jobs-Base-JobContext'></a>
## JobContext `type`

##### Namespace

WebArg.CurrencyRates.Quartz.Jobs.Base

##### Summary

Сведения для планировщика

<a name='T-WebArg-CurrencyRates-Quartz-Controllers-QuartzController'></a>
## QuartzController `type`

##### Namespace

WebArg.CurrencyRates.Quartz.Controllers

##### Summary

Фоновые задачи

<a name='T-WebArg-CurrencyRates-Quartz-Exceptions-QuartzException'></a>
## QuartzException `type`

##### Namespace

WebArg.CurrencyRates.Quartz.Exceptions

##### Summary

Ошибка выброшенная разработчиком

<a name='T-WebArg-CurrencyRates-Quartz-Jobs-ReportDailyJob'></a>
## ReportDailyJob `type`

##### Namespace

WebArg.CurrencyRates.Quartz.Jobs

##### Summary

Фоновая задача обновления курса валюты чешской кроны

<a name='T-WebArg-CurrencyRates-Quartz-Extensions-ServiceCollectionExtensions'></a>
## ServiceCollectionExtensions `type`

##### Namespace

WebArg.CurrencyRates.Quartz.Extensions

##### Summary

Регистрация сервисов в DI

<a name='F-WebArg-CurrencyRates-Quartz-Extensions-ServiceCollectionExtensions-MaxQuartzConcurrency'></a>
### MaxQuartzConcurrency `constants`

##### Summary

Максимальное число фоновых потоков

<a name='M-WebArg-CurrencyRates-Quartz-Extensions-ServiceCollectionExtensions-AddDataContext-Microsoft-Extensions-DependencyInjection-IServiceCollection,Microsoft-Extensions-Configuration-IConfiguration-'></a>
### AddDataContext(services,configuration) `method`

##### Summary

Регистрация Контекста базы данных

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') | Коллекция дескрипторов служб |
| configuration | [Microsoft.Extensions.Configuration.IConfiguration](#T-Microsoft-Extensions-Configuration-IConfiguration 'Microsoft.Extensions.Configuration.IConfiguration') | Набор свойств конфигурации |

<a name='M-WebArg-CurrencyRates-Quartz-Extensions-ServiceCollectionExtensions-AddFluentValidationSetup-Microsoft-Extensions-DependencyInjection-IServiceCollection,System-Type-'></a>
### AddFluentValidationSetup(services,type) `method`

##### Summary

Регистрация FluentValidation в DI

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') | Коллекция дескрипторов служб |
| type | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Глобальный тип для поиска валидаторов |

<a name='M-WebArg-CurrencyRates-Quartz-Extensions-ServiceCollectionExtensions-AddQuartzServices-Microsoft-Extensions-DependencyInjection-IServiceCollection-'></a>
### AddQuartzServices(services) `method`

##### Summary

Регистрация сервисов в DI

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') | Коллекция дескрипторов служб |

<a name='M-WebArg-CurrencyRates-Quartz-Extensions-ServiceCollectionExtensions-AddSwaggerSetup-Microsoft-Extensions-DependencyInjection-IServiceCollection-'></a>
### AddSwaggerSetup(services) `method`

##### Summary

Регистрация Swagger

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') | Коллекция дескрипторов служб |

<a name='M-WebArg-CurrencyRates-Quartz-Extensions-ServiceCollectionExtensions-RegisterJobs-Quartz-IServiceCollectionQuartzConfigurator,Microsoft-Extensions-Configuration-IConfiguration-'></a>
### RegisterJobs(services,configuration) `method`

##### Summary

Регистрация фоновых задач

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Quartz.IServiceCollectionQuartzConfigurator](#T-Quartz-IServiceCollectionQuartzConfigurator 'Quartz.IServiceCollectionQuartzConfigurator') | Коллекция дескрипторов служб |
| configuration | [Microsoft.Extensions.Configuration.IConfiguration](#T-Microsoft-Extensions-Configuration-IConfiguration 'Microsoft.Extensions.Configuration.IConfiguration') | Набор свойств конфигурации |

<a name='M-WebArg-CurrencyRates-Quartz-Extensions-ServiceCollectionExtensions-RegisterQuartzServices-Microsoft-Extensions-DependencyInjection-IServiceCollection,Microsoft-Extensions-Configuration-IConfiguration-'></a>
### RegisterQuartzServices(services,configuration) `method`

##### Summary

Регистрация сервисов Quartz

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') | Коллекция дескрипторов служб |
| configuration | [Microsoft.Extensions.Configuration.IConfiguration](#T-Microsoft-Extensions-Configuration-IConfiguration 'Microsoft.Extensions.Configuration.IConfiguration') | Набор свойств конфигурации |
