// See https://aka.ms/new-console-template for more information

using System.Globalization;
using System.Text.Json;
using Catalogue;
using Catalogue.Data;

using (var db = new CatalogueDbContext())
{
   Post post = new Post("James Mack", "Finally", "Wiley", 1998);
   db.Posts.Add(post);
   db.SaveChanges();
}
Console.ReadLine();
