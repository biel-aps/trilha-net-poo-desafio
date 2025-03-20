using System.ComponentModel;
using DesafioPOO.Models;

// implementado: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Iphone 15:");
Iphone ip = new Iphone("(19)12345678","Iphone 15","12535525258282",16);
ip.Ligar();
ip.InstalarAplicativo("Facebook");
ip.ReceberLigacao();
Console.WriteLine("");

Console.WriteLine("Smartphone Nokia");
Nokia nk =new Nokia("(19)987654321","Nokia 2025","123574785784525",16);
nk.InstalarAplicativo("Mercado Livre");
nk.Ligar();
nk.ReceberLigacao();