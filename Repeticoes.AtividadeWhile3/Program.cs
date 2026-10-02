// Console.WriteLine("Digite sua senha");
// var senhaDigitada = Console.ReadLine();
// while (senhaDigitada != "JovemProgramadora")
// {
//      Console.Write("Senha incorreta! Tente novamente:");
//      senhaDigitada = Console.ReadLine();
// }
// Console.WriteLine(" Acesso liberado! Bem-vinda ao sistema!");

Console.WriteLine("Digite sua senha");
var senhaDigitada = Console.ReadLine();
var senhaCorreta = "luiza";
while (senhaDigitada != senhaCorreta)
{
    Console.WriteLine("Senha incorreta! Tente novamente"); 
    senhaDigitada = Console.ReadLine();
}
Console.WriteLine("Acesso liberado! Bem-vinda ao sistema");
