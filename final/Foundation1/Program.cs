using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Title 1", "Author 1", 120);
        Video video2 = new Video("Title 2", "Author 2", 180);

        video1.AddComment(new Comment("User1", "Nice video!"));
        video1.AddComment(new Comment("User2", "Great content!"));
        video2.AddComment(new Comment("User3", "Interesting topic!"));
        video2.AddComment(new Comment("User4", "I enjoyed watching this."));

        List<Video> videos = new List<Video> { video1, video2 };

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length (seconds): {video.GetLengthInSeconds()}");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"Comment by {comment.GetCommenterName()}: {comment.GetCommentText()}");
            }

            Console.WriteLine();
        }
    }
}
