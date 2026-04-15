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

            Console.Write("Enter number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int evenSum = 0;
            int oddSum = 0;

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                    evenSum += i;
                else
                    oddSum += i;
            }

            Console.WriteLine("Even Sum = " + evenSum);
            Console.WriteLine("Odd Sum = " + oddSum);

            //====================================================


        }
    }
}
