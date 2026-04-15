namespace Project_Solution01
{
    internal class Program
    {
        static void Main(string[] args)
        {

           
            Console.WriteLine("Please Enter First number!");
            
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter Second number!");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
            Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
        }
    }
}
