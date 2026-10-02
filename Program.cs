Menu menu = new Menu();
List<Equipe> equipes = new List<Equipe>();
List<string> historico = new List<string>();

string nomeFestival = "";
string localFestival = "";
string dataFestival = "";
string horarioFestival = "";

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

if (opcao == 2)
{
    Console.WriteLine("Equipes cadastradas:");

    foreach (Equipe equipe in equipes)
    {
        Console.WriteLine(equipe.equipe);
    }

    Console.ReadLine();
}

if (opcao == 3)
{
    Console.WriteLine("Digite o nome da primeira equipe:");
    string equipe1 = Console.ReadLine()!;

    Console.WriteLine("Digite o nome da segunda equipe:");
    string equipe2 = Console.ReadLine()!;

    Console.WriteLine("Digite o placar da primeira equipe:");
    int placar1 = int.Parse(Console.ReadLine()!);

    Console.WriteLine("Digite o placar da segunda equipe:");
    int placar2 = int.Parse(Console.ReadLine()!);
    Console.WriteLine($"{equipe1} {placar1} x {placar2} {equipe2}");

historico.Add($"{equipe1} {placar1} x {placar2} {equipe2}");
    Console.ReadLine();
}

if (opcao == 4)
{
    Console.WriteLine("Histórico de partidas:");

    foreach (string partida in historico)
    {
        Console.WriteLine(partida);
    }

    Console.ReadLine();
}

if (opcao == 5)
{
    Console.WriteLine("Digite o nome do festival:");
    nomeFestival = Console.ReadLine()!;

    Console.WriteLine("Digite o local do festival:");
    localFestival = Console.ReadLine()!;

    Console.WriteLine("Digite a data do festival:");
    dataFestival = Console.ReadLine()!;

    Console.WriteLine("Digite o horário do festival:");
    horarioFestival = Console.ReadLine()!;

    Console.WriteLine("Festival cadastrado com sucesso!");
    Console.ReadLine();
}

} while (opcao != 0);


