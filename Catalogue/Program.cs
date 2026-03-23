// See https://aka.ms/new-console-template for more information

using System.Globalization;
using Catalogue;

// Array

string[] words = new []{"This", "Has", "Rules"};
Post[] posts = new Post[4];

// List 1

List<string> altWords = new List<string>(){"This", "Has", "Rules"};
altWords.Add("For");
altWords.Sort();
altWords.Reverse();

foreach (string altWord in altWords)
{
    Console.WriteLine(altWord);
}

string FindWord(string word)
{
    foreach (string altWord in altWords)
    {
        if (altWord == word)
        {
            return altWord;
        }
    }

    return "";
}


// List 2

List<Post> altPosts = new List<Post>()
{
    new Post() { Id = 1, Title = "Detroit" },
    new Post() { Id = 2, Title = "Falun" }
};
Post newPost = new Post();
newPost.Id = 3;
newPost.Title = "Prague";
altPosts.Add(newPost);
altPosts.Add(new Post() { Id = 4, Title = "Canberra" });

altPosts.Remove(altPosts[0]);

Post? hasId = altPosts.Find(p => p.Id == 2);

Console.WriteLine(hasId.Title);

foreach (Post post in altPosts)
{
    Console.WriteLine(post.Title);
}


