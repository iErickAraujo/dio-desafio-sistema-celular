using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
//Nokia
Console.WriteLine("Criando Nokia...");
Nokia meuNokia = new Nokia("99999999", "Nokia Tijolão", "111111111111111", 128);
meuNokia.Ligar();
meuNokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

//Iphone
Console.WriteLine("Criando Iphone...");
Iphone meuIphone = new Iphone("70707070", "Iphone Brastemp", "222222222222222", 256);
meuIphone.ReceberLigacao();
meuIphone.InstalarAplicativo("Instagram");
