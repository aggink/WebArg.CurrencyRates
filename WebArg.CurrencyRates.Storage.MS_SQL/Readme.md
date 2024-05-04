<a name='assembly'></a>
# WebArg.CurrencyRates.Storage.MS_SQL

## Contents

- [InitDatabase](#T-WebArg-CurrencyRates-Storage-MS_SQL-Migrations-InitDatabase 'WebArg.CurrencyRates.Storage.MS_SQL.Migrations.InitDatabase')
  - [BuildTargetModel()](#M-WebArg-CurrencyRates-Storage-MS_SQL-Migrations-InitDatabase-BuildTargetModel-Microsoft-EntityFrameworkCore-ModelBuilder- 'WebArg.CurrencyRates.Storage.MS_SQL.Migrations.InitDatabase.BuildTargetModel(Microsoft.EntityFrameworkCore.ModelBuilder)')
  - [Down()](#M-WebArg-CurrencyRates-Storage-MS_SQL-Migrations-InitDatabase-Down-Microsoft-EntityFrameworkCore-Migrations-MigrationBuilder- 'WebArg.CurrencyRates.Storage.MS_SQL.Migrations.InitDatabase.Down(Microsoft.EntityFrameworkCore.Migrations.MigrationBuilder)')
  - [Up()](#M-WebArg-CurrencyRates-Storage-MS_SQL-Migrations-InitDatabase-Up-Microsoft-EntityFrameworkCore-Migrations-MigrationBuilder- 'WebArg.CurrencyRates.Storage.MS_SQL.Migrations.InitDatabase.Up(Microsoft.EntityFrameworkCore.Migrations.MigrationBuilder)')
- [InitQuartz](#T-WebArg-CurrencyRates-Storage-MS_SQL-Migrations-InitQuartz 'WebArg.CurrencyRates.Storage.MS_SQL.Migrations.InitQuartz')
  - [BuildTargetModel()](#M-WebArg-CurrencyRates-Storage-MS_SQL-Migrations-InitQuartz-BuildTargetModel-Microsoft-EntityFrameworkCore-ModelBuilder- 'WebArg.CurrencyRates.Storage.MS_SQL.Migrations.InitQuartz.BuildTargetModel(Microsoft.EntityFrameworkCore.ModelBuilder)')
  - [Down()](#M-WebArg-CurrencyRates-Storage-MS_SQL-Migrations-InitQuartz-Down-Microsoft-EntityFrameworkCore-Migrations-MigrationBuilder- 'WebArg.CurrencyRates.Storage.MS_SQL.Migrations.InitQuartz.Down(Microsoft.EntityFrameworkCore.Migrations.MigrationBuilder)')
  - [Up()](#M-WebArg-CurrencyRates-Storage-MS_SQL-Migrations-InitQuartz-Up-Microsoft-EntityFrameworkCore-Migrations-MigrationBuilder- 'WebArg.CurrencyRates.Storage.MS_SQL.Migrations.InitQuartz.Up(Microsoft.EntityFrameworkCore.Migrations.MigrationBuilder)')
- [MigrationService](#T-WebArg-CurrencyRates-Storage-MS_SQL-Services-MigrationService 'WebArg.CurrencyRates.Storage.MS_SQL.Services.MigrationService')
  - [ApplyMigrations()](#M-WebArg-CurrencyRates-Storage-MS_SQL-Services-MigrationService-ApplyMigrations 'WebArg.CurrencyRates.Storage.MS_SQL.Services.MigrationService.ApplyMigrations')
- [SqlServerContextFactory](#T-WebArg-CurrencyRates-Storage-MS_SQL-SqlServerContextFactory 'WebArg.CurrencyRates.Storage.MS_SQL.SqlServerContextFactory')

<a name='T-WebArg-CurrencyRates-Storage-MS_SQL-Migrations-InitDatabase'></a>
## InitDatabase `type`

##### Namespace

WebArg.CurrencyRates.Storage.MS_SQL.Migrations

##### Summary

*Inherit from parent.*

<a name='M-WebArg-CurrencyRates-Storage-MS_SQL-Migrations-InitDatabase-BuildTargetModel-Microsoft-EntityFrameworkCore-ModelBuilder-'></a>
### BuildTargetModel() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-WebArg-CurrencyRates-Storage-MS_SQL-Migrations-InitDatabase-Down-Microsoft-EntityFrameworkCore-Migrations-MigrationBuilder-'></a>
### Down() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-WebArg-CurrencyRates-Storage-MS_SQL-Migrations-InitDatabase-Up-Microsoft-EntityFrameworkCore-Migrations-MigrationBuilder-'></a>
### Up() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-WebArg-CurrencyRates-Storage-MS_SQL-Migrations-InitQuartz'></a>
## InitQuartz `type`

##### Namespace

WebArg.CurrencyRates.Storage.MS_SQL.Migrations

##### Summary

*Inherit from parent.*

<a name='M-WebArg-CurrencyRates-Storage-MS_SQL-Migrations-InitQuartz-BuildTargetModel-Microsoft-EntityFrameworkCore-ModelBuilder-'></a>
### BuildTargetModel() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-WebArg-CurrencyRates-Storage-MS_SQL-Migrations-InitQuartz-Down-Microsoft-EntityFrameworkCore-Migrations-MigrationBuilder-'></a>
### Down() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-WebArg-CurrencyRates-Storage-MS_SQL-Migrations-InitQuartz-Up-Microsoft-EntityFrameworkCore-Migrations-MigrationBuilder-'></a>
### Up() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-WebArg-CurrencyRates-Storage-MS_SQL-Services-MigrationService'></a>
## MigrationService `type`

##### Namespace

WebArg.CurrencyRates.Storage.MS_SQL.Services

##### Summary

Взаимодействие с базой данных

<a name='M-WebArg-CurrencyRates-Storage-MS_SQL-Services-MigrationService-ApplyMigrations'></a>
### ApplyMigrations() `method`

##### Summary

Применение миграций

##### Returns

True - миграции применены успешно

##### Parameters

This method has no parameters.

<a name='T-WebArg-CurrencyRates-Storage-MS_SQL-SqlServerContextFactory'></a>
## SqlServerContextFactory `type`

##### Namespace

WebArg.CurrencyRates.Storage.MS_SQL

##### Summary

Фабрика для создания производных [DataContext](#T-WebArg-CurrencyRates-Storage-Database-DataContext 'WebArg.CurrencyRates.Storage.Database.DataContext') экземпляров
