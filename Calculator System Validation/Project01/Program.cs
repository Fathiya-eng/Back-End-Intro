namespace Project01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Calculator 1 
            void Calculator()
            {
                Console.WriteLine("============================");
                Console.WriteLine("Welcome To My Calculator App");
                Console.WriteLine("============================");

                int Fnum;
                Console.WriteLine("Please Enter First Number:");
                try
                {
                    Fnum = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Invalid input for first number \n Please Enter only Number");
                    return;
                }

                int Snum;
                Console.WriteLine("Please Enter Second Number:");
                try
                {
                    Snum = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Invalid input for second number \n Please Enter only Number");
                    return;
                }

                char Operation;
                Console.WriteLine("Please Enter an Operation (+, -, *, /):");
               
                Operation = Convert.ToChar(Console.ReadLine());
                
                if (Operation == '+')
                {
                    Console.WriteLine($"{Fnum} + {Snum} = {Fnum + Snum}");
                }
                else if (Operation == '-')
                {
                    Console.WriteLine($"{Fnum} - {Snum} = {Fnum - Snum}");
                }
                else if (Operation == '*')
                {
                    Console.WriteLine($"{Fnum} * {Snum} = {Fnum * Snum}");
                }
                else if (Operation == '/')
                {
                    if (Snum == 0)
                    {
                        Console.WriteLine("Cannot divide by zero");
                    }
                    else
                    {
                        Console.WriteLine($"{Fnum} / {Snum} = {Fnum / Snum}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid operation, Try again!");
                }
            }

            Calculator();
            #endregion

            //*******************************************************

            #region Calculator2 
            //void Calculator(int Fnum, int Snum, char Operation)
            //{

            //    if (Operation == '+')
            //        Console.WriteLine($"{Fnum} + {Snum} = {Fnum + Snum}");

            //    else if (Operation == '-')
            //        Console.WriteLine($"{Fnum} - {Snum} = {Fnum - Snum}");

            //    else if (Operation == '*')
            //        Console.WriteLine($"{Fnum} * {Snum} = {Fnum * Snum}");

            //    else if (Operation == '/')
            //    {
            //        if (Snum == 0)
            //            Console.WriteLine("Cannot divide by zero, Try again");
            //        else
            //            Console.WriteLine($"{Fnum} / {Snum} = {Fnum / Snum}");
            //    }

            //    else
            //        Console.WriteLine("Invalid operation");
            //}

            //Calculator(10, 5, '+'); 
            #endregion




            //*******************************************************
        }
    }
}
