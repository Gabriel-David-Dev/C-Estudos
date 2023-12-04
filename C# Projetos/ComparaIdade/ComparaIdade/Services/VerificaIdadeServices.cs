using ComparaIdade.Entities;

namespace ComparaIdade.Services
{
    internal class VerificaIdadeServices
    {
        public static string MaisVelha(Pessoa pessoa1, Pessoa pessoa2)
        {
            if (pessoa1.Idade > pessoa2.Idade)
            {
                return pessoa1.Nome;
            }
            else if (pessoa2.Idade > pessoa1.Idade)
            {
                return pessoa2.Nome;
            }
            else
            {
                return "Possuem a mesma idade!";
            }
        }
    }
}
