using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostViagens.Entities;

namespace PostViagens
{
    class Program
    {
        static void Main(string[] args)
        {
            // instanciar os comentarios 

            Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("Wow that Awesomw!");

            // instanciar Post
            Post p1 = new Post(
                DateTime.Parse("21/06/2018  13:05:44"),
                "Traveling to New Zealand", "Im going to visit this wonderful!", 12);

            // addicionar no post os comentarios c1 e c2
            p1.AddComment(c1);
            p1.AddComment(c2);

            // instanciar outros comentarios
            Comment c3 = new Comment("Good night");
            Comment c4 = new Comment("May the Force be with");

            // instanciar os post


            Post p2 = new Post(
                DateTime.Parse("28/07/2018  23:14:19"),
                "Good nigth guy", "see you tomorrow", 5);

            // adicionar no post os comentarios
            p2.AddComment(c3);
            p2.AddComment(c4);

            // imprimir o conteudo de cada post com os comentarios

            Console.WriteLine(p1);
            Console.WriteLine(p2);





        }
    }
}
