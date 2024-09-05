using DesafioPOO.Models;



Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("930338937","Lumia 900", "3383849404", 32);

nokia.Ligar();
nokia.InstalarAplicativo("Instagram");
Console.WriteLine("--------------------------------------");

Console.WriteLine("Smartphone IPhone:");
Smartphone iphone = new Iphone("996103129","11", "35009337789", 128);

iphone.ReceberLigacao();
iphone.InstalarAplicativo("Duolingo");