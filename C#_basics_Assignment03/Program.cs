using System.Drawing;
using System.Reflection;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C__basics_Assignment03
{
    internal class Program
    {
        #region Q03
        
        public static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Library!");
        }

        #endregion

        #region Q04

        public static void PrintBookTitle(string title)
        {
            Console.WriteLine($"Book title: {title}");
        }

        #endregion

        #region Q05
        static void  AddBonusPages(int pages)
        {
            pages += 50;
        }
        #endregion


        #region Q06
        static void ApplyDiscount(double[] prices)
        {
            prices[0] -= 5;
        }

        #endregion


        #region Q07
        static void AddBonusPagesByRef(ref int pages)
        {
            pages += 50;
        }
        #endregion

        #region Q08
        static void ReplaceArray(ref double[] prices)
        {
            prices =new double[] { 10.0, 12.5, 15.0 };
        }
        #endregion

        #region Q09
        // Write a method bool TryGetPrice(string title, out double price) that returns true and sets
        //price to 25.5 if title is "Clean Code", otherwise returns false and sets price to 0.
        static bool TryGetPrice(string title, out double price)
        {
            if (title == "Clean Code") {
                price = 25.5;
                return true;
            }
            price = 0;
            return false;

        }
        #endregion

        #region Q10
        // Write a method PrintBookInfo(string title, int pages = 300) where pages is optional.
        static void PrintBookInfo(string title, int pages = 300)
        {
            Console.WriteLine($"title: {title} , pages: {pages}");
        }
        #endregion

        #region Q12
        // Write a method PrintAllTitles(params string[] titles) that prints each title on its own line.
        static void PrintAllTitles(params string[] titles)
        {
            for (int i = 0; i < titles.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {titles[i]}");
            }
        }
        #endregion
        static void Main(string[] args)
        {
            #region Q01

            // Create a one-dimensional array double[] prices with the values 25.5, 40.0, 33.75.
            // Print the second price(index 1).

            Console.WriteLine("--------------- Q01 ---------------");
            Console.WriteLine();

            double[] pries = { 25.5 ,40.0,33.75};
            Console.WriteLine($"second price: {pries[1]}");
            Console.WriteLine();

            #endregion

            #region Q02

            //Create a 2x2 multidimensional array int[,] shelfCopies where shelf 0 has 3, 5 copies and
            //shelf 1 has 1, 4 copies.Print the number of copies on shelf 1, slot 0.
            Console.WriteLine("--------------- Q02 ---------------");
            Console.WriteLine();

            int[,] shelfCopies = { { 3, 5 }, { 1, 4 } };
            Console.WriteLine($"The number of copies on shelf 1, slot 0 : {shelfCopies[1,0]}");


            Console.WriteLine();

            #endregion

            #region Q03

            // Write a method called PrintWelcomeMessage that takes no parameters and prints
            //"Welcome to the Library!".Call it from Main.

            Console.WriteLine("--------------- Q03 ---------------");
            Console.WriteLine();

            PrintWelcomeMessage();

            Console.WriteLine();

            #endregion

            #region Q04

            // Write a method PrintBookTitle(string title) that prints "Book title: " + title. Call it with
            //"Clean Code".


            Console.WriteLine("--------------- Q04 ---------------");
            Console.WriteLine();

            PrintBookTitle("Clean Code");

            Console.WriteLine();

            #endregion

            #region Q05

            // Write a method AddBonusPages(int pages) that adds 50 to pages. Call it with a variable
            //int pages = 400; and print pages afterward. What do you expect to see, and why?


            Console.WriteLine("--------------- Q05 ---------------");
            Console.WriteLine();

            int pages = 400;
            AddBonusPages(pages);
            Console.WriteLine($"Pages: {pages}");
            /// Answer:
            /// What do you expect to see => 400
            /// Why ? Because the function was called by value, not by reference,
            /// so I'm copying the existing value, not sending a pointer pointing to the page titles.
            Console.WriteLine();

            #endregion

            #region Q06

            // Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0]. Call it
            //with double[] prices = { 25.5, 40.0 }; and print prices[0] afterward.What do you expect to
            //see, and why?

            Console.WriteLine("--------------- Q06 ---------------");
            Console.WriteLine();

            double[] prices = { 25.5, 40.0 };
            ApplyDiscount(prices);
            Console.WriteLine($"prices[0]: {prices[0]}");
            /// Answer:
            /// What do you expect to see ? 20.5
            /// Why ? Because the array is a reference type, it will send the same address that it points to in the heap.
            /// When I update the value in the heap, it will be reflected in the base variable because 
            /// it points to the same location in the heap.

            Console.WriteLine();

            #endregion

            #region Q07

            // Rewrite the method from question 5 as AddBonusPagesByRef(ref int pages) using ref.
            //Call it and print pages afterward. How is the result different from question 5 ?

            Console.WriteLine("--------------- Q07 ---------------");
            Console.WriteLine();

            AddBonusPagesByRef(ref pages);
            Console.WriteLine($"Pages: {pages}");
            /// Answer:
            /// What do you expect to see => 450
            /// Why ? Because the function was called by ref, not by value,
            /// so I'm copying the existing address, not copying value.


            Console.WriteLine();

            #endregion

            #region Q08

            // Write a method ReplaceArray(ref double[] prices) that replaces prices entirely with a
            //new array { 10.0, 12.5, 15.0 }.Call it with your prices array and print prices.Length
            //afterward.

            Console.WriteLine("--------------- Q08 ---------------");
            Console.WriteLine();

            ReplaceArray(ref prices);
            Console.WriteLine($"Prices.Length: {prices.Length}");

            Console.WriteLine();
            #endregion

            #region Q09

            // Write a method bool TryGetPrice(string title, out double price) that returns true and sets
            //price to 25.5 if title is "Clean Code", otherwise returns false and sets price to 0.Call it
            //and print the price if found

            Console.WriteLine("--------------- Q09 ---------------");
            Console.WriteLine();

            bool foundCleanCode = TryGetPrice("Clean Code",out double price);
            if (foundCleanCode)
            {
                Console.WriteLine($"The price of the Clean Code book is {price}");
            }

            foundCleanCode = TryGetPrice("C# Basics",out price);
            if (foundCleanCode)
            {
                Console.WriteLine($"The price of the Clean Code book is {price}");
            }

            Console.WriteLine();
            #endregion

            #region Q10

            // Write a method PrintBookInfo(string title, int pages = 300) where pages is optional. Call
            //it once with only a title, and once passing both a title and pages.


            Console.WriteLine("--------------- Q10 ---------------");
            Console.WriteLine();

            PrintBookInfo("Clean Code");
            PrintBookInfo("Clean Code", 450);

            Console.WriteLine();
            #endregion


            #region Q11

            // Using the PrintBookInfo method from the question above, call it by naming the
            //parameters, passing pages before title

            Console.WriteLine("--------------- Q11 ---------------");
            Console.WriteLine();

            PrintBookInfo(pages:400,title:"Clean Code");

            Console.WriteLine();
            #endregion

            #region Q12

            // Write a method PrintAllTitles(params string[] titles) that prints each title on its own line.
            //Call it with three book titles.

            Console.WriteLine("--------------- Q12 ---------------");
            Console.WriteLine();

            PrintAllTitles("Clean Code", "C# Basics", "OOP");

            Console.WriteLine();
            #endregion

            
        }
    }
}
