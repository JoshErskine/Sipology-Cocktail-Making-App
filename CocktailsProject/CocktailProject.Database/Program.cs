using CocktailProject.Database;
using FluentMigrator.Runner;
using Microsoft.Extensions.DependencyInjection;

public class Program
{
    static void Main(string[] args)
    {
        var serviceProvider = CreateServices(args[0]);

        using (var scope = serviceProvider.CreateScope())
        {
            UpdateDatabase(scope.ServiceProvider);
        }
    }

    private static IServiceProvider CreateServices(string connectionString)
    {
        return new ServiceCollection()
            .AddFluentMigratorCore()
            .ConfigureRunner(x => x
                .AddSqlServer()
                .WithGlobalCommandTimeout(TimeSpan.FromMinutes(10))
                .WithGlobalConnectionString(connectionString)
                .ScanIn(typeof(CocktailMigrationAttribute).Assembly).For.Migrations())
            .AddLogging(x => x.AddFluentMigratorConsole())
            .BuildServiceProvider(false);
    }

    private static void UpdateDatabase(IServiceProvider serviceProvider)
    {
        var runner = serviceProvider.GetRequiredService<IMigrationRunner>();

        runner.MigrateUp();
    }
}