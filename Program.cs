using DesafioPOO.Models;
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "970002000", modelo: "Nokia 1100", imei: "1233333333", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatssap");


Console.WriteLine("\n");

Console.WriteLine("Smartphone iphone:");
Smartphone iphone = new Iphone (numero:"980003000", modelo:"Iphone 15", imei:"12344444444", memoria:128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");









