using System;
using System.Net.Sockets;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("174 North", "Provo", "Utah 86046", "USA");

        Lecture lecture = new Lecture("Literary", "Everything talks about Him", "06/29/2024", "11 AM", address, "Provo Library", 50);
        Console.WriteLine("=========");

        Console.WriteLine("Lecture");
        Console.WriteLine("=========");
     
        Console.WriteLine(lecture.GenerateStandard());
        Console.WriteLine("======================");
        Console.WriteLine(lecture.GenerateDetailedLecture());

        Console.WriteLine("======================");
        Console.WriteLine(lecture.GenerateShortLecture());
        Console.WriteLine("===========");
        Address addressReception = new Address("777 East 15th St", "Edmond", "Ok 73013", "USA");

        Reception reception = new Reception("A good Day", "C. Lois S.", "07/13/2024", "5 PM", addressReception, "plottr@hmail.com");

        Console.WriteLine("Reception");
        Console.WriteLine("===========");
        Console.WriteLine(reception.GenerateStandard());

        Console.WriteLine("======================");
        Console.WriteLine(reception.GenerateDetailedReception());
        Console.WriteLine("======================");
        
        Console.WriteLine(reception.GenerateShortReception());
        
        Address addressOut = new Address("6401 N Broadway", "Edmond", "Ok 73034", "Usa");
        Console.WriteLine("==============");
        Outdoor outdoor = new Outdoor("Chicken day", "The little ones", "08/23/2024", "9 PM", addressOut, "Sunny");
        
        Console.WriteLine("Outdoor");
        Console.WriteLine("==============");

        Console.WriteLine(outdoor.GenerateStandard());

        Console.WriteLine("======================");
        Console.WriteLine(outdoor.GenerateDetailedOutdoor());

        Console.WriteLine("======================");
        Console.WriteLine(outdoor.GenerateShortOutdoor());
    
 
    }
}