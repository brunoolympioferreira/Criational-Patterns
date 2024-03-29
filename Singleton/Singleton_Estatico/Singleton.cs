﻿using static System.Console;

namespace Singleton_Estatico
{
    public sealed class Singleton
    {
        private static int contador = 0;
        private static readonly Singleton instance;
        private Singleton() { }

        static Singleton()
        {
            contador++;
            WriteLine($"Instancia :  {contador}");
            instance = new Singleton();
        }

        public static Singleton Instance
        {
            get
            {
                return instance;
            }
        }   
    }
}