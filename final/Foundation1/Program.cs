using System;

namespace YouTube
{
    class Program
    {
        static void Main(string[] args)
        {
            Video vid1 = new Video();
            vid1._title = "What is C#?";
            vid1._author = "Cheese, Cheddar";
            vid1._length = 4;

            Comment comment1 = new Comment();
            comment1._commenterName = "Wisconsin";
            comment1._commentText = "Great on Toast!";
            Comment comment2 = new Comment();
            comment2._commenterName = "Monterey";
            comment2._commentText = "Can you melt goat and brie?";
            Comment comment3 = new Comment();
            comment3._commenterName = "Blue";
            comment3._commentText = "Where is the Brie??!!!!?";
            vid1.AddComment(comment1);
            vid1.AddComment(comment2);
            vid1.AddComment(comment3);

            Video vid2 = new Video();
            vid2._title = "Who is C#?";
            vid2._author = "Cheese, Munster";
            vid2._length = 2;

            Comment comment4 = new Comment();
            comment4._commenterName = "American";
            comment4._commentText = "Can the French eat it?";
            Comment comment5 = new Comment();
            comment5._commenterName = "Guoda";
            comment5._commentText = "Does it melt?";
            Comment comment6 = new Comment();
            comment6._commenterName = "Feta";
            comment6._commentText = "This is exactly what I needed.";
            Comment comment7 = new Comment();
            comment7._commenterName = "Kraft";
            comment7._commentText = "These recipes were very helpful.";
            Comment comment8 = new Comment();
            comment8._commenterName = "Monterey";
            comment8._commentText = "Can you do a video on Pepper Jack?";
            vid2.AddComment(comment4);
            vid2.AddComment(comment5);
            vid2.AddComment(comment6);
            vid2.AddComment(comment7);
            vid2.AddComment(comment8);

            Video vid3 = new Video();
            vid3._title = "Where is C#?";
            vid3._author = "Cheese, Swiss";
            vid3._length = 2;

            Comment comment9 = new Comment();
            comment9._commenterName = "Jack";
            comment9._commentText = "Loved the plating.";
            Comment comment10 = new Comment();
            comment10._commenterName = "Colby";
            comment10._commentText = "Would love more Provolone videos.";
            Comment comment11 = new Comment();
            comment11._commenterName = "Goat";
            comment11._commentText = "Melty and Crumbly.";
            vid3.AddComment(comment9);
            vid3.AddComment(comment10);
            vid3.AddComment(comment11);

            List<Video> videos = new List<Video> { vid1, vid2, vid3 };

            foreach (Video vid in videos)
            {
                // Video.Display();
                Console.WriteLine($"Title: {vid._title}");
                Console.WriteLine($"Author: {vid._author}");
                Console.WriteLine($"Length: {vid._length} seconds");
                Console.WriteLine($"Number of Comments: {vid.GetCommentCount()}");
                Console.WriteLine("Comments: ");


                foreach (Comment comment in vid.GetComments())
                {
                    // Comment.Display();
                    Console.WriteLine($"- {comment._commenterName}: {comment._commentText}");
                }

                Console.WriteLine();
            }
        }
    }
}