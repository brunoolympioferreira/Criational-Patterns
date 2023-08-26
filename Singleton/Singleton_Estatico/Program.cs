
using Singleton_Estatico;

Parallel.Invoke(
    () => AcessoThread1(),
    () => AcessoThread2(),
    () => AcessoThread3()
);
Console.ReadLine();

static void AcessoThread1()
{
    Singleton s1 = Singleton.Instance;
    Console.WriteLine("Thread 1 ");
}
static void AcessoThread2()
{
    Singleton s2 = Singleton.Instance;
    Console.WriteLine("Thread 2 ");
}
static void AcessoThread3()
{
    Singleton s3 = Singleton.Instance;
    Console.WriteLine("Thread 3 ");
}
