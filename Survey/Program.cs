using System;
using System.ComponentModel.DataAnnotations;

namespace Survey
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = TryAnswer();

            Console.WriteLine("What is your age?");
            var age = TryAnswer();

            Console.WriteLine("What month were you born in? Please enter the number.");
            var month = monthCheck();

            Console.WriteLine("What day were you born on?", month);
            var dayOfMonth = dayCheck();

            string starSign = null;

            //switch case to apply day of month to zodiac sign
            //also applied name of month to each statement for clearer print statement
            switch (month)
            {
                case "1":
                    if (int.Parse(dayOfMonth) < 20)
                    {
                        starSign = "Capricorn";
                    }
                    else starSign = "Aquarius";
                    month = "January";
                    break;

                case "2":
                    if (int.Parse(dayOfMonth) > 18)
                    {
                        starSign = "Pisces";
                    }
                    else starSign = "Aquarius";
                    month = "February";
                    break;

                case "3":
                    if (int.Parse(dayOfMonth) < 21)
                    {
                        starSign = "Pisces";
                    }
                    else starSign = "Aries";
                    month = "March";
                    break;

                case "4":
                    if (int.Parse(dayOfMonth) < 20)
                    {
                        starSign = "Aries";
                    }
                    else starSign = "Taurus";
                    month = "April";
                    break;

                case "5":
                    if (int.Parse(dayOfMonth) < 21)
                    {
                        starSign = "Taurus";
                    }
                    else starSign = "Gemini";
                    month = "May";
                    break;

                case "6":
                    if (int.Parse(dayOfMonth) < 21)
                    {
                        starSign = "Gemini";
                    }
                    else starSign = "Cancer";
                    month = "June";
                    break;

                case "7":
                    if (int.Parse(dayOfMonth) < 23)
                    {
                        starSign = "Cancer";
                    }
                    else starSign = "Leo";
                    month = "July";
                    break;

                case "8":
                    if (int.Parse(dayOfMonth) < 23)
                    {
                        starSign = "Leo";
                    }
                    else starSign = "Virgo";
                    month = "August";
                    break;

                case "9":
                    if (int.Parse(dayOfMonth) < 23)
                    {
                        starSign = "Virgo";
                    }
                    else starSign = "Libra";
                    month = "September";
                    break;

                case "10":
                    if (int.Parse(dayOfMonth) < 23)
                    {
                        starSign = "Libra";
                    }
                    else starSign = "Scorpio";
                    month = "October";
                    break;

                case "11":
                    if (int.Parse(dayOfMonth) < 22)
                    {
                        starSign = "Scorpio";
                    }
                    else starSign = "Sagittarius";
                    month = "November";
                    break;

                case "12":
                    if (int.Parse(dayOfMonth) < 22)
                    {
                        starSign = "Sagittarius";
                    }
                    else starSign = "Capricorn";
                    month = "December";
                    break;
            }


            Console.WriteLine("Your name is: {0}", name);
            Console.WriteLine("Your age is: {0}", age);
            Console.WriteLine("Your birth month is: {0}", month);
            Console.WriteLine("Your zodiac sign is: {0}", starSign);

        }

        static string TryAnswer()
        {
            var question = Console.ReadLine();
            if (question == "")
            {
                Console.WriteLine("Invalid input, please try again:");
                return Console.ReadLine();
            }
            return question;
        }

        //validation for days of the month, must be between 1-31
        static string dayCheck()
        {
            var dateInput = Console.ReadLine();
            var intDateInput = int.Parse(dateInput);
            if (intDateInput > 31 || intDateInput < 1)
            {
                Console.WriteLine("Invalid input, please try again:");
                return Console.ReadLine();
            }
            return dateInput;
        }

        //validation for month input, must be between 1-12
        static string monthCheck()
        {
            var monthInput = Console.ReadLine();
            var intMonthInput = int.Parse(monthInput);
            if (intMonthInput > 12 || intMonthInput < 1)
            {
                Console.WriteLine("Invalid input, please try again:");
                return Console.ReadLine();
            }
            return monthInput;
        }
    }
}
