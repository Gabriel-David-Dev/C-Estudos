using System.Text;

namespace ComentariosDePostagem.Entities
{
    internal class Post
    {

        public DateTime Momento { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public int Likes { get; set; }
        public List<Comentario> Comentarios { get; set; } = new List<Comentario>();

        public Post(DateTime momento, string titulo, string conteudo, int likes)
        {
            Momento = momento;
            Titulo = titulo;
            Conteudo = conteudo;
            Likes = likes;
        }

        public void AddComentario(Comentario comentario)
        {
            Comentarios.Add(comentario);
        }

        public void RemoveComentario(Comentario comentario)
        {
            Comentarios.Remove(comentario);
        }

        
        public override string ToString()
        {
            StringBuilder sr = new StringBuilder();
            sr.AppendLine(Titulo);
            sr.AppendLine($"{Likes} Likes - {Momento.ToString()}");
            sr.AppendLine(Conteudo);
            sr.AppendLine("Comentários:");
            foreach(Comentario comentario in Comentarios)
            {
                sr.AppendLine(comentario.ToString());
            }

            return sr.ToString();
        }

    }
}
