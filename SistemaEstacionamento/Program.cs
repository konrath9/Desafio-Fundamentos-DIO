using SistemaEstacionamento.Models;

decimal initialPrice;
decimal pricePerHour;
int action;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!");
Console.WriteLine("Digite o preço inicial:");
initialPrice = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Agora digite o preço por hora:");
pricePerHour = Convert.ToDecimal(Console.ReadLine());

Estacionamento estacionamento = new Estacionamento(initialPrice, pricePerHour);

Console.Clear();
do
{
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");
    action = Convert.ToInt32(Console.ReadLine());

    switch (action)
    {
        case 1:
            Console.WriteLine("Digite a placa dop veículo para estacionar:");
            estacionamento.AddVehicle(Console.ReadLine());
            break;
        case 2:
            Console.WriteLine("Digite a placa do veículo para remover:");
            string RemovedVehicle = Console.ReadLine();
            Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
            decimal price = estacionamento.GetPrice(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("O veículo {0} foi removido e o preço total foi de: R$ {1}", RemovedVehicle, price);
            estacionamento.RemoveVehicle(RemovedVehicle);
            break;
        case 3:
            Console.WriteLine("Os veículos estacionados são:");
            foreach (string vehicle in estacionamento.Vehicles)
            {
                Console.WriteLine(vehicle);
            }
            break;
        case 4:
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
    Console.Clear();

} while (action != 4);

Console.WriteLine("O programa se encerrou");