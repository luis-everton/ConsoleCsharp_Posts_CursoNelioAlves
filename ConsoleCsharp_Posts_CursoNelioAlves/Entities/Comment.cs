namespace ConsoleCsharp_Posts_CursoNelioAlves.Entities
{
    class Comment
    {   //propriedade
        public string Text { get; set; }
        //contrutor padrão
        public Comment()
        {
        }
        //construtor com argumento/parametro
        public Comment(string text)
        {
            Text = text;
        }
    }
}