using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone // TESTE REALIZADOS ABAIXO

Console.WriteLine("Smartphone Nokia:");
Smartphone Nokia = new Nokia(numero: "(84) 2474-8047", modelo: "modelo 1", imei: "12334312", memoria: 32);
Nokia.Ligar();
Nokia.ReceberLigacao();
Nokia.InstalarAplicativo("Youtube");

Console.WriteLine("----------------------------");

Console.WriteLine("Smartphone Iphone:");
Smartphone Iphone = new Iphone(numero: "(34) 3676-4787", modelo: "modelo 2", imei: "12343225", memoria: 258);
Iphone.Ligar();
Iphone.ReceberLigacao();
Iphone.InstalarAplicativo("Instagram");