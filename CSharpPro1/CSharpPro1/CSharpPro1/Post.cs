using System;

namespace CSharpPro1
{

    public class Db
    {
        public static int Counter = 0;
    }

    public class Post
    {
        // Fields
        private int _votes;

        //public int Votes => _votes;
        public int Votes => _votes;


        // Properties
        public int Id { get; }
        public DateTime Created { get; }
        public string Title { get; set; }
        public string Description { get; set; }

        // Constructor
        public Post(int votes)
        {
            Db.Counter++;
            Id = Db.Counter;

            _votes = votes;
            Created = DateTime.Now;
            Title = $"{Id}-Default Title-{Created}";
        }

        // Methods
        public void UpVote() => _votes++;
        public void DownVote() => _votes--;

        public void Details() => Console.WriteLine($"id:{Id} Votes:{_votes} CreatedAt:{Created}");


    }
}