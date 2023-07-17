using AbstractFactory;

namespace AbstractFactory1
{
    class Cliente
    {
        ISuv suv;
        ISedan sedan;
        IEsportivo esportivo;

        public Cliente(IMontadora factory)
        {
            suv = factory.CriarSuv();
            sedan = factory.CriarSedan();
            esportivo = factory.CriarEsportivo();

        }

        public string GetSuvDetalhes()
        {
            return suv.ExibeDetalhes();
        }

        public string GetSedanDetalhes()
        {
            return sedan.ExibeDetalhes();
        }

        public string GetEsportivoDetalhes()
        {
            return esportivo.ExibeDetalhes();
        }
    }
}
