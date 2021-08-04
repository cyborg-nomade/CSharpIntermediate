using System;

namespace CSharpIntermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            var newPost = new Post();
            Post.UpVote(newPost);
            Post.UpVote(newPost);
            Post.UpVote(newPost);
            Post.DownVote(newPost);

            Console.WriteLine("This post's vote count is: " + newPost.ShowVotes());
        }
    }
}
