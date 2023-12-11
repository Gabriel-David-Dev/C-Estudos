using CadastroPedido.Entities.Enums;

namespace CadastroPedido.Entities
{
    internal class Pedido
    {
        public DateTime Momento { get; set; }
        public StatusPedido Status { get; set; }
        public Cliente Cliente { get; set; }
        public List<ItemPedido> Itens { get; set; } = new List<ItemPedido>();

        public Pedido(DateTime momento, StatusPedido status, Cliente cliente)
        {
            Momento = momento;
            Status = status;
            Cliente = cliente;
        }

        public void AddItem(ItemPedido item)
        {
            Itens.Add(item);
        }

        public void RemoveItem(ItemPedido item)
        {
            Itens.Remove(item);
        }

        public double Total()
        {
            double total = 0;

            foreach (ItemPedido item in Itens)
            {
                total += item.SubTotal();
            }

            return total;
        }

        public override string ToString()
        {
            return $"Momento do pedido: {Momento}" +
                   $"\nStatus do pedido: {Status}" +
                   $"\nCliente: {Cliente}";
        }
    }
}
