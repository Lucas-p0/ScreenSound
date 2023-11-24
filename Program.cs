using System.Linq;

void mensagemDeBoasVindas()
{
    Console.Clear();
    string mensagem = @"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░";
    Console.WriteLine(mensagem);

};
Dictionary<string, List<int>> bandasRegistrasdas = new Dictionary<string, List<int>>();
bandasRegistrasdas.Add("Os Arrais", new List<int> { 10, 8, 7 });
bandasRegistrasdas.Add("Oficina G3", new List<int>());
//List<string> listaDasBandas = new List<string> { "Os Arrais", "Oficina G3", "Palavra antiga" };

void ExibirOpcoesDoMenu()
{
    Console.Clear();
    mensagemDeBoasVindas();
    Console.WriteLine($"\nBoas vindas ao Screen Sound");
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
            RegistrarBanda();
            break;
        case 2:
            MostarBandasRegistradas();
            break;
        case 3:
            AvaliarUmaBanda();
            break;
        case 4:
            ExibeMediaDaBanda();
            break;
        case 0:
            Console.WriteLine($"Acabou!!!");
            break;
        default:
            Console.WriteLine("Opção invalida!");
            break;
    };
};
void RegistrarBanda()
{
    Console.Clear();
    ExibindoTituloDaOpcao("Registro de bandas");
    Console.Write($"Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistrasdas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada!");
    Thread.Sleep(2000);
    ExibirOpcoesDoMenu();
};

void MostarBandasRegistradas()
{
    Console.Clear();
    ExibindoTituloDaOpcao("Exibindo bandas registradas:");
    // for (int i = 0; i < listaDasBandas.Count; i++)
    // {

    //     Console.WriteLine($"Banda: {listaDasBandas[i]}");
    // };
    foreach (string banda in bandasRegistrasdas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    };
    Console.WriteLine($"\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    mensagemDeBoasVindas();
    ExibirOpcoesDoMenu();

}
void ExibindoTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
};
void AvaliarUmaBanda()
{
    //Digite a banda que deseja avaliar
    //Se a banda exstir nodicionario >> atribuir uma nota
    //Senão, voltar ao menu principal
    Console.Clear();
    ExibindoTituloDaOpcao("Avaliar Banda");
    Console.Write("Digite o nome que deseja avaliar: ");
    String nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistrasdas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistrasdas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine($"\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    };
};
void ExibeMediaDaBanda()
{
    Console.Clear();
    Console.Write($"Digite o nome da banda para ver a média:");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistrasdas.ContainsKey(nomeDaBanda))
    {
        List<int> notasDaBanda = bandasRegistrasdas[nomeDaBanda];

        // int soma = 0;
        // int contador = 0;

        // foreach (var notas in notasDaBanda)
        // {
        //     soma += notas;
        //     contador++;
        // };
        // int media = soma / contador;
        // Console.WriteLine($"\nA soma das notas é: {soma}");
        // Console.WriteLine($"A Media da banda {nomeDaBanda} é: {media}");
        Console.WriteLine($"A Media da banda {nomeDaBanda} é: {notasDaBanda.Average()}.");
        Console.WriteLine($"Digite qualquer tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine($"\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    ;

};

mensagemDeBoasVindas();
ExibirOpcoesDoMenu();