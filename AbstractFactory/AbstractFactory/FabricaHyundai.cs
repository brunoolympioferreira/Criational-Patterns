using AbstractFactory;

namespace AbstractFactory1
{
    class FabricaHyundai : IMontadora
    {
        public IEsportivo CriarEsportivo()
        {
            throw new NotImplementedException();
        }

        public ISedan CriarSedan()
        {
            return new HB20Hyundai();
        }

        public ISuv CriarSuv()
        {
            return new CretaHyundai();
        }
    }
}
