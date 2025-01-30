using EFTask1.Entities;
using EFTask1.Model;

namespace EFTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NewsDBContext Db = new NewsDBContext();

            var catalogs = new List<Catalog>
            {
                new Catalog { Name = "Technology", Description = "News related to technology and innovation" },
                new Catalog { Name = "Sports", Description = "News related to sports events and updates" },
                new Catalog { Name = "Health", Description = "News related to health and wellness" },
                new Catalog { Name = "Politics", Description = "News related to political events and policies" }
            };

            var authors = new List<Author>
            {
                new Author { Name = "John Doe", UserName = "johndoe", Password = "password123", Bref = "Technology enthusiast" },
                new Author { Name = "Jane Smith", UserName = "janesmith", Password = "password456", Bref = "Sports analyst" },
                new Author { Name = "Alice Johnson", UserName = "alicej", Password = "password789", Bref = "Health expert" },
                new Author { Name = "Bob Brown", UserName = "bobbrown", Password = "password101", Bref = "Political commentator" }
            };

            var news = new List<News>
            {
                new News { Title = "New Smartphone Released", bref = "Latest smartphone with advanced features", Description = "A new smartphone with cutting-edge technology has been released.", Author = authors[0], Catalog = catalogs[0] },
                new News { Title = "World Cup 2023 Highlights", bref = "Summary of the latest World Cup matches", Description = "Exciting highlights from the World Cup 2023 matches.", Author = authors[1], Catalog = catalogs[1] },
                new News { Title = "Benefits of Regular Exercise", bref = "Why you should exercise regularly", Description = "Regular exercise has numerous health benefits, including improved mental health.", Author = authors[2], Catalog = catalogs[2] },
                new News { Title = "Election Results Announced", bref = "Outcome of the recent national elections", Description = "The results of the national elections have been announced, with a new party taking the lead.", Author = authors[3], Catalog = catalogs[3] }
            };

            Db.Catalogs.AddRange(catalogs);
            Db.Authors.AddRange(authors);
            Db.News.AddRange(news);
            Db.SaveChanges();




            var newsList = Db.News.ToList();
            foreach (var item in newsList)
            {
                Console.Write($"News Title : {item.Title} ");
                Console.Write($"||  Author :{item.Author.Name}");
                Console.WriteLine();
            }
        }
    }
}
