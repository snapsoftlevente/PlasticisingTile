# Plasticising Tile API

This project implements an ASP.NET core REST API for Plasticising Tile within a Dashboard environment.

## Configuration

Configuration can be done via

-   environment variables in `{repository_root}\src\docker-compose.yml` or
-   settings in `{repository_root}\src\PlasticisingTile.API\appsettings.json` or
-   settings in `{repository_root}\src\PlasticisingTile.API\Properties\launchSettings.json`

Environment variables overwrite the json settings.

## Data

Databases are not part of the repository and therefore must be added into the `data` folder before starting the solution. Two databases must be added:

-   configuration database
-   historical database

Modify the configuration for paths if necessary. (e.g.: database is named differently)

### Migrations

After adding the databases, migrations must be applied to the configuration database. Make sure [EF Core tools](https://learn.microsoft.com/en-us/ef/core/cli/dotnet) are installed.
Run the following command from the folder `src\PlasticisingTile.Infrastructure`

```powershell
dotnet ef database update --startup-project="../PlasticisingTile.API/PlasticisingTile.API.csproj"
```

## Run

### Docker

Run the following command within folder `{repository_root}\src`.

```powershell
docker-compose up
```

This will start the web service on: <http://localhost:8080>

Swagger UI is available at: <http://localhost:8080/swagger/index.html>

### Visual Studio

It is also possible to run the project by Visual Studio.
Select the docker compose project as startup project and start it.
Swagger UI is opened automatically.

## Repository variables

| Variable Name                         | Description                              |
| ------------------------------------- | ---------------------------------------- |
| `CONNECTIONSTRINGS_CONFIGURATIONDATA` | The path for the configuration database. |
