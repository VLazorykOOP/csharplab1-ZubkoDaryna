using System;

class Program
{
    static void task1()
    {
         Console.WriteLine("Task 1 !");
    Console.Write("Please, write the first number= ");
    string? str1 = Console.ReadLine();
    Console.Write("Please, write the second number= ");
    string? str2 = Console.ReadLine();

    if (str1 != null && str2 != null)
    {
        float num1 = float.Parse(str1);
        float num2 = float.Parse(str2);
        float abs1=Math.Abs(num1);
        float abs2=Math.Abs(num2);

        double p = Math.Sqrt(abs1 * abs2);
        Console.WriteLine("The geometric mean is:" + p);
    }
    }

    static void task2()
    {
       Console.WriteLine("Task 2 !");
    Console.Write("Number= ");
    string str = Console.ReadLine();
    if (int.TryParse(str, out int number))
    {
        if (number % 10 == 7)
        {
            Console.WriteLine("The entered number ends with the digit 7");
        }
        else
        {
            Console.WriteLine("The entered number doesn't end with the digit 7");
        }
    }
    else {
        Console.WriteLine("Incorrect input");
            }
    }

    static void task3()
    {
        Console.Write("x=");
    float x = float.Parse(Console.ReadLine()); 
    Console.Write("y=");
    float y = float.Parse(Console.ReadLine());
    if (x * x + y * y > 9 && x * x + y * y < 49)
        Console.WriteLine("Inside");
    else if (x * x + y * y < 9 || x * x + y * y > 49)
        Console.WriteLine("Outside"); 
    else Console.WriteLine("On the border of the circle");
    }

    static void task4()
    {
        Console.Write("Enter suit number (1-4):");
    int m = int.Parse(Console.ReadLine());
    Console.Write("Enter the card number (6-14):");
    int k = int.Parse(Console.ReadLine());
    string suit = "";
    string card = "";
    switch (m)
    {
        case 1: suit = "hearts"; break;
        case 2: suit = "diamonds"; break;
        case 3: suit = "clubs"; break; //трефа
        case 4: suit = "spades";  break; //піка
        default: Console.WriteLine("Wrong number of suit");
            return;
    }
    if (k >= 6 && k <= 10)
    {
        card = k.ToString();
    }
    else
    {
        switch (k)
        {
            case 11:card = "jack"; break;
            case 12: card = "queen"; break;
            case 13:card = "king"; break;
            case 14:card = "ace"; break;
            default: Console.WriteLine("Wrong number card");
                return;
        }
    }
    Console.WriteLine($"{card} {suit}");
    }

    static void task5()
    {
        Console.WriteLine("Task 5 !");
       Console.WriteLine("Enter the first real number:");
    double num1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Enter the second real number:");
    double num2 = double.Parse(Console.ReadLine());
    double sum = num1 + num2;
    Console.WriteLine($"The " + $"sum of {num1} and {num2} is: {sum}");
    }

    static void task6()
    {
        Console.WriteLine("Task 6 !");
        Console.WriteLine("Enter integer values for n and m:");
    Console.Write("n = ");
    int n = int.Parse(Console.ReadLine());
    Console.Write("m = ");
    int m = int.Parse(Console.ReadLine());

    double result = (n + m) * ((n + 1) / (m + 1) )+ (5.0 / m);
    Console.WriteLine("Result: " + result);

    }

    static void Main(string[] args)
    {
        Console.WriteLine("Lab 1 !");
        Console.WriteLine("Choose the task");
        Console.Write("Task:");

    if (int.TryParse(Console.ReadLine(), out int n))
        {
            switch (n)
            {
                case 1:
                    task1();
                    break;
                case 2:
                    task2();
                    break;
                case 3:
                    task3();
                    break;
                case 4:
                    task4();
                    break;
                case 5:
                    task5();
                    break;
                case 6:
                    task6();
                    break;
                default:
                    Console.WriteLine("Invalid task number.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid input for task number.");
        }
    }
}
