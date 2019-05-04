using System;

namespace Ansien.Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Media media = new Media();
            media["Name"] = "Ansien";
            media.Id = 0;

            Console.WriteLine(media.Id);
            Console.WriteLine(media["Name"]);
            Console.WriteLine(media.Setting("Name"));

            string targetString = "2";
            int? number = targetString.ParseInt();

            if (number != null)
                Console.WriteLine(number);
            else
                Console.WriteLine("Failed to parse a number");

            Console.ReadKey();
        }
    }
}
