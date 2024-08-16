using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
                  "Por favor, digite o preço inicial:");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora digite o preço por hora:");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar Veículo");
    Console.WriteLine("2 - Retirar Veículo"); /*Implementação Textual Pessoal: "Remover Veículo" ---> "Retirar Veículo"*/
    Console.WriteLine("3 - Verificar Lista de Veículos"); /*Implementação Textual Pessoal: "Listar Veículos" ---> "Verificar Lista de Veículos"*/
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;

        case "2":
            es.RemoverVeiculo();
            break;

        case "3":
            es.ListarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Desculpe, comando desconhecido/inválido"); /*Implementação Textual Pessoal: "Opção inválida" ---> "Desculpe, comando desconhecido/inválido"*/
            break;
    }

    Console.WriteLine("Pressione qualquer tecla para prosseguir..."); /*Implementação Textual Pessoal: "Pressione uma tecla para continuar" --->"Pressione qualquer tecla para prosseguir..." */
    Console.ReadLine();
}

Console.WriteLine("Fechando Sistema...  Obrigado por utilizar o MoveInt System V1"); /*Implementação Textual Pessoal: "O programa se encerrou"--->"Fechando Sistema
                                              Obrigado por utilizar o MoveInt System V1"*/