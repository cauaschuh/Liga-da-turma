List<Equipe> equipes = new List<Equipe>();

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
