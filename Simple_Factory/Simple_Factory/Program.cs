using Simple_Factory;

Console.WriteLine("========= Pizzaria ======\n");
Console.WriteLine("Informe a pizza (C)alabreza  (M)ussarela ");
var pizzaEscolhida = Console.ReadLine().ToUpper();
try
{
    Pizza pizza = PizzaSimpleFactory.CriaPizza(pizzaEscolhida.ToUpper());
    pizza.Preparar();
    pizza.Assar(30);
    pizza.Embalar();
    Console.WriteLine("\nPizza concluida com sucesso");
}
catch (Exception ex)
{
    Console.WriteLine("Erro :" + ex.Message);
}
Console.ReadLine();
