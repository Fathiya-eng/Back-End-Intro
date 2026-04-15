namespace Project_Solution01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Task1: 
            //Console.WriteLine("Enter a number: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //if (number > 0) {
            //    Console.WriteLine("Positive");
            //}

            // else if (number < 0) {
            //    Console.WriteLine("Negative");
            //}

            //    else {
            //    Console.WriteLine("Zero");
            //}

            //==================================================


            //// Task2: 
            //Console.WriteLine("Enter a number: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //if (number % 2 == 0)
            //{

            //    Console.WriteLine("Even Number");
            //}

            //else
            //{
            //    Console.WriteLine("Odd Number");
            //}

            //===================================================

            //// Task3: 

            //Console.WriteLine("Enter score (0-100):");
            //int score = Convert.ToInt32(Console.ReadLine());

            //if (score >= 90 && score <= 100)
            //{
            //    Console.WriteLine("Excellent");

            //}
            //else if (score >= 75)
            //{
            //    Console.WriteLine("Very Good");
            //}

            //else if (score >= 60)
            //{
            //    Console.WriteLine("Good");
            //}

            //else if (score >= 50)
            //{
            //    Console.WriteLine("Pass");
            //}

            //else
            //{
            //    Console.WriteLine("Fail");
            //}

            //=========================================================

            //// Task4: 
            //string userName = "admin";
            //string password = "1234";

            //Console.WriteLine("Enter UserName:");
            //string UserName = Console.ReadLine();

            //Console.WriteLine("Enter Password:");
            //string Password = Console.ReadLine();

            //if (UserName == userName && Password == password)
            //{
            //    Console.WriteLine("Login Success");
            //}
            //else
            //{
            //    Console.WriteLine("Login Fail.. try again");

            //}

            //=========================================================

            //Task5:

            int balance = 1000;

            Console.WriteLine("Enter withdrawal amount: ");
            int amount = Convert.ToInt32(Console.ReadLine());

            if (amount <= 0)
            {
                Console.WriteLine("Invalid Amount");
            }

            else if (amount > balance)
            {
                Console.WriteLine("Insufficient Balance");
            }

            else
            {
                balance = balance - amount;
                Console.WriteLine("Withdrawal Successful");
                Console.WriteLine("Remaining Balance:" + balance);
            }



        }
    }
}
