using System;

namespace StackOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Post p1 = new Post("Post1", "MY First Post", DateTime.Now);
            Post p2 = new Post("Post2", "My Second Post", DateTime.Now);
            for (int i = 0; i < 10; i++) {
                p1.UpVote();
            }
            p1.Display();
            p2.UpVote();
            p2.Display();
        }
    }
}
