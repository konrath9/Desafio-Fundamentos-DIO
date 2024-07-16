namespace SistemaEstacionamento.Models
{
    public class Estacionamento
    {
        public decimal InitialPrice { get; set; }
        public decimal PricePerHour { get; set; }
        public List<string> Vehicles { get; set; } = new List<string>();

        public Estacionamento()
        {
        }

        public Estacionamento(decimal initialPrice, decimal pricePerHour)
        {
            InitialPrice = initialPrice;
            PricePerHour = pricePerHour;
        }

        public void AddVehicle(string vehicle)
        {
            Vehicles.Add(vehicle);
        }

        public void RemoveVehicle(string vehicle)
        {
            Vehicles.Remove(vehicle);
        }

        public decimal GetPrice(int hours)
        {
            return InitialPrice + (PricePerHour * hours);
        }
    }
}
