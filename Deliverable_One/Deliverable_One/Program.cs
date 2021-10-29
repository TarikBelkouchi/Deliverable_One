using System;



    class Program
    {
        static void Main(string[] args)
        {
            double amount = 0, convertedAmount = 0;
            string conversionType = "";

            bool running = true;

            while (running)
            {
                Console.WriteLine("Please enter 1-4 to select one of the following measurement Type : ");
                Console.WriteLine("1 - Inch to Fidget spinners");
                Console.WriteLine("2 - Fidget spinners to Inch");
                Console.WriteLine("3 - Foot to Meme");
                Console.WriteLine("4 - Meme to Foot");
                Console.WriteLine("Your Choice : ");
                conversionType = Console.ReadLine();

                Console.WriteLine("Please enter the amount to convert.");
                amount = Convert.ToDouble(Console.ReadLine());

                switch (conversionType)
                {
                    case "1":
                        convertedAmount = 3.5 * amount;
                        Console.WriteLine("{0} Inches are equal to {1} in Fidget spinners", amount, convertedAmount);
                        break;
                    case "2":
                        convertedAmount = amount / 3.5;
                        Console.WriteLine("{0} Fidget spinners are equal to {1} in Inches", amount, convertedAmount);
                        break;
                    case "3":
                        convertedAmount = amount * 5;
                        Console.WriteLine("{0} Foot are equal to {1} in Meme", amount, convertedAmount);
                        break;
                    case "4":
                        convertedAmount = amount / 5;
                        Console.WriteLine("{0} Meme are equal to {1} in Foot", amount, convertedAmount);
                        break;
                }

                Console.WriteLine("\nDo you want to do another calculation ?\n1 - Yes\n2 - No\nChoice : ");
                string choice = Console.ReadLine();

                if (choice == "2")
                    running = false;
            }
        }
    }


