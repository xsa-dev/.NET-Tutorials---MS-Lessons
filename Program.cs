/**
This lessons online notepad
https://www.microsoft.com/net/tutorials/csharp/getting-started

Aleksey Savin &copy; 2017
alekseysavin.com
 */
using System;
using System.Collections;
using System.Collections.Generic;

namespace csbot
{
    class Program
    {
        #region lesson 12 classes
        public class Address
        {
            public string StreetAddress { get; set; } = string.Empty;
            public string City { get; set; } = string.Empty;
            public string State { get; set; } = string.Empty;
            public int PostalCode { get; set; } = 0;
            public string Country { get; set; } = string.Empty;


        }

        public class Person
        {
            public string FirstName { get; set; } = string.Empty;
            public string LastName { get; set; } = string.Empty;
            public Address ShippingAddress { get; set; }
        }

        public class Company
        {
            public string Name { get; set; }
            public Address ShippingAddress { get; set; }
        }

        #endregion

        static void Main(string[] args)
        {
            #region ms lesson 12 of 20 
            Console.WriteLine("Lesson 12 start here:");
            Console.WriteLine("Press any key to start...");
            Console.ReadKey();
            //Values for Personal Address
            string[] strts = { "Bla bla", "True stree", "Whats street?", "Tverskaya street", "Mangomery Bitch" };
            string[] citys = { "Moscow", "Sant Petersburg", "Keln", "New York", "Toronto", "Los Angeless", "Polo Alto" };
            string[] state = { "CA", "BA", "NA", "AA", "SA" };
            int[] postals = { 123, 234, 345, 456, 567 };
            string[] contrys = { "Russia", "Russia", "Germany", "USA", "Canada", "USA", "USA" };

            //Values for Pesons
            string[] fnames = { "Ignat", "Rahat", "Romb", "Stephan", "Narkoman" };
            string[] lnames = { "Thatov", "Rahatov", "Stomb", "Lucielly", "Buratinov" };

            Address adr1 = new Address();
            Address adr2 = new Address();
            Address adr3 = new Address();
            Address adr4 = new Address();
            Address adr5 = new Address();
            //Values for Company'es
            string[] cnames = { "xSoft", "ySoft", "zSoft", "sSoft", "rSoft" };
            Address cadr1 = new Address();
            Address cadr2 = new Address();
            Address cadr3 = new Address();
            Address cadr4 = new Address();
            Address cadr5 = new Address();
            
            //Values for Company Adress
            string[] cadrs = {"Company One", "Company Two", "Company Three", "Company Four", "Company Five"};
            string[] ccitys = {"Moscow", "Kimri", "Tver", "Belij Gorod", "Taldom"};
            string[] cstates = {"MO", "TO", "Moscow", "SAO", "ZAO"};
            int[] cpostals = {123, 234,345,456,567};
            string[] ccontrys = {"Russia", "Germany", "USA", "Italia", "Japan"};

            //Persons
            Person name1 = new Person();
            Person name2 = new Person();
            Person name3 = new Person();
            Person name4 = new Person();
            Person name5 = new Person();

            name1.FirstName = fnames[0];
            name1.LastName = lnames[0];
            name1.ShippingAddress = adr1;

            name2.FirstName = fnames[1];
            name2.LastName = lnames[1];
            name2.ShippingAddress = adr2;

            name3.FirstName = fnames[2];
            name3.LastName = lnames[2];
            name3.ShippingAddress = adr2;

            name4.FirstName = fnames[3];
            name4.LastName = lnames[3];
            name4.ShippingAddress = adr3;

            name5.FirstName = fnames[4];
            name5.LastName = lnames[4];
            name5.ShippingAddress = adr4;

            //Comps
            Company comp1 = new Company();
            Company comp2 = new Company();
            Company comp3 = new Company();
            Company comp4 = new Company();
            Company comp5 = new Company();

            comp1.Name = cnames[0];
            comp1.ShippingAddress = cadr1;
            comp2.Name = cnames[1];
            comp2.ShippingAddress = cadr2;
            comp3.Name = cnames[2];
            comp3.ShippingAddress = cadr3;
            comp4.Name = cnames[3];
            comp4.ShippingAddress = cadr4;
            comp5.Name = cnames[4];
            comp5.ShippingAddress = cadr5;

            //Personal Address
            adr1.City = citys[0];
            adr1.StreetAddress = strts[0];
            adr1.PostalCode = postals[0];
            adr1.State = state[0];
            adr1.Country = contrys[0];

            adr2.City = citys[1];
            adr2.StreetAddress = strts[1];
            adr2.PostalCode = postals[1];
            adr2.State = state[1];
            adr2.Country = contrys[1];

            adr3.City = citys[2];
            adr3.StreetAddress = strts[2];
            adr3.PostalCode = postals[2];
            adr3.State = state[2];
            adr3.Country = contrys[2];

            adr4.City = citys[3];
            adr4.StreetAddress = strts[3];
            adr4.PostalCode = postals[3];
            adr4.State = state[3];
            adr4.Country = contrys[3];

            adr5.City = citys[4];
            adr5.StreetAddress = strts[4];
            adr5.PostalCode = postals[4];
            adr5.State = state[4];
            adr5.Country = contrys[4];

            //Company Address
            cadr1.City = ccitys[0];
            cadr1.Country = ccontrys[0];
            cadr1.StreetAddress = cnames[0];
            cadr1.PostalCode = cpostals[0];
            cadr1.State = cstates[0];

            cadr2.City = ccitys[1];
            cadr2.Country = ccontrys[1];
            cadr2.StreetAddress = cnames[1];
            cadr2.PostalCode = cpostals[1];
            cadr2.State = cstates[1];

            cadr3.City = ccitys[2];
            cadr3.Country = ccontrys[2];
            cadr3.StreetAddress = cnames[2];
            cadr3.PostalCode = cpostals[2];
            cadr3.State = cstates[2];

            cadr4.City = ccitys[3];
            cadr4.Country = ccontrys[3];
            cadr4.StreetAddress = cnames[3];
            cadr4.PostalCode = cpostals[3];
            cadr4.State = cstates[3];

            cadr5.City = ccitys[4];
            cadr5.Country = ccontrys[4];
            cadr5.StreetAddress = cnames[4];
            cadr5.PostalCode = cpostals[4];
            cadr5.State = cstates[4];

            //Print Companyes
            Console.WriteLine($"{comp1.Name}: {comp1.ShippingAddress.PostalCode}, {comp1.ShippingAddress.Country}, {comp1.ShippingAddress.State}, {comp1.ShippingAddress.City}, {comp1.ShippingAddress.StreetAddress}");
            Console.WriteLine($"{comp2.Name}: {comp2.ShippingAddress.PostalCode}, {comp2.ShippingAddress.Country}, {comp2.ShippingAddress.State}, {comp2.ShippingAddress.City}, {comp2.ShippingAddress.StreetAddress}");
            Console.WriteLine($"{comp3.Name}: {comp3.ShippingAddress.PostalCode}, {comp3.ShippingAddress.Country}, {comp3.ShippingAddress.State}, {comp3.ShippingAddress.City}, {comp3.ShippingAddress.StreetAddress}");
            Console.WriteLine($"{comp4.Name}: {comp4.ShippingAddress.PostalCode}, {comp4.ShippingAddress.Country}, {comp4.ShippingAddress.State}, {comp4.ShippingAddress.City}, {comp4.ShippingAddress.StreetAddress}");
            Console.WriteLine($"{comp5.Name}: {comp5.ShippingAddress.PostalCode}, {comp5.ShippingAddress.Country}, {comp5.ShippingAddress.State}, {comp5.ShippingAddress.City}, {comp5.ShippingAddress.StreetAddress}");
            
            //Print Persons
            Console.WriteLine($"{name1.FirstName} {name1.LastName}: {name1.ShippingAddress.PostalCode}, {name1.ShippingAddress.Country}, {name1.ShippingAddress.State}, {name1.ShippingAddress.City}, {name1.ShippingAddress.StreetAddress}");
            Console.WriteLine($"{name2.FirstName} {name2.LastName}: {name2.ShippingAddress.PostalCode}, {name2.ShippingAddress.Country}, {name2.ShippingAddress.State}, {name2.ShippingAddress.City}, {name2.ShippingAddress.StreetAddress}");
            Console.WriteLine($"{name3.FirstName} {name3.LastName}: {name3.ShippingAddress.PostalCode}, {name3.ShippingAddress.Country}, {name3.ShippingAddress.State}, {name3.ShippingAddress.City}, {name3.ShippingAddress.StreetAddress}");
            Console.WriteLine($"{name4.FirstName} {name4.LastName}: {name4.ShippingAddress.PostalCode}, {name4.ShippingAddress.Country}, {name4.ShippingAddress.State}, {name4.ShippingAddress.City}, {name4.ShippingAddress.StreetAddress}");
            Console.WriteLine($"{name5.FirstName} {name5.LastName}: {name5.ShippingAddress.PostalCode}, {name5.ShippingAddress.Country}, {name5.ShippingAddress.State}, {name5.ShippingAddress.City}, {name5.ShippingAddress.StreetAddress}");

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