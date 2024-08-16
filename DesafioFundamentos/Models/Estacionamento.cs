using System.Collections.Immutable;
using System.Collections.Specialized;
using System.Runtime.CompilerServices;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // *IMPLEMENTE AQUI*
            // Status: Implementado 15/08/2024; 20:37 --- Funcionalidade=OK
            Console.WriteLine("Digite a placa do veículo a ser estacionado:");
            string input = Console.ReadLine();
            veiculos.Add(input);
        }

        public void RemoverVeiculo()
        {
            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTE AQUI*
            // Status: FINALIZADO 16/08/2024 01:49

            Console.WriteLine("Digite a placa do veículo para remove-lo:");  
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                // *IMPLEMENTE AQUI*
                // Status: FINALIZADO 16/08/2024 01:49

                decimal hora = Convert.ToDecimal(Console.ReadLine());

                decimal valorTotal = precoInicial + precoPorHora * hora;
              
                // TODO: Remover a placa digitada da lista de veículos
                // *IMPLEMENTE AQUI*
                // Status: FINALIZADO 16/08/2024 01:49

                veiculos.Remove(placa);
             
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Bem-Vindo ao Painel de Gestão do Estacionamento!\n"+
                $"O Atual número de veículos estacionados é {veiculos.Count}");                /*Implementação Textual Pessoal: 
                                                                                                "Os veículos estacionados são" --->*/
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // *IMPLEMENTE AQUI*
                // Status: FINALIZADO 16/08/2024 01:49
                        foreach (var veiculoestacionado in veiculos)
                        {
                            Console.WriteLine($"Veículo: {veiculoestacionado}");
                        }
            }

            else
            {
                Console.WriteLine("Desculpe, não há veículos estacionados.");
            }
        }
    }
}
