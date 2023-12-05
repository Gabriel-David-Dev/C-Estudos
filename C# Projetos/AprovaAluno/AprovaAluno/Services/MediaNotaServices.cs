namespace AprovaAluno.Services
{
    internal class MediaNotaServices
    {
        public static double Media(double nota1, double nota2, double nota3)
        {
            double soma = nota1 + nota2 + nota3;
            return soma / 3;
        }
    }
}
