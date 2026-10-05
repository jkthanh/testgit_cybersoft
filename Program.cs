using System.Text.Json;

Console.WriteLine("hello git");

Console.WriteLine("abc");


DevB devb = new DevB();
Console.WriteLine($@"{JsonSerializer.Serialize(devb)}");