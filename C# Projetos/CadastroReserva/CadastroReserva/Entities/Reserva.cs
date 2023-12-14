using Course.Entities.Exceptions;

namespace CadastroReserva.Entities
{
    internal class Reserva
    {
        public int NumeroQuarto { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reserva(int numeroQuarto, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new DomainException("A data de Check-out deve ser posterior à data de Check-in");
            }

            NumeroQuarto = numeroQuarto;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duracao()
        {
            TimeSpan duracao = CheckOut.Subtract(CheckIn);
            
            return (int)duracao.TotalDays;
        }

        public void AtualizarReserva(DateTime checkIn, DateTime checkOut)
        {

            DateTime dataAgora = DateTime.Now;

            if (checkIn < dataAgora || checkOut < dataAgora)
            {
                throw new DomainException("As datas de reserva para atualização devem ser datas futuras");
            }
            else if (checkOut <= checkIn)
            {
                throw new DomainException("A data de Check-out deve ser posterior à data de Check-in");
            }

            CheckIn = checkIn;
            CheckOut = checkOut;

        }

        public override string ToString()
        {
            return $"Reserva: {NumeroQuarto}, " +
                $"check-in: {CheckIn.ToString("dd/MM/yyyy")}, " +
                $"check-out: {CheckOut.ToString("dd/MM/yyyy")}, " +
                $"{Duracao()} noites";
        }

    }
}
