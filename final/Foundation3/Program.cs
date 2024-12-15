using System;

class Program
{
    static void Main(string[] args)
    {
        Event lecture = new Lecture("Quantum Physics 101",
        "A surface level introduction into Quantom Physics",
        "Jan-07-2025",
        "2:00 PM",
        "398 Abberand St, San Diego CA",
        "Neil DeGrasse Tyson",
        1000,
        "Lecture");
        Event reception = new Reception("Isaac & Emily's Reception",
        "A gathering for friends and family of the newly weds", 
        "Jan-04-2025",
        "5:00 PM",
        "990 LeGrand Dr, Bountiful UT",
        "isaacsudweeks@gmail.com",
        "Reception");
        Event outdoor = new OutdoorGathering("Party @ Porter Park",
        "Spikeball and ultimate frisbee at Porter Park",
        "Apr-14-2025",
        "3:00 PM",
        "884 S 2nd W, Rexburg ID",
        "Slightly Cloudly",
        "Outdoor Gathering");

        lecture.DisplayShort();
        lecture.DisplayStandard();
        lecture.DisplayFull();

        reception.DisplayShort();
        reception.DisplayStandard();
        reception.DisplayFull();

        outdoor.DisplayShort();
        outdoor.DisplayStandard();
        outdoor.DisplayFull();

    }
}