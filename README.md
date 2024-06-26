# Курс Чешской кроны
Чешский национальный банк предоставляет возможность отслеживать валютный курс чешской кроны.

Ежедневный курс доступен по адресу:<br />
https://www.cnb.cz/en/financial_markets/foreign_exchange_market/exchange_rate_fixing/daily.txt?date=27.07.2019

Исторические данные доступны по адресу:<br />
https://www.cnb.cz/en/financial_markets/foreign_exchange_market/exchange_rate_fixing/year.txt?year=2019

### Задание

Необходимо разработать программное решение, обладающее следующей функциональностью:
1. Синхронизация данных по чешской кроне за текущую дату в БД по расписанию. Должна быть возможность сконфигурировать время/интервал запуска. Например: запускать синхронизацию каждый день в 0:01. Период запуска должен задаваться конфигурации приложения.
2. Синхронизация данных по чешской кроне за период времени. На вход подается startDate и endDate, приложение синхронизирует в БД данные за этот период. Валюты, по которым синхронизируются данные, должны быть в конфигурации приложения.
3. Предоставляет WEB-API, с помощью которого можно получить отчет по курсу кроны за период времени. В отчете необходимо вывести минимальное, максимальное и среднее значение каждой из выбранных валют отдельно. Валюты, по которым строится отчёт, передаются в запросе. Показатели в отчёте необходимо рассчитывать для валюты в количестве 1 условная единица, т.е. для Amount = 1. Формат отчета – JSON.
4. Необходимо учесть, что в данных, предоставляемых API, могут быть аномалии. Например, для некоторых временных интервалов может не быть курсов определенных валют и т.п.

### Используемые библиотеки:
- AutoMapper
- FluentValidation.AspNetCore
- MediatR
- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.EntityFrameworkCore.Tools
- Microsoft.Extensions.Configuration.Abstractions
- Microsoft.Extensions.Logging
- Quartz.AspNetCore
- Quartz.Serialization.Json
- Refit.HttpClientFactory
- Serilog.AspNetCore
- Swashbuckle.AspNetCore
- Swashbuckle.AspNetCore.Annotations
