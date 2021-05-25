using System;

namespace StackOverflow_Post
{

    // This is a VERY simple program to simply demonstrate my understanding of classes
    class Program
    {
        static void Main(string[] args)
        {
            var post = new Post 
                        { Title = "Intermediate C# is awesome!",
                          Description = "I learned a lot in this class. Does anyone else agree?"};
            for (int i = 0; i < 5; i++)
            {
                post.Upvote();
            }
            for (int j = 0; j < 2; j++)
            {
                post.Downvote();
            }
            Console.WriteLine(post.Title);
            Console.WriteLine(post.Description);
            Console.WriteLine("Post was posted at {0}", post.GetPostTime());
            Console.WriteLine("Aggregate vote count: {0}", post.GetVoteValue());
            Console.ReadLine();
        }
    }

}
