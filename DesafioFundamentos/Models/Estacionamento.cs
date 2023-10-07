

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoDeEntrada, decimal precoDaHora)
        {
            this.precoInicial = precoDeEntrada;
            this.precoPorHora = precoDaHora;
        }

        public void AdicionarVeiculo()
        {
            
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            veiculos.Add(Console.ReadLine());
            
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
           
            string placa;
            placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                
                Console.Write("Digite a quantidade de horas que o veículo permaneceu estacionado: ");
                decimal horas = 0;
                horas = Convert.ToDecimal(Console.ReadLine());
                decimal valorTotal = 0;
                valorTotal = precoInicial + precoPorHora * horas;
        
              
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
               
                foreach(string veiculo in veiculos) {
                Console.WriteLine(veiculo);

                }     
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}