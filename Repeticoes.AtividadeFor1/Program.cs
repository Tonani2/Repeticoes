Console.WriteLine("Digite o número inteiro");
int numero = int.Parse(Console.ReadLine());
Console.WriteLine("---TABUADA---");
for (int tabuada = 1; tabuada <= 10; tabuada++)
{
    Console.WriteLine($"{tabuada} X {numero}: {tabuada * numero}");
    Thread.Sleep(1000);
}