/**
This lessons online notepad
https://www.microsoft.com/net/tutorials/csharp/getting-started

Aleksey Savin &copy; 2017
alekseysavin.com
 */
using System;
using System.Collections;
using System.Collections.Generic;
using Lesson12;

namespace csbot
{
    class Program
    {
        //lesson 12 outer method for printing client adress
        public static void prntr(Client Client) {
            Console.WriteLine();
            if (Client.LastName != null) {
                Console.WriteLine(Client.Name + " " + Client.LastName);
            }
            else {
                Console.WriteLine(Client.Name);
            }
            Console.WriteLine($"{Client.StreetAddress}");
            Console.WriteLine($"{Client.City}, {Client.State}, {Client.PostalCode}");
            Console.WriteLine($"{Client.Country}");
        }
        static void Main(string[] args)
        {
            #region ms lesson 13 of 20
            //https://www.microsoft.com/net/tutorials/csharp/getting-started/scope-accessibility


            #endregion
            #region ms lesson 12 of 20 
            //https://www.microsoft.com/net/tutorials/csharp/getting-started/classes-objects
            Console.WriteLine("Lesson 12 start here:");
            Console.WriteLine("Press any key to start...");
            Console.WriteLine("I am rewrite classes of lesson12 object out of the scope and importing them in main file.");
            Console.ReadKey();
            
            List<Client> clist = new List<Client>();

            //Clients list generator
            //Do not follow the DRY conception :(

            for (int i = 1; i <= 10; i++) {
            if (i<6) {
               Client cli = new Client( streetAddress: $"Begovaya office {i}",                                         
                                        country: "Russia",
                                        postalCode: $"12312{i}",
                                        state: "MO", 
                                        city: "Moscow",
                                        name: $"Company {i}, inc.",
                                        lastName: null    
                                        );
                                        clist.Add(cli);
            }
            else {
                               Client cli = new Client( streetAddress: $"Tverskaya {i}",                                         
                                        country: "Russia",
                                        postalCode: $"12710{i}",
                                        state: "MO", 
                                        city: "Moscow",
                                        name: $"Ivan{i}",
                                        lastName: $"Ivanov{i}"    
                                        );
                                        clist.Add(cli);
            }
            }          

            foreach (Client client in clist) {
                prntr(client);
            }
            
            Console.WriteLine();
            Console.WriteLine("This. End. Press any key.");
            Console.ReadKey();

            #endregion
            #region ms lesson 11 of 20
            Console.WriteLine("Lesson 11 start here");
            Console.WriteLine("This program use your inputs and execute some methods");
            Console.WriteLine(" xy --> hi() + bark() ");
            Console.WriteLine(" x --> hi()");
            Console.WriteLine(" q --> break");
            Console.WriteLine(" a --> math example: sum of 1 and 2, and sqrt of 2");
            Console.WriteLine("Thats all. Please press any key to start...");
            Console.ReadKey();
         
            while (true)
            {
                string inputs = Console.ReadLine();
                if (inputs == "xy")
                {
                    hi();
                    bark();
                }
                if (inputs == "x")
                {
                    hi();
                }
                if (inputs == "y")
                {
                    bark();
                }
                if (inputs == "q")
                {
                    break;
                }
                if (inputs == "a")
                {
                    Console.Write(csum(1, 2));
                    Console.Write(sqrt(2));
                }
            }

            void hi()
            {
                Console.WriteLine("Hi");
            }

            void bark()
            {
                Console.WriteLine("Gav gav gav!");
            }

            int csum(int x, int y)
            {
                return x + y;
            }

            int sqrt(int x)
            {
                return x * x;
            }

            #endregion
            #region ms lesson 10 of 20
            //https://www.microsoft.com/net/tutorials/csharp/getting-started/looping-collections
            int sum = 0;
            var test = new List<int>() { 2, 4, 6 };
            for (int i = 0; i < test.Count; i++)
            {
                sum += test[i];
            }
            Console.Write(sum);
            Console.ReadLine();
            #endregion
            #region ms lesson 9 of 20 array collections
            //https://www.microsoft.com/net/tutorials/csharp/getting-started/arrays-collections
            string oper = ":";
            string read;
            List<string> list = new List<string>();

            while (true)
            {
                Console.WriteLine($"Enter command (+ item, - item, or -- to clear, quit):");
                read = Console.ReadLine();
                string[] param = read.Split(' ');
                string cntnt = read.Substring(2);

                oper = param[0];

                if (oper == ":")
                {
                    Console.WriteLine("Nothing..");
                }
                if (oper == "+")
                {
                    list.Add(cntnt);
                }
                if (oper == "-")
                {
                    list.Remove(cntnt);
                }
                if (oper == "--")
                {
                    {
                        list.Clear();
                    }
                }
                list.ForEach(Console.WriteLine);
                if (oper == "quit")
                {
                    break;
                }
            }

            #endregion
            #region ms lesson 8 of 20 for loops
            //paused here https://www.microsoft.com/net/tutorials/csharp/getting-started/for-loops
            Console.WriteLine("For loop:");
            for (int x = 0; x < 4; x++)
            {
                for (int i = 0; i <= 24; i++)
                {
                    Console.Write($"{i}");
                    if (i > -1 && i < 24)
                    {
                        Console.Write($",");
                    }
                    i = i + x;
                }
                Console.WriteLine();
            }

            #endregion

            #region ms lesson 7 of 20
            Console.WriteLine("7 lesson");
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Factors: ");
            while (number > 1) // convert this to while
            {
                int candidateFactor = 2;
                while (candidateFactor <= number) // convert this to while
                {
                    if (number % candidateFactor == 0) // found a factor
                    {
                        Console.Write(candidateFactor);
                        // divide number by the factor you found and assign this back to number
                        number = number % candidateFactor;
                        // print a comma if number is still greater than 1
                        if (number > 1)
                        {
                            Console.Write(",");
                        }
                    }
                    // don't forget to increment factor!
                    candidateFactor++;
                }
            }
            Console.WriteLine();

            Console.WriteLine("Lesson 7 end");
            #endregion

            #region lesson 6 of 20

            DateTime nowtime = DateTime.Now;
            DateTime today = DateTime.Today;

            Console.WriteLine($"nowtime: {nowtime}");
            Console.WriteLine($"today: {today}");
            // "Good Morning"
            DateTime start_mor = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, +4, 0, 0);
            DateTime end_mor = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, +10, 0, 0);
            if (nowtime > start_mor && nowtime < end_mor)
            {
                Console.WriteLine($"Good Morning! Now Time: {nowtime} - start&end: {start_mor} {end_mor} ");
            }
            // "Good Afternoon"
            DateTime start_day = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, +10, 0, 0);
            DateTime end_day = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, +16, 0, 0);
            if (nowtime > start_day && nowtime < end_day)
            {
                Console.WriteLine($"Good Afternoon! Now Time: {nowtime}");
            }
            // "Good Evening"
            DateTime start_eve = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, +16, 0, 0);
            DateTime end_eve = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, +22, 0, 0);
            if (nowtime > start_eve && nowtime < end_eve)
            {
                Console.WriteLine($"Good Evening! Now Time: {nowtime}");
            }
            // "Good Night"
            DateTime start_nig = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, +22, 0, 0);
            DateTime end_nig = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, +4, 0, 0);
            if (nowtime > start_nig)
            {
                Console.WriteLine($"Good Night! Now Time: {nowtime}");
            }

            #endregion

            #region lesson 5 of 20
            int correctNumber = new Random().Next(3) + 1;
            Console.WriteLine("Try to guess the number, input one:");
            var input = int.Parse(Console.ReadLine());

            if (input < correctNumber)
            {
                Console.WriteLine($"Input number lower, x-number is: {correctNumber}");
            }
            else if (input == correctNumber)
            {
                Console.WriteLine($"Input number equal, x-number is {correctNumber}");
            }
            else
            {
                Console.WriteLine("$Input number grather, x-number is: {correctNumber}");
            }

            #endregion

            #region second examples
            var currentTime = DateTime.Now; // current time
            var stoday = DateTime.Today; // current date - time is midnight
            var someDate = new DateTime(2016, 7, 1); // 1 July 2016, midnight
            var someMoment = new DateTime(2016, 7, 1, 8, 0, 0); // 1 July 2016, 08:00.00
            var tomorrow = DateTime.Today.AddDays(1);
            var yesterday = DateTime.Today.AddDays(-1);
            var someDay = DateTime.Parse("7/1/2016");


            Console.WriteLine($"currentTime: {currentTime}");
            Console.WriteLine($"today: {stoday}");
            Console.WriteLine($"someDate: {someDate}");
            Console.WriteLine($"someMoment: {someMoment}");
            Console.WriteLine($"tomorrow: {tomorrow}");
            Console.WriteLine($"yesterday: {yesterday}");
            Console.WriteLine($"someDay: {someDay}");

            DateTime nextYear = new DateTime(DateTime.Today.Year + 1, 1, 1);
            TimeSpan duration = nextYear - DateTime.Today;
            Console.WriteLine($"There are {duration.TotalDays} days left in the year");

            DateTime birthdate = new DateTime(1988, 3, 29);
            TimeSpan from_bday = today - birthdate;
            Console.WriteLine($"Duration from Birthday: {from_bday.TotalDays}");
            Console.WriteLine($"daysToNextAnniversary:" + (1000 - (from_bday.TotalDays % 10000)));

            #endregion

            #region first examples
            string greeting = "Hello";
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine($"{greeting}, {name}!");
            #endregion
            //You next lessons here:
            //https://www.microsoft.com/net/tutorials/csharp/getting-started/datetimes 
        }
    }
}