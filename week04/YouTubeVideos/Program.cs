using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to hold the videos
        List<Video> videos = new List<Video>();

        Video video1 = new Video("The Power of Habit", "Charles Duhigg", 600);
        video1.AddComment(new Comment("Great insights on habit formation!", "Alice"));
        video1.AddComment(new Comment("I love how this book changed my perspective.", "Bob"));

        videos.Add(video1);

        Video video2 = new Video("Learning C#", "Levi Malesh", 900);
        video2.AddComment(new Comment("Wow nice work", "John"));
        video2.AddComment(new Comment("Thank you so much, this content has helped me so much", "Jenny"));

        videos.Add(video2);

        Video video3 = new Video("14th September", "Praise Nahabwe",1000);
        video3.AddComment(new Comment("Beautiful!", "Oliver"));
        video3.AddComment(new Comment("Loml!", "Levi"));

        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");

            
         
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment.GetNameOfCommenter()}: {comment.GetText()}");
            }
            Console.WriteLine();

        }

        
        
            
        
        
            
        
    }
}