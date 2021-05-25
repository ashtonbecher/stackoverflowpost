using System;
using System.Collections.Generic;
using System.Text;

namespace StackOverflow_Post
{
    public class Post
    {
        public string Title;
        public string Description;
        private readonly DateTime _postTime;
        private int _upvotes { get; set; }
        private int _downvotes { get; set; }

        public Post()
        {
            this._postTime = DateTime.Now;
        }

        public void Upvote()
        {
            _upvotes += 1;
        }

        public void Downvote()
        {
            _downvotes += 1;
        }

        public int GetVoteValue()
        {
            return _upvotes - _downvotes;
        }

        public DateTime GetPostTime()
        {
            return _postTime;
        }
    }
}
