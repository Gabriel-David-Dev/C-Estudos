using ComentariosDePostagem.Entities;

namespace ComentariosDePostagem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Entrada de alguns dados para simular uma postagem
            for(int cont = 1; cont <= 2; cont++)
            {
                Console.WriteLine($"Postagem #{cont}");
                DateTime momento = DateTime.Now;
                Console.Write("Titulo: ");
                string titulo = Console.ReadLine();
                Console.Write("Conteúdo: ");
                string conteudo = Console.ReadLine();
                Random randNum = new Random();
                int likes = randNum.Next(100);

                // Post criado com as informações fornecidas
                Post post = new Post(momento, titulo, conteudo, likes);

                // Recebe e armazena os comentários em uma lista
                List<Comentario> comentarios = new List<Comentario>();

                Console.WriteLine();
                Console.WriteLine("Campo de comentários:");
                for (int contador = 0; contador < 2; contador++)
                {
                    Console.Write("Digite seu comentário: ");
                    string texto = Console.ReadLine();

                    comentarios.Add(new Comentario(texto));

                    post.AddComentario(comentarios[contador]);
                }

                // Exibe as informações do post e os comentários
                Console.WriteLine();
                Console.WriteLine($"Informações Post #{cont}");
                Console.WriteLine(post);
                Console.WriteLine();
            }  

        }
    }
}
