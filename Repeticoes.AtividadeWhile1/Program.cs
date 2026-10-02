int contagem = 5;

while (contagem >= 1)
{
    Console.WriteLine($"Contagem regressiva: {contagem}");
    contagem -= 1;
    Thread.Sleep(1000);
    // Esse também é um jeito de fazer só que com a validação.
    // if (contagem == 0)
    // {
    //     Console.WriteLine($"Foguete lançado com sucesso!");
    // }
}
Console.WriteLine($"Foguete lançado com sucesso!");
