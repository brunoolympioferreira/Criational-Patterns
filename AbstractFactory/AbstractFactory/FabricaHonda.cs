using AbstractFactory;

namespace AbstractFactory1
{
    class FabricaHonda : IMontadora
    {
        public IEsportivo CriarEsportivo()
        {
            return new CarroEsportivoHonda();
        }

        public ISedan CriarSedan()
        {
            return new HondaCivic();
        }

        public ISuv CriarSuv()
        {
            return new HondaCRV();
        }
    }
}
