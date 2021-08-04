using System;

namespace CSharpIntermediate
{
    public class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreationDateTime { get; set; }
        private int _votes;

        public static void UpVote(Post post)
        {
            post._votes++;
        }

        public static void DownVote(Post post)
        {
            post._votes--;
        }

        public int ShowVotes()
        {
            return this._votes;
        }

    }
}