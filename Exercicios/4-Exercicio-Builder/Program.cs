using Exercicio4_Resolucao;

CriadorLanche builder;

// Inicia a criação 
Cozinha cozinha = new Cozinha();

// Cria e exibe os lanches
builder = new LancheNatural();
cozinha.MontaLanche(builder);
builder.Lanche.Exibir();

builder = new LancheNormal();
cozinha.MontaLanche(builder);
builder.Lanche.Exibir();

Console.ReadLine();
