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
            Console.Write("Digite a placa do veículo para estacionar:");
            string placaVeiculo = Console.ReadLine();
            veiculos.Add(placaVeiculo);

        }

        public void RemoverVeiculo()
        {
            // Implementado!
            if (veiculos.Count == 0){
                Console.WriteLine("Não a carros para remover, Porfavor insira!");
            } else {

            Console.WriteLine("Digite a placa do veículo para remover:");
            string removeCar = Console.ReadLine();
            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == removeCar.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                // Implementado!
                int hora = int.Parse(Console.ReadLine());
                int horas = hora;
                decimal valorTotal =  (horas * precoPorHora) + precoInicial; 

                // TODO: Remover a placa digitada da lista de veículos
                // *IMPLEMENTE AQUI*
                Console.WriteLine($"O veículo {removeCar} foi removido e o preço total foi de {valorTotal.ToString("C")}");
                veiculos.Remove(removeCar);
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                //Implementado!
                foreach (string car in veiculos){
                    Console.WriteLine($"Os veículos estacionados são:\n{car.ToUpper()}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
