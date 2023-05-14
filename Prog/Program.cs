using Microsoft.Extensions.Configuration;






var builder = new ConfigurationBuilder()
    .AddEnvironmentVariables();

var configuration = builder.Build();


Console.WriteLine(configuration["dbconn"]);







Console.WriteLine($"Hello, World! The answer is {CoreLib.MyTools.Answer()} ");

var z = CoreLib.MyTools.DbWho("server=localhost;UID=sa;PWD=yourStrong(!)Password;TrustServerCertificate=true");

var y = z.ToArray();
Console.WriteLine(y);


