using Exercicio3_Resolucao;
using static System.Console;

IMontadora instancia = null;
WriteLine("Selecione a Montadora (para sair digite S)");
WriteLine("(C)hevrolet (F)ord (H)onda ");
var opcao = ReadLine().ToUpper();

if (opcao.Equals("S"))
    return;

instancia = MontadoraSimpleFactory.CriaMontadora(opcao);

WriteLine($"\n{instancia.Modelo()} - {instancia.Cor}\n");
