using Singleton_Sealed;
using static System.Console;

Parallel.Invoke(
    () => AcessoThread1(),
    () => AcessoThread2()
);
ReadLine();

static void AcessoThread1()
{
    Singleton s1 = Singleton.Instance;
    WriteLine("Thread 1 ");
}
static void AcessoThread2()
{
    //Singleton s2 = Singleton.Instance;
    ////WriteLine("Thread 2 ");
    //Singleton.SingletonDerivada derivada =
    //    new Singleton.SingletonDerivada();
}
