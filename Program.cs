using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Nokia");
Smartphone nokia = new Nokia("123", "x", "111", 64);
nokia.Ligar();
nokia.InstalarAplicativo("whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Iphone");
Smartphone iphone = new Iphone("321", "y", "222", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("telegram");