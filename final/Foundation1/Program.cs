using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Creating videos
        Video video1 = new Video("Upgrade your setup for Free! 10 tips and tricks to improve your Setup!", "TechSource", 780);
        Video video2 = new Video("Setup Wars - Episode 326", "TechSource", 840);
        Video video3 = new Video("Setup Wars Episode 310 - Budget Edition", "TechSource", 501);

        // Adding comments to videos
        video1.AddComment(new Comment("Ernie Ritz", "Nice video!"));
        video1.AddComment(new Comment("Sild Gwyn", "Great content!"));
        video1.AddComment(new Comment("Sheng Weng", "Awesome!"));

        video2.AddComment(new Comment("Jim Russ", "Interesting Setup!"));
        video2.AddComment(new Comment("Shelly Pot", "I enjoyed watching this."));
        video2.AddComment(new Comment("Gly Gly", "Keep up the good work!"));

        video3.AddComment(new Comment("Wy Net", "Very informative."));
        video3.AddComment(new Comment("Fritz Delics", "Loved it!"));
        video3.AddComment(new Comment("Ja Ninsky", "Looking forward to more budget edition."));

        // Putting videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Displaying video information and comments
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
