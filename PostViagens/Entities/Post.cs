using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostViagens.Entities;

namespace PostViagens.Entities
{
    class Post
    {
        
        public DateTime Momment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> comments { get; set; } = new List<Comment>();

        public Post()
        {
        }

        public Post(DateTime momment, string title, string content, int likes)
        {
            Momment = momment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComment(Comment comment)
        {
            comments.Add(comment);
        }
        public void RemoveComment(Comment comment)
        {
            comments.Remove(comment);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append("Like -");
            sb.AppendLine(Momment.ToString("dd/MM/yyy  HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments:");

            foreach (Comment c in comments)
            {
                sb.AppendLine(c.Text);
            }
            return sb.ToString();
        }
    }
}
