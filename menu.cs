using System;


// Classe responsável pelo menu principal do jogo.
// Controla as opções escolhidas pelo jogador.
public class Menu
{

    // Método responsável por exibir o menu e controlar a navegação.
    public void Exibir()
    {
        // Guarda a opção escolhida pelo jogador.
        int opcao;


        // Repete o menu até o jogador escolher a opção 0 (sair).
        do
        {
            // Limpa a tela antes de mostrar o menu novamente.
            Console.Clear();


            // Cria o cabeçalho do menu.
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("╔════════════════════════════════════╗");


            // Nome do jogo.
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("║             LIGA DA TURMA          ║");


            // Linha separadora do menu.
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("╠════════════════════════════════════╣");


            // Opções principais do jogo.
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("║ 1 - Cadastrar equipes              ║");
            Console.WriteLine("║ 2 - Consultar equipes              ║");
            Console.WriteLine("║ 3 - Registrar partida              ║");
            Console.WriteLine("║ 4 - Consultar histórico            ║");
            Console.WriteLine("║ 5 - Cadastrar festival             ║");
            Console.WriteLine("║ 6 - Gerar convite                  ║");
            Console.WriteLine("║ 7 - Gerar cartão de resultado      ║");


            // Opção sair em vermelho para destacar.
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("║ 0 - Sair                           ║");


            // Fecha o quadro do menu.
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("╚════════════════════════════════════╝");


            // Retorna a cor padrão do console.
            Console.ResetColor();


            // Solicita a escolha do jogador.
            Console.Write("\nEscolha: ");


            // Lê a opção digitada pelo usuário.
            string? entrada = Console.ReadLine();



            // Verifica se a entrada realmente é um número.
            // Caso não seja, mostra mensagem de erro.
            if (!int.TryParse(entrada, out opcao))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nOpção inválida!");

                Console.ResetColor();

                Console.WriteLine("Pressione ENTER para continuar...");
                Console.ReadLine();

                // Volta para o começo do menu.
                continue;
            }



            // Analisa qual opção foi escolhida.
            switch (opcao)
            {

                // Inicia uma nova partida.
                case 1:

                    // Cria uma nova partida do jogo.
                    Jogo jogo = new Jogo();

                    // Inicia o jogo.
                    jogo.Iniciar();

                    break;



                // Mostra as instruções do jogo.
                case 2:

                    MostrarInstrucoes();

                    break;



                // Mostra o último resultado salvo.
                case 3:

                    MostrarResultado();

                    break;

                // Mostra os créditos do jogo.
                case 4:

                    MostrarCreditos();

                    break;


                // Encerra o programa.
                case 0:

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Saindo...");

                    Console.ResetColor();

                    break;



                // Caso seja digitada uma opção que não existe.
                default:

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nOpção inválida!");

                    Console.ResetColor();

                    Console.WriteLine("Pressione ENTER para continuar...");
                    Console.ReadKey(true);

                    break;
            }


        }
        // Enquanto a opção escolhida for diferente de 0,
        // o menu continua aparecendo.
        while (opcao != 0);
    }

}