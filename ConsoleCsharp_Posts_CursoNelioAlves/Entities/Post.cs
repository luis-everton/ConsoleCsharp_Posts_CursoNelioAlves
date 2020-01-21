using System;
using System.Collections.Generic;
using System.Text;  //necessário para StringBuilder

namespace ConsoleCsharp_Posts_CursoNelioAlves.Entities
{
    class Post
    {   //propriedades
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        //construtor padrão
        public Post()
        {
        }

        //contrutor com argumento/parametros
        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        //métodos de adição de comentários
        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }

        //método de remoção de comentários
        public void Remove(Comment comment)
        {
            Comments.Remove(comment);
        }

        //sobrecarga da ToString()
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments");
            foreach (Comment c in Comments)
            {
                sb.AppendLine(c.Text);
            }
            return sb.ToString();
        }
    }
}