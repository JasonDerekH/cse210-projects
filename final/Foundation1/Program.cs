using System;

class Program
{
    static void Main(string[] args)
    {
        //Abstraction Youtube Video Program
        List<Comment> commentList1 =
        [
            new Comment("farquad40","This was inspiring"),
            new Comment("icecreamlover12","I couldn't disagree more"),
            new Comment("reallifebeyblade","I just work here"),
        ];
        Video video1 = new Video("How to do a backflip","John Backflip",184,commentList1);

        List<Comment> commentList2 = 
        [
            new Comment("scrumdiggity","This is my favorite video"),
            new Comment("SupaHotFire","Nice Try Diddy"),
            new Comment("SoggyMango", "I feel like I've seen this before"),
        ];
        Video video2 = new Video("How to beat Donkey Kong Country 2","DiddyKong",1163,commentList2);

        List<Comment> commentList3 = 
        [
            new Comment("Speedwagon","I can hold my breathe underwater for more than 5 minutes"),
            new Comment("SquirtleMan","That's easy I can hold mine for 10 minutes"),
            new Comment("Charizard420","I probably couldn't do either of those"),
        ];
        Video video3 = new Video("How to hold your breath underwater longer","Aquaman",584,commentList3);

        List<Video> videos = [
            video1,video2,video3
        ];

        foreach(Video video in videos)
        {
            Console.WriteLine($"\n{video}");
        }
        
        
    }
}