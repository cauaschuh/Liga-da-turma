Menu menu = new Menu();
List<Equipe> equipes = new List<Equipe>();

int opcao;
do
{
    opcao = menu.Exibir();

if (opcao == 0)
{
    return;
}

if (opcao == 1)
{

    Console.WriteLine("Digite o nome da equipe:");
    string nomeEquipe = Console.ReadLine()!;

    Equipe novaEquipe = new Equipe();
    novaEquipe.equipe = nomeEquipe;

    equipes.Add(novaEquipe);

    Console.WriteLine("Equipe cadastrada com sucesso!");
    Console.ReadLine();
}

} while (opcao != 0);


