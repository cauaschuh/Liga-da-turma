Menu menu = new Menu();
int opcao = menu.Exibir();

if (opcao == 0)
{
    return;
}

Console.WriteLine("Digite o número de equipes: ");

string resposta = "s";

while (resposta == "s")
{
    Console.WriteLine("Registrar equipe? (s/n)");
    resposta = Console.ReadLine()!;

    if (resposta == "s")
    {
        Console.WriteLine("Digite o nome da equipe:");
        string nomeEquipe = Console.ReadLine()!;

        Equipe novaEquipe = new Equipe();
        novaEquipe.equipe = nomeEquipe;

        equipes.Add(novaEquipe);
    }
}
