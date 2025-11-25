using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("How to Code in C#", "Tech Guru", 450);
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Ben", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Cynthia", "I finally understand classes!"));
        videos.Add(video1);

        // Video 2
        Video video2 = new Video("Cooking Jollof Rice", "Food Magic", 600);
        video2.AddComment(new Comment("David", "This made me hungry!"));
        video2.AddComment(new Comment("Emma", "Best recipe ever."));
        video2.AddComment(new Comment("Felix", "I tried it — amazing!"));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video("Nigeria Travel Guide", "Travel World", 720);
        video3.AddComment(new Comment("Grace", "Nigeria is beautiful!"));
        video3.AddComment(new Comment("Henry", "I love the editing."));
        video3.AddComment(new Comment("Isabella", "I want to visit!"));
        videos.Add(video3);

        // Display all videos and comments
        foreach (Video video in videos)
        {
            Console.WriteLine("====================================");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("--- Comments ---");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment.GetCommenterName()}: {comment.GetCommentText()}");
            }

            Console.WriteLine("====================================\n");
        }
    }
}
