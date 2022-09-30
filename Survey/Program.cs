using System;
using System.ComponentModel.DataAnnotations;

namespace Survey
{

    enum Month
    {
        January = 1,
        February = 2,
        March = 3,
        April = 4,
        May = 5,
        June = 6,
        July = 7,
        August = 8,
        September = 9,
        October = 10,
        November = 11,
        December = 12
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = TryAnswer();

            Console.WriteLine("What is your age?");
            var age = TryAnswer();

            Console.WriteLine("What month were you born in? Please enter the number.");
            var birthMonth = monthCheck();

            Console.WriteLine("What day were you born on?", birthMonth);
            var dayOfMonth = dayCheck();

            string starSign = null;

            //switch case to apply day of month to zodiac sign
            //also applied name of month to each statement for clearer print statement
            switch (int.Parse(birthMonth))
            {
                case (int)Month.January:
                    if (int.Parse(dayOfMonth) < 20)
                    {
                        starSign = "Capricorn";
                    }
                    else starSign = "Aquarius";
                    birthMonth = "January";
                    break;

                case (int)Month.February:
                    if (int.Parse(dayOfMonth) > 18)
                    {
                        starSign = "Pisces";
                    }
                    else starSign = "Aquarius";
                    birthMonth = "February";
                    break;

                case (int)Month.March:
                    if (int.Parse(dayOfMonth) < 21)
                    {
                        starSign = "Pisces";
                    }
                    else starSign = "Aries";
                    birthMonth = "March";
                    break;

                case (int)Month.April:
                    if (int.Parse(dayOfMonth) < 20)
                    {
                        starSign = "Aries";
                    }
                    else starSign = "Taurus";
                    birthMonth = "April";
                    break;

                case (int)Month.May:
                    if (int.Parse(dayOfMonth) < 21)
                    {
                        starSign = "Taurus";
                    }
                    else starSign = "Gemini";
                    birthMonth = "May";
                    break;

                case (int)Month.June:
                    if (int.Parse(dayOfMonth) < 21)
                    {
                        starSign = "Gemini";
                    }
                    else starSign = "Cancer";
                    birthMonth = "June";
                    break;

                case (int)Month.July:
                    if (int.Parse(dayOfMonth) < 23)
                    {
                        starSign = "Cancer";
                    }
                    else starSign = "Leo";
                    birthMonth = "July";
                    break;

                case (int)Month.August:
                    if (int.Parse(dayOfMonth) < 23)
                    {
                        starSign = "Leo";
                    }
                    else starSign = "Virgo";
                    birthMonth = "August";
                    break;

                case (int)Month.September:
                    if (int.Parse(dayOfMonth) < 23)
                    {
                        starSign = "Virgo";
                    }
                    else starSign = "Libra";
                    birthMonth = "September";
                    break;

                case (int)Month.October:
                    if (int.Parse(dayOfMonth) < 23)
                    {
                        starSign = "Libra";
                    }
                    else starSign = "Scorpio";
                    birthMonth = "October";
                    break;

                case (int)Month.November:
                    if (int.Parse(dayOfMonth) < 22)
                    {
                        starSign = "Scorpio";
                    }
                    else starSign = "Sagittarius";
                    birthMonth = "November";
                    break;

                case (int)Month.December:
                    if (int.Parse(dayOfMonth) < 22)
                    {
                        starSign = "Sagittarius";
                    }
                    else starSign = "Capricorn";
                    birthMonth = "December";
                    break;
            }


            Console.WriteLine("Your name is: {0}", name);
            Console.WriteLine("Your age is: {0}", age);
            Console.WriteLine("Your birth month is: {0}", birthMonth);
            Console.WriteLine("Your zodiac sign is: {0}", starSign);

        }

        static string TryAnswer()
        {
            var question = Console.ReadLine();
            while (question == "")
            {
                Console.WriteLine("Invalid input, please try again:");
                return TryAnswer();
            }
            return question;
        }

        //validation for days of the month, must be between 1-31
        static string dayCheck()
        {
            var dateInput = Console.ReadLine();
            var intDateInput = int.Parse(dateInput);
            while (intDateInput > 31 || intDateInput < 1)
            {
                Console.WriteLine("Invalid input, please try again:");
                return dayCheck();
            }
            return dateInput;
        }

        //validation for month input, must be between 1-12
        static string monthCheck()
        {
            var monthInput = Console.ReadLine();
            var intMonthInput = int.Parse(monthInput);
            while (intMonthInput > 12 || intMonthInput < 1)
            {
                Console.WriteLine("Invalid input, please try again:");
                return monthCheck();
            }
            return monthInput;
        }
    }
}
