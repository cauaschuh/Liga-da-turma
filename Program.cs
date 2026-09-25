Console.WriteLine("Digite o número de equipes: ");

int numEquipes = int.Parse(Console.ReadLine()!);

<<<<<<< HEAD
Equipe[] equipes = new Equipe[numEquipes];

for (int i = 0; i < numEquipes; i++)
{
    bool repetido;

    do
    {
        repetido = false;

        Console.WriteLine($"Digite o nome da equipe {i + 1}: ");
        string nomeNovo = Console.ReadLine()!;

        for (int j = 0; j < i; j++)
        {
            if (nomeNovo == equipes[j].equipe)
            {
                repetido = true;
                Console.WriteLine("Essa equipe já foi cadastrada!");
                break;
            }
        }

        if (!repetido)
        {
            equipes[i] = new Equipe();
            equipes[i].equipe = nomeNovo;
        }

    } while (repetido);
}
=======
equipe[string]  = new equipe [4];
>>>>>>> 635eff705547c8626a0e97b774503b7d2e91e68c
