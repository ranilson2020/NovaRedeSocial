using System;
using NovaRedeSocial.Entities;

namespace NovaRedeSocial
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip!");  //Tenha uma boa viagem!
            Comment c2 = new Comment("Wow that's awesome!"); //Uau isso é incrível!
            //instanciando o post
            Post p1 = new Post(
                DateTime.Parse("20/04/2020 15:52:55"),
                "Traveling to New Zealand",  //Viajar para a Nova Zelândia
                "I'm going to visit this wonderful country!",12);  //Eu vou visitar este país maravilhoso!

            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Good night");  //Boa Noite!
            Comment c4 = new Comment("May the Force be with you"); //Que a força esteja com você
            //instanciando o post
            Post p2 = new Post(
                DateTime.Parse("21/04/2020 12:52:55"),
                "Good nigth guys",  //Boa noite galera
                "See you tomorrow", 22);  //Te vejo amanhã

            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);

            Console.ReadLine();
        }

    }
}
