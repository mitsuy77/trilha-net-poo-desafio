using DesafioPOO.Models;

Nokia smartphone1 = new(numero: "123456789", modelo: "nokia1", imei: "abc1234", memoria: 1024);
Iphone smartphone2 = new(numero: "987654321", modelo: "iphone1", imei: "def5678", memoria: 1024);

Console.WriteLine("Smartphone Nokia:");
smartphone1.Ligar();
smartphone1.ReceberLigacao();
smartphone1.InstalarAplicativo(nomeApp: "Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphoe Iphone:");
smartphone1.Ligar();
smartphone2.ReceberLigacao();
smartphone2.InstalarAplicativo(nomeApp: "Signal");