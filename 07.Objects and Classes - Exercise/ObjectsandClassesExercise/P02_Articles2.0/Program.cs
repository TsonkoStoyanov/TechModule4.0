using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_Articles2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Article> articles = new List<Article>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(", ");

                string title = input[0];
                string content = input[1];
                string author = input[2];

                Article article = new Article(title, content, author);

                articles.Add(article);
            }

            string howToOrder = Console.ReadLine();

            if (howToOrder == "title")
            {
                Console.WriteLine(string.Join(Environment.NewLine, articles.OrderBy(x => x.Title)));
            }
            else if (howToOrder == "content")
            {
                Console.WriteLine(string.Join(Environment.NewLine, articles.OrderBy(x => x.Content)));
            }
            else if (howToOrder == "author")
            {
                Console.WriteLine(string.Join(Environment.NewLine, articles.OrderBy(x => x.Author)));
            }
            
        }
    }

    class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }



        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
