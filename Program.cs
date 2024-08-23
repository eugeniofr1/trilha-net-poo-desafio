using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "1111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("-------------------------");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero:"456789", modelo: "Modelo 2", imei:"2222222222", memoria:32);
iphone.Ligar();
iphone.InstalarAplicativo("Facebook");