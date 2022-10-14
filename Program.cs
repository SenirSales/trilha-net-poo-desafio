using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");

Smartphone nokia = new Nokia(numero: "(99)95454-4545", modelo: "Smartphone Nokia C20", imei: "121212121212121", memoria: 64);
nokia.Ligar();

nokia.InstalarAplicativo("Calculadora");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");

Smartphone iphone = new Iphone(numero: "(99)95454-6464", modelo: "Apple iPhone 13 Pro Max", imei: "313131313131313", memoria: 256);
iphone.ReceberLigacao();

iphone.InstalarAplicativo("JogoDaForca");
