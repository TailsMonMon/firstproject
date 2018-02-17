using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome");
            SayHello();
            Console.WriteLine("");
            Console.WriteLine("");

            for (int i = 0; i < args.Length; i++)   // 0 is represented by i. 'i++' is equal to 'i = i + 1'.
            {                                                            // You can also write 'i = i + 2' etc.
                Console.WriteLine("Arg {0} : {1}", i, args[i]);
            }
            Console.WriteLine("");

            string[] myArgs = Environment.GetCommandLineArgs();     // To get a list of args AND what file it's from. 
            Console.WriteLine(string.Join(", ", myArgs));
            Console.WriteLine("");


            bool canIVote = true;   // Can only store if something is true or false. 
            Console.WriteLine("You can vote.");
            Console.WriteLine("");


                // 32-bit interger (heltal)
            Console.WriteLine("Biggest Integer : {0}", int.MaxValue);
            Console.WriteLine("Smallest Integer : {0}", int.MinValue);
            Console.WriteLine("");


                // 32-bit with decimals
            float fltPiVal = 3.141592F;     // The 'F' at the end is to make sure it's not treated as a double. 
            float fltBigNum = 3.000002F;
            Console.WriteLine("DBL : PI + bigNum = {0}", fltPiVal + fltBigNum);

            Console.WriteLine("Biggest Double : {0}", float.MaxValue.ToString("#"));
            Console.WriteLine("Smallest Double : {0}", float.MinValue.ToString("#"));
            Console.WriteLine("");


                // 64-bit interger
            Console.WriteLine("Biggest Long : {0}", long.MaxValue);
            Console.WriteLine("Smallest Long : {0}", long.MinValue);
            Console.WriteLine("");


                // 64-bit with decimals
            double dblPiVal = 3.14159265358979;
            double dblBigNum = 3.000000000000002;
            Console.WriteLine("DBL : PI + bigNum = {0}", dblPiVal + dblBigNum);

            Console.WriteLine("Biggest Double : {0}", double.MaxValue.ToString("#"));
            Console.WriteLine("Smallest Double : {0}", double.MinValue.ToString("#"));
            Console.WriteLine("");


                // 128-bit with decimals
            decimal decPiVal = 3.1415926535897932384626433832M;     // The 'M' at the end is to make sure it's not treated as a double. 
            decimal decBigNum = 3.00000000000000000000000000011M;
            Console.WriteLine("DEC : PI + bigNum = {0}", decPiVal + decBigNum);     // The calculation is wrong at the end since it won't show the last digit in decBigNum.

            Console.WriteLine("Biggest Decimal : {0}", decimal.MaxValue);
            Console.WriteLine("Smallest Decimal : {0}", decimal.MinValue);
            Console.WriteLine("");
            // There are other datatypes as well but these are the most used ones. 


            bool boolFromStr = bool.Parse("true");
            int intFromStr = int.Parse("100");
            double dblFromStr = double.Parse("1,234");
            Console.WriteLine("Converted from bool {0} to interger {1} to double {2}", boolFromStr, intFromStr, dblFromStr);
            Console.WriteLine("");


                // Handeling dates
            DateTime awesomeDate = new DateTime(1974, 12, 21);  // Set a date (year, month, day)
            Console.WriteLine("Important date: {0} on {1}", awesomeDate.DayOfWeek, awesomeDate); 

            awesomeDate = awesomeDate.AddDays(4);
            awesomeDate = awesomeDate.AddMonths(1); 
            awesomeDate = awesomeDate.AddYears(1);
            Console.WriteLine("NewDate : {0}", awesomeDate.Date);
            Console.WriteLine("");

                // Handeling times
            TimeSpan lunchTime = new TimeSpan(12, 30, 0);   // Set a time (hour, minute, second)
            Console.WriteLine("Lunch time : {0}", lunchTime);

            lunchTime = lunchTime.Subtract(new TimeSpan(0, 15, 0));
            lunchTime = lunchTime.Add(new TimeSpan(1, 0, 0));
            Console.WriteLine("New time : {0}", lunchTime.ToString());
            Console.WriteLine("");


                // Huge integer
            BigInteger bigNum = BigInteger.Parse("1234512345123451234512345");
            Console.WriteLine("Big Num * 2 + 1 = {0}", bigNum * 2 + 1);
            Console.WriteLine("");


                // Formatting numbers
            Console.WriteLine("Number : {0:n4}", 2300);
            Console.WriteLine("General : {0:g}", 23.45);
            Console.WriteLine("Currency : {0:c}", 23.455);
            Console.WriteLine("3 Decimals : {0:f3}", 23.4555);
            Console.WriteLine("Scientific : {0:e}", 23000);
            Console.WriteLine("Pad with 0s : {0:d4}", 23);
            Console.WriteLine("Hexadecimal 230 : {0:x}", 230);
            Console.WriteLine("");

                // Formatting strings in different ways
            string randString = "This is a fucking string";
            Console.WriteLine(randString);
            Console.WriteLine("String Length : {0}", randString.Length);    
            Console.WriteLine("Remove string : {0}", randString.Remove(0, 6));
            Console.WriteLine("Index of 'is' : {0}", randString.IndexOf("is"));    
            Console.WriteLine("String contains 'is' : {0}", randString.Contains("is"));
            Console.WriteLine("Insert string : {0}", randString.Insert(10, " short "));
            Console.WriteLine("Replace string : {0}", randString.Replace("string", "sentence"));
            Console.WriteLine("Compare A to B : {0}", String.Compare("A", "B", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("");

            Console.WriteLine("Padding left : {0}", randString.PadLeft(50, '.'));
            Console.WriteLine("Padding right : {0}", randString.PadRight(50, '.'));
            Console.WriteLine("Trimming : {0}", randString.Trim());
            Console.WriteLine("");      // is this padding and trimming thing really working?

            Console.WriteLine("Uppercase : {0}", randString.ToUpper());
            Console.WriteLine("Lowercase : {0}", randString.ToLower());
            Console.WriteLine("");

            string newString = String.Format("{0} saw a {1} {2} in the {3}", "Molly", "fluffy", "sheep", "bathtub");
            Console.WriteLine(newString);
            Console.WriteLine("");

            string quoteString = String.Format("\"Roses are red, violets are blue...\"");
            Console.WriteLine(quoteString);
            Console.WriteLine("");

            string fnuttString = String.Format("\'fnuttigt\'");
            Console.WriteLine(fnuttString);
            Console.WriteLine("");

            string backslashString = String.Format("\\\\\\\\\\\\\\\\");
            Console.WriteLine(backslashString);
            Console.WriteLine("");

            // string alertString = String.Format("\a ALERT!");
            // Console.WriteLine(alertString);
            // Console.WriteLine("");


            Console.Write(@"Exactly what I typed \(^_^')/");
            Console.WriteLine("");


            Console.ReadLine();     //So that the console don't dissapear immediately.
        }

        private static void SayHello()
        {
            string name = "";
            Console.Write("What is your name? ");
            name = Console.ReadLine();
            Console.WriteLine("Hello {0}. Have a nice day!", name );
        }
    }
}
