namespace YouTube
{
    public class Comment
    {
        public string _commenterName;
        public string _commentText;
        public void Display()
        {
            Console.WriteLine($"Name: {_commenterName}, Comment: {_commentText}");
        }
    }
}