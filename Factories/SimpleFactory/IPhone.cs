using System;

namespace SimpleFactory
{
    class IPhone : ICelular
    {
        public void Especificacao()
        {
            Console.WriteLine("Celular IPhone");
        }
    }
}
