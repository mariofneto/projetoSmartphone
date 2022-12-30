using projetoSmartphone.Models;

var nokia = new Nokia("255666", "Nokia", "8888888888", 64);
var iphone = new Iphone("555222", "Iphone", "7777777", 256);

Console.WriteLine("-------Nokia--------");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");
Console.WriteLine("----------------\n");
Console.WriteLine("-------Iphone--------");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Spotify");

