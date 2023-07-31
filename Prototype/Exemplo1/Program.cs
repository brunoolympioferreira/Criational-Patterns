using static System.Console;
//Cria objeto do tipo Soldado
using Exemplo1;

Soldado soldado = new Soldado();
soldado.Nome = "Soldado";
soldado.Arma = "Fuzil";

Soldado soldado_clone1 = (Soldado)soldado.Clone();
Soldado soldado_clone2 = (Soldado)soldado.Clone();

// atribui valores ao clone1
soldado_clone1.Nome = "Soldado Clone1";
soldado_clone1.Arma = "Bazuca";

// atribui valores ao clone2
soldado_clone2.Nome = "Soldado Clone2";
soldado_clone2.Arma = "Metralhadora";

//exibe valores do objeto original
WriteLine(">> Objeto Original");
WriteLine($"{soldado.Nome} - {soldado.Arma}");

//Valores de objeto clone1
WriteLine(">> Objeto Clone1");
WriteLine($"{soldado_clone1.Nome} -  {soldado_clone1.Arma}");

//Valores de objeto clone2
Console.WriteLine(">> Objeto Clone2");
WriteLine($"{soldado_clone2.Nome} - {soldado_clone2.Arma}");


ReadLine();
