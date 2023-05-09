// See https://aka.ms/new-console-template for more information
Console.WriteLine($"Hello, World! The answer is {CoreLib.MyTools.Answer()} ");

var z = CoreLib.MyTools.DbWho("server=localhost;UID=sa;PWD=GramSvendsen1;TrustServerCertificate=true");

var y = z.ToArray();
Console.WriteLine(y);


