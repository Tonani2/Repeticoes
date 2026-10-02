int dia = 1;
int total = 0;

while (dia <= 10)
{
    total = total + 5;
    Console.WriteLine($"Dia {dia}: R${total}");
    dia++;
}
Console.WriteLine($"Economia total concluída com sucesso!");