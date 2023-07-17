using AbstractFactory;
using AbstractFactory1;

IMontadora fabrica = new FabricaHonda();
ISedan sedan = fabrica.CriarSedan();
ISuv suv = fabrica.CriarSuv();
IEsportivo esportivo = fabrica.CriarEsportivo();

Console.WriteLine("********* HONDA ********");
ExibeDetalhes(sedan, suv, esportivo);

fabrica = new FabricaHyundai();
sedan = fabrica.CriarSedan();
suv = fabrica.CriarSuv();
Console.WriteLine("******* HYUNDAI **********");
ExibeDetalhes(sedan, suv, esportivo);

fabrica = new FabricaHonda();
esportivo = fabrica.CriarEsportivo();
Console.WriteLine("*****Esportivo*****");
ExibeDetalhes(sedan,suv,esportivo);

Console.ReadKey();

static void ExibeDetalhes(ISedan sedan, ISuv suv, IEsportivo esportivo)
{
    Console.WriteLine(sedan.ExibeDetalhes());
    Console.WriteLine(suv.ExibeDetalhes());
    Console.WriteLine(suv.ExibeDetalhes());
    Console.WriteLine(esportivo.ExibeDetalhes());
}
