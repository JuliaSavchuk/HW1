using System.Globalization;

namespace CS_L1
{
    public static class FileName
    {
        public static void Task1()
        {
            Console.WriteLine("Task 1: Enter a number from 1 to 100:");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number < 1 || number > 100)
            {
                Console.WriteLine("Error: The number you entered is not in the range 1 to 100.");
            }
            else
            {
                if (number % 3 == 0 && number % 5 == 0)
                    Console.WriteLine("FizzBuzz");
                else if (number % 3 == 0)
                    Console.WriteLine("Fizz");
                else if (number % 5 == 0)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(number);
            }
        }
        public static void Task2()
        {
            Console.WriteLine("\nTask 2: Enter two numbers (first number, then percentage):");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double percent = Convert.ToDouble(Console.ReadLine());

            double result = (num1 * percent) / 100;
            Console.WriteLine($"Result: {result}");
        }
        public static void Task3()
        {
            Console.WriteLine("\nTask 3: Enter four numbers:");
            int digit1 = Convert.ToInt32(Console.ReadLine());
            int digit2 = Convert.ToInt32(Console.ReadLine());
            int digit3 = Convert.ToInt32(Console.ReadLine());
            int digit4 = Convert.ToInt32(Console.ReadLine());

            int formedNumber = digit1 * 1000 + digit2 * 100 + digit3 * 10 + digit4;
            Console.WriteLine($"Formed number: {formedNumber}");
        }
        public static void Task4()
        {
            Console.WriteLine("Task 4: Enter a six-digit number:");
            string inputNumber = Console.ReadLine();

            if (inputNumber.Length != 6)
            {
                Console.WriteLine("Error: The number entered is not a six-digit number.");
            }
            else
            {
                Console.WriteLine("Enter digit numbers to replace digits (from 1 to 6):");
                int index1 = Convert.ToInt32(Console.ReadLine()) - 1; 
                int index2 = Convert.ToInt32(Console.ReadLine()) - 1;

                if (index1 < 0 || index1 > 5 || index2 < 0 || index2 > 5)
                {
                    Console.WriteLine("Error: digit number must be between 1 and 6.");
                }
                else
                {
                    char[] digits = inputNumber.ToCharArray();
                    char temp = digits[index1];
                    digits[index1] = digits[index2];
                    digits[index2] = temp;

                    string result = new string(digits);
                    Console.WriteLine($"Result: {result}");
                }
            }
        }
        public static void Task5()
        {
            Console.WriteLine("Task 5: Enter the date in dd.mm.yyyy format:");
            string input = Console.ReadLine();

            if (DateTime.TryParseExact(input, "dd.mm.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
            {
                string dayOfWeek = date.ToString("dddd", new CultureInfo("en-US"));
                string season = GetSeason(date.Month);

                Console.WriteLine($"{season} {dayOfWeek}");
            }
            else
            {
                Console.WriteLine("Invalid date format.");
            }

            static string GetSeason(int month)
            {
                if (month >= 3 && month <= 5)
                    return "Spring";
                else if (month >= 6 && month <= 8)
                    return "Summer";
                else if (month >= 9 && month <= 11)
                    return "Autumn";
                else
                    return "Winter";
            }
        }
        public static void Task6()
        {
            Console.WriteLine("\nTask 6: Enter the temperature:");
            double temperature = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Select units of measurement (1 - Celsius, 2 - Fahrenheit):");
            int choice = Convert.ToInt32(Console.ReadLine());
            double convertedTemperature = 0;
            if (choice == 1)
            {
                convertedTemperature = (temperature - 32) * 5 / 9;
                Console.WriteLine($"Result: {convertedTemperature} °C");
            }
            else if (choice == 2)
            {
                convertedTemperature = (temperature * 9 / 5) + 32;
                Console.WriteLine($"Result: {convertedTemperature} °F");
            }
        }
        public static void Task7()
        {
            Console.WriteLine("\nTask 7: Enter two numbers:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int start = Math.Min(num1, num2);
            int end = Math.Max(num1, num2);

            if (start % 2 != 0)
                start++;

            Console.WriteLine("Even numbers in the specified range:");
            for (int i = start; i <= end; i += 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
