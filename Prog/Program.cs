using Microsoft.Extensions.Configuration;






var builder = new ConfigurationBuilder()
    .AddEnvironmentVariables();

var configuration = builder.Build();


string? s = configuration["dbconn"];







Console.WriteLine($"Hello, World! The answer is {CoreLib.MyTools.Answer()} ");

var z = CoreLib.MyTools.DbWho(s);

var y = z.ToArray();
Console.WriteLine(y);


