using System.Transactions;

namespace YouTube
{
    public class Video
    {
        public string _title;
        public string _author;
        public int _length;
        public List<Comment> _comments = new List<Comment>();
        // Add a comment to the video
        public void AddComment(Comment comment)
        {
            _comments.Add(comment);
        }

        // Get the number of comments
        public int GetCommentCount()
        {
            return _comments.Count;
        }

        // Get the list of comments
        public List<Comment> GetComments()
        {
            return _comments;
        }
        public void Display()
        {
            Console.WriteLine($"{_title} {_author} {_length}");
            Console.WriteLine("Comments: ");
        }
    }
}