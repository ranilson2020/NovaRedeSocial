using System;
using System.Collections.Generic;
using System.Text;

namespace NovaRedeSocial.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }  //Data e a Hora Ex: 20/04/2020 21:43:22
        public string Title { get; set; } //Título
        public string Content { get; set; } //conteudo
        public int Likes { get; set; } //Quantidades de likes

        //Obs: Como teremos muitos comentários, teremos que criar uma lista com o nome comments

        public List<Comment> Comments { get; set; } = new List<Comment>(); //Associação ao objeto Comment

        public Post()  //Construtor padrão
        {
        }
                       //Contrutor com atributos
        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }
        //Criando os métodos
        public void AddComment(Comment comment)
        {
            Comments.Add(comment); //Adcionando na Lista
        }
        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment); //Removendo da Lista
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments: ");
            foreach (Comment c in Comments)
            {
                sb.AppendLine(c.Text);
            }
            return sb.ToString();


        }


    }
}
