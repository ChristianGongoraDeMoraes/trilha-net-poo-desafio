using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smarthphone nokia");
Smartphone nokia = new Nokia("12345", "Modelo 1", "1111111", 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");


Console.WriteLine("\n");

Console.WriteLine("Smarthphone nokia");
Smartphone iphone = new Iphone("12345", "Modelo 1", "1111111", 64);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");