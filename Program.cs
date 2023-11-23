void mensagemDeBoasVindas()
{
    string mensagem = @"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░";
    Console.WriteLine(mensagem);
    Console.WriteLine($"\nBoas vindas ao Screen Sound");
};


void menuAplicacao()
{
    Console.WriteLine($"\nDigite 1 para registrar uma banda");
    Console.WriteLine($"Digite 2 para mostrar todas as bandas");
    Console.WriteLine($"Digite 3 para avaliar uma banda");
    Console.WriteLine($"Digite 4 para exibir a média de uma banda");
    Console.WriteLine($"Digite 0 para sair");

    Console.Write($"\nDigite a sua opção:");
    string opcaoEcolhida = Console.ReadLine()!;
    int opcaoEcolhidaNumerica = int.Parse(opcaoEcolhida);
    switch (opcaoEcolhidaNumerica)
    {
        case 1:
            Console.WriteLine($"Opção escolhida {1}");
            break;
        case 2:
            Console.WriteLine($"Opção escolhida {2}");
            break;
        case 3:
            Console.WriteLine($"Opção escolhida {3}");
            break;
        case 4:
            Console.WriteLine($"Opção escolhida {4}");
            break;
        case 0:
            Console.WriteLine($"Acabou!!! {0}");
            break;
        default:
            Console.WriteLine("Opção invalida!");
            break;
    };
};
mensagemDeBoasVindas();
menuAplicacao();