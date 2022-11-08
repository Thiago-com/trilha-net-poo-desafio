using DesafioPOO.Models;

Console.WriteLine("Nokia");
Smartphone nokia = new Nokia("9999999220", "N95", "133002144", 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Snakes");

Console.WriteLine("iPhone");
Smartphone iphone = new Iphone("988888888", "14", "911225036", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Face Time");