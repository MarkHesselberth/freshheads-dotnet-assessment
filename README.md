# .NET Assessment

This solution is set up as a starting template for the .NET back-end assessment. It initially contains two projects; feel free to add or remove projects whenever necessary.

## API

The API project (`PotterPedia.Application`) is the default start-up project. This is the default ASP.NET Web API template with two small additions:

-   The `DbContext` from the 'Data' project is registered for dependency injection.
-   A Swagger doc is automatically generated on start-up. This page can be used to test the API without a website front-end or an external test application. It will be available at https://localhost:5001/

## Data

The template solution contains a data project that is set up for use with Entity Framework Core. For simplicity's sake, this project contains a `DbContext` set up for use with the (empty) SQLite file `potterpedia.db`. You are not required to use this set-up.

The folder `SeedData` contains an SQL file with statements that insert data into (as of yet non-existent) tables. Use these to figure out a data format to use in your database structure, or adjust them to suit your database structure.

Creating database migrations through EF should be possible by running the relevant `dotnet ef ...` commands in the `PotterPedia.Data` folder.
