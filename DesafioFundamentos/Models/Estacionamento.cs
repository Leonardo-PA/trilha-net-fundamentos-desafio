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
            // TO-DO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // *IMPLEMENTADO*
            Console.WriteLine("Digite a placa do veículo para estacionar:");

            //Solução: separa o valor e insierindo a lista de veiculos, usando um add da minha string adicionando o num da placa e apresetando na lista de veiculos.
            string placa = Console.ReadLine();
            veiculos.Add(placa);
            Console.WriteLine($"Veiculo {placa} adicionado com sucesso!");
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTADO*

            //solução: inserindo ao removedor uma string que referencia a placa que o user irá inserir no sistema 
            string placa = Console.ReadLine();
            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // TO-DO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TO-DO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                // *IMPLEMENTADO*

                //Solução: alterado codigo para ele puxar a quantidade de horas inicial mais a quantidade de horas, fazendo assim a media e apresentando o resultado do valor a ser cobrado. 
                int horas = int.Parse(Console.ReadLine());
                decimal valorTotal = precoInicial + precoPorHora * horas; 

                // TO-DO: Remover a placa digitada da lista de veículos
                // *IMPLEMENTADO*

                //Solução: Implementando o removedor da placa;
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
                Console.WriteLine("Os veículos estacionados são:");
                // TO-DO: Realizar um laço de repetição, exibindo os veículos estacionados
                // *IMPLEMENTADO*
                //Solução: implemtando comando do foreach para buscar na lista os veiculos registrados 
                foreach(var veiculo  in veiculos)
                {
                    Console.WriteLine($" - [{veiculo}]");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
