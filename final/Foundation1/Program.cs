using System;


class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Video 1", "Author 1", 120);
        video1.AddComment("User1", "Great video!");
        video1.AddComment("User2", "I learned a lot from this.");
        videos.Add(video1);

        Video video2 = new Video("Video 2", "Author 2", 180);
        video2.AddComment("User3", "Nice content!");
        video2.AddComment("User4", "Could you make a tutorial on this topic?");
        video2.AddComment("User5", "I enjoyed watching it.");
        videos.Add(video2);

        Video video3 = new Video("Video 3", "Author 3", 150);
        video3.AddComment("User6", "This is amazing!");
        video3.AddComment("User7", "I have a question about this part.");
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video.Title);
            Console.WriteLine("Author: " + video.Author);
            Console.WriteLine("Length: " + video.Length);
            Console.WriteLine("Number of comments: " + video.GetNumComments());
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine("  Name: " + comment.Name);
                Console.WriteLine("  Text: " + comment.Text);
            }
            Console.WriteLine();
        }
    }
}