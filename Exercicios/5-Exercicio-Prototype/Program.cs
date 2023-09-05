//criando os lanches
using Exercicio5_Resolucao;

Lanche mistoQuente = new Lanche("Pão de Forma", "Presunto e Queijo", "Tomate e cebola");
Lanche cachorroQuente = new Lanche("Pao Francês", "Duas Salsichas", "Mostarda, Molho de Tomate");

//clonando os lanches
Lanche mistoQuenteClone = mistoQuente.Clone() as Lanche;
Lanche cachorroQuenteClone = cachorroQuente.Clone() as Lanche;

Console.ReadLine();
