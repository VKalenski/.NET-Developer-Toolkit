using Microsoft.Extensions.Configuration;

IConfigurationBuilder builder = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddUserSecrets(typeof(Program).Assembly, optional: true)
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
    

IConfigurationRoot config = builder.Build();

Console.WriteLine("I think the password is... " + config["Password"]);
