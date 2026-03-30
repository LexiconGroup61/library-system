// See https://aka.ms/new-console-template for more information

using System.Globalization;
using Catalogue;
using BenchmarkDotNet.Running;
 
// BenchmarkRunner.Run<AlternativeDemo>();

// Console.ReadLine();

Post postFull = new Post();
IPost postLimited = new Post();
IPost altDemoLimited = new AlternativeDemo();

postLimited.Id = 22;
altDemoLimited.Id = 28;

// postFull.ReturnNumber();
// postLimited.ReturnNumber();

List<IPost> iPosts = new List<IPost>();
iPosts.Add(postLimited);
iPosts.Add(altDemoLimited);

foreach (var iPost in iPosts)
{
    Console.WriteLine(iPost.Id);
}

Console.ReadLine();


RegexDemo.DemoPart();

Console.ReadLine();


Console.WriteLine(PerformanceDemo.DemoArrayPerformance());
Console.WriteLine(PerformanceDemo.DemoListPerformance());

Console.ReadLine();


Dictionary<DateOnly, string> backup = new Dictionary<DateOnly, string>()
{
    { new DateOnly(2026, 3, 26), "Thursday" },
    { new DateOnly(2026, 3, 25), "Wednesday" }
};

foreach (var item in backup)
{
    Console.WriteLine(item.Key + ": " + item.Value);
}

Console.ReadLine();


Catalogue.Catalogue catalogue = new();

string resultA = catalogue.AddNumbers(73, 75);
Console.WriteLine(resultA);

string resultB = catalogue.AddNumbers(73, 75);
Console.WriteLine(resultB);

Console.ReadLine();

bool addWorked = catalogue.AddToPosts("Friday", 27);
addWorked = catalogue.AddToPosts("Friday", 85);

Console.WriteLine(addWorked);

Console.ReadLine();


Post tryPost = new Post();

try
{
    Console.WriteLine(tryPost.ReturnNumber());
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


Console.ReadLine();


int tryNumber;
try
{
    Console.WriteLine(int.MaxValue);
    string tryEntry = Console.ReadLine();
    tryNumber = int.Parse(tryEntry);
}
catch (FormatException format)
{
    Console.WriteLine(format.Message);
}
catch (OverflowException overflow)
{
    Console.WriteLine(overflow.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message + " (General message)");
}



string entry = Console.ReadLine();

bool parseTrialWorked = int.TryParse(entry, out int userNumber);

if (parseTrialWorked)
{
    Console.WriteLine(userNumber + 10);
}
else
{
    Console.WriteLine("Number could not be converted");
}

Console.ReadLine();

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


