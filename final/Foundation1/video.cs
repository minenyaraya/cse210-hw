using System;


public class Video
{
    private string _title;
    private string _author;
    private double _length;
    private List<Comment> _comments = new List<Comment>();
    public Video(string title, string author, double length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
    public void ListComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public void DisplayVideoComment()
    {
        Console.WriteLine($"{_title} by {_author}( {_length} seconds)");
        int countComments = CountComment();
        Console.WriteLine($"Comments: " + countComments);
        foreach (Comment comment in _comments)
        {
            comment.DisplayVideoComment();
        }
    }
    public int CountComment()
    {
        int count = 0;
        count = _comments.Count;
        return count;
    }
} 