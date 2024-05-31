using System;

class Program
{
    static void Main(string[] args)
    {
         List<Video> videosList = new List<Video>();

        // Video 1
        Video video1 = new Video("Hatillo's House", "Alexis Araya", 480);

        Comment video1Comment1 = new Comment("- Milexis", "Thanks for share this beautiful video.");
        Comment video1Comment2 = new Comment("- Neny", "I really liked the tour you took. Very professional.");
        Comment video1Comment3 = new Comment("- Dondo", "I would love to visit those houses.");

        video1.ListComment(video1Comment1);
        video1.ListComment(video1Comment2);
        video1.ListComment(video1Comment3);

        videosList.Add(video1);

        // Video 2
        Video video2 = new Video("Family games", "A.K. Sutter", 580);

        Comment video2Comment1 = new Comment("- Gordo", "Wow! You made me laugh a lot.");
        Comment video2Comment2 = new Comment("- Charlotte", "Your videos always are son funny!.");
        Comment video2Comment3 = new Comment("- Raquel", "I'm proud of you big Brother!.");

        video2.ListComment(video2Comment1);
        video2.ListComment(video2Comment2);
        video2.ListComment(video2Comment3);

        videosList.Add(video2);

        // Video 3
        Video video3 = new Video("Plottr Writer", "Cameron Sutter", 780);

        Comment video3Comment1 = new Comment("- Anne", " This is an excellent explanation of the Plottr application.");
        Comment video3Comment2 = new Comment("- Sophie", "I definitely need to try this app.");
        Comment video3Comment3 = new Comment("- Bito", "Your videos are perfectly clear to understand.");

        video3.ListComment(video3Comment1);
        video3.ListComment(video3Comment2);
        video3.ListComment(video3Comment3);

        videosList.Add(video3);

        foreach (Video video in videosList)
        {
            Console.WriteLine();
            video.DisplayVideoComment();
           
        }
    }
}