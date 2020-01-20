using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCsharp_Posts_CursoNelioAlves.Entities
{
    class Post
    {   //propriedades
        public DateTime Moment { get; set; }
        public string TItle { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>;
        //construtor padrão
        public Post()
        {
        }
        //contrutor com argumento/parametros
        public Post(DateTime moment, string tItle, string content, int likes)
        {
            Moment = moment;
            TItle = tItle;
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
    }
}
