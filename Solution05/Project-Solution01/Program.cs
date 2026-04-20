namespace Project_Solution01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Task1: 

            //Console.Write("Enter number from 1 to 7: ");
            //int day = int.Parse(Console.ReadLine());

            //switch (day)
            //{
            //    case 1: Console.WriteLine("Monday");
            //        break;
            //    case 2: Console.WriteLine("Tuesday");
            //        break;
            //    case 3: Console.WriteLine("Wednesday");
            //        break;
            //    case 4: Console.WriteLine("Thursday");
            //        break;
            //    case 5: Console.WriteLine("Friday");
            //        break;
            //    case 6: Console.WriteLine("Saturday");
            //        break;
            //    case 7: Console.WriteLine("Sunday");
            //        break;

            //    default:
            //        Console.WriteLine("Invalid day number");
            //        break;
            //}
            //=========================================================

            //Task2: 

            //Console.Write("Enter number: "); 
            //int num = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(num + " x " + i + " = " + (num * i));
            //}

            //=========================================================

            //Task3: 

            //Console.Write("Enter positive number: ");
            //int PNum = Convert.ToInt32(Console.ReadLine());

            //if (PNum <= 0)
            //{
            //    Console.WriteLine("Please enter a positive number");
            //}

            //else
            //{
            //    while (PNum >= 1)
            //    {
            //        Console.WriteLine(PNum);
            //        PNum--;
            //    }
            //    Console.WriteLine("Go!");
            //}

            //===========================================================

            //Task4 :

            //Console.Write("Enter month 1-12: ");
            //int month = Convert.ToInt32(Console.ReadLine());

            //if (month < 1 || month > 12)
            //{
            //    Console.WriteLine("Invalid month number");
            //}
            //else
            //{
            //    switch (month)
            //    {
            //        case 12:
            //        case 1:
            //        case 2:
            //            Console.WriteLine("Winter");
            //            break;

            //        case 3:
            //        case 4:
            //        case 5:
            //            Console.WriteLine("Spring");
            //            break;

            //        case 6:
            //        case 7:
            //        case 8:
            //            Console.WriteLine("Summer");
            //            break;

            //        default:
            //            Console.WriteLine("Autumn");
            //            break;
            //    }
            //}
            //==================================================

            //Task5: 

            //Console.Write("Enter number: ");
            //int N = Convert.ToInt32(Console.ReadLine());

            //int evenSum = 0;
            //int oddSum = 0;

            //for (int i = 1; i <= N; i++)
            //{
            //    if (i % 2 == 0)
            //        evenSum += i;
            //    else
            //        oddSum += i;
            //}

            //Console.WriteLine("Even Sum = " + evenSum);
            //Console.WriteLine("Odd Sum = " + oddSum);

            //====================================================

            // Task6: 

            //string password;
            //int attempts = 0;

            //while (true)
            //{
            //    Console.Write("Enter password: ");
            //    password = Console.ReadLine();

            //    if (password == "1234")
            //    {
            //        Console.WriteLine("Access Granted");
            //        break;
            //    }
            //    else
            //    {
            //        attempts++;

            //        if (attempts == 3)
            //        {
            //            Console.WriteLine("Account Locked");
            //            break;
            //        }

            //        Console.WriteLine("Wrong password, try again");
            //        Console.WriteLine("Attempts left: " + (3 - attempts));
            //    }
            //}

            //====================================================

            //Task7: 

            //while (true)
            //{
            //    Console.Write("Enter first number: ");
            //    double num1 = double.Parse(Console.ReadLine());

            //    Console.Write("Enter second number: ");
            //    double num2 = double.Parse(Console.ReadLine());

            //    Console.Write("Enter operator (+,-,*,/) or exit: ");
            //    string op = Console.ReadLine();

            //    if (op == "exit")
            //        break;

            //    switch (op)
            //    {
            //        case "+":
            //            Console.WriteLine(num1 + num2);
            //            break;

            //        case "-":
            //            Console.WriteLine(num1 - num2);
            //            break;

            //        case "*":
            //            Console.WriteLine(num1 * num2);
            //            break;

            //        case "/":
            //            if (num2 != 0)
            //                Console.WriteLine(num1 / num2);
            //            else
            //                Console.WriteLine("Cannot divide by zero");
            //            break;

            //        default:
            //            Console.WriteLine("Invalid operator");
            //            break;
            //    }
            //}

            //====================================================

            //Task8: 

            //Console.Write("Start: ");
            //int start = int.Parse(Console.ReadLine());

            //Console.Write("End: ");
            //int end = int.Parse(Console.ReadLine());

            //bool found = false;

            //for (int i = start; i <= end; i++)
            //{
            //    if (i > 1)
            //    {
            //        bool isPrime = true;

            //        for (int j = 2; j < i; j++)
            //        {
            //            if (i % j == 0)
            //            {
            //                isPrime = false;
            //                break;
            //            }
            //        }

            //        if (isPrime)
            //        {
            //            Console.WriteLine(i);
            //            found = true;
            //        }
            //    }
            //}

            //if (!found)
            //{
            //    Console.WriteLine("No prime numbers found");
            //}



            //====================================================

            // Task9: 

            //Console.Write("Number of students: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] scores = new int[n];

            //int max = 0;
            //int min = 100;

            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("Enter score: ");
            //    scores[i] = int.Parse(Console.ReadLine());

            //    if (scores[i] > max) max = scores[i];
            //    if (scores[i] < min) min = scores[i];

            //    int key = scores[i] / 10;

            //    switch (key)
            //    {
            //        case 10:
            //        case 9: Console.WriteLine("Excellent"); break;
            //        case 8: Console.WriteLine("Very Good"); break;
            //        case 7:
            //        case 6: Console.WriteLine("Good"); break;
            //        case 5: Console.WriteLine("Pass"); break;
            //        default: Console.WriteLine("Fail"); break;
            //    }
            //}

            //Console.WriteLine("Highest = " + max);
            //Console.WriteLine("Lowest = " + min);

            //====================================================

            // Task10:

            int balance = 5000;
            string pin;
            int attempts = 0;

            // Login
            while (true)
            {
                Console.Write("Enter PIN: ");
                pin = Console.ReadLine();

                if (pin == "9999")
                    break;

                attempts++;

                if (attempts == 3)
                {
                    Console.WriteLine("Card Blocked");
                    return;
                }
            }

            // Transactions storage
            string[] types = new string[100];
            int[] amounts = new int[100];
            int index = 0;

            // Menu
            while (true)
            {
                Console.WriteLine("\n1- Check Balance");
                Console.WriteLine("2- Deposit");
                Console.WriteLine("3- Withdraw");
                Console.WriteLine("4- Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Balance: " + balance);
                        break;

                    case 2:
                        Console.Write("Enter deposit: ");
                        int dep = int.Parse(Console.ReadLine());

                        if (dep > 0 && dep <= 10000)
                        {
                            balance += dep;
                            types[index] = "Deposit";
                            amounts[index] = dep;
                            index++;
                        }
                        else
                        {
                            Console.WriteLine("Invalid deposit amount");
                        }
                        break;

                    case 3:
                        Console.Write("Enter withdraw: ");
                        int wit = int.Parse(Console.ReadLine());

                        if (wit > 0 && wit <= balance)
                        {
                            balance -= wit;
                            types[index] = "Withdraw";
                            amounts[index] = wit;
                            index++;
                        }
                        else
                        {
                            Console.WriteLine("Invalid withdraw");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Transactions:");
                        for (int i = 0; i < index; i++)
                        {
                            Console.WriteLine(types[i] + " - " + amounts[i]);
                        }
                        return;

                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }

            //====================================================

        }
    }
}
