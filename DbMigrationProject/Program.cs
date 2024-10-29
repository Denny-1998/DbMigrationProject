using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;

string json;
DatabaseCredentials credentials;

try
{
    json = File.ReadAllText("db_credentials.json");
    credentials = JsonConvert.DeserializeObject<DatabaseCredentials>(json);

} 
catch (Exception ex)
{
    throw new Exception("db_credentials.json file not found.\n\n\n\n"+ex);
}



var host = Host.CreateDefaultBuilder()
    .ConfigureServices((context, services) =>
    {
        var connectionString = $"Server=localhost;Database=DbMigrationProject01;User Id={credentials.Username};Password={credentials.Password};TrustServerCertificate=True;";

        services.AddDbContext<ProjectDbContext>(options =>
            options.UseSqlServer(connectionString));
    })
    .Build();

Console.WriteLine("Dependency injection configured.");

host.Run();
