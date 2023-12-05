namespace AprovaAluno.Entidades
{
    internal class Aluno
    {
        public string Name { get; set; }
        public double PrimeiraNota { get; set; }
        public double SegundaNota { get; set; }
        public double TerceiraNota { get; set; }

        public Aluno(string name, double primeiraNota, double segundaNota, double terceiraNota)
        {
            Name = name;
            PrimeiraNota = primeiraNota;
            SegundaNota = segundaNota;
            TerceiraNota = terceiraNota;
        }      
    }
}
