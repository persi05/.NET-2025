using MyLibrary;
using Newtonsoft.Json;
using Microsoft.Extensions.DependencyInjection;
using MyServices;
using static MyServices.Class1;

// Konfiguracja kontenera DI
var serviceProvider = new ServiceCollection()
    .AddSingleton<ILoggerService, ConsoleLogger>()
    .BuildServiceProvider();

// Uzyskanie instancji loggera
var logger = serviceProvider.GetService<ILoggerService>();
logger.Log("Aplikacja uruchomiona.");

Calculator calculator = new Calculator();

int result1 = calculator.Add(6, 9);
Console.WriteLine("Add result: " + result1);

result1 = calculator.Subtract(21, 37);
Console.WriteLine("Subtract result: " + result1);

int sum = calculator.Add(5, 3);
var result = new { Operation = "Add", A = 5, B = 3, Result = sum };
string jsonResult = JsonConvert.SerializeObject(result, Formatting.Indented);
Console.WriteLine(jsonResult);

// Przykładowe użycie kalkulatora
logger.Log($"Wynik dodawania: {sum}");