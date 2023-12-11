namespace ComentariosDePostagem.Entities
{
    internal class Comentario
    {
        public string Texto { get; set; }

        public Comentario(string texto)
        {
            Texto = texto;
        }

        public override string ToString()
        {
            return Texto;
        }
    }
}
