namespace Project_Solution01
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Errors handling  
            //try
            //{
            //    int x = 10;
            //    int y = int.Parse(Console.ReadLine()); // The user maybe enter string
            //    int result = x / y; // y can be zero
            //}
            //catch (DivideByZeroException)
            //{
            //    // تعالج خطأ القسمة على صفر فقط
            //    Console.WriteLine("can't divided by zero!");
            //}
            //catch (FormatException)
            //{
            //    // تعالج خطأ إدخال نص بدل رقم
            //    Console.WriteLine("please enter mumber only.");
            //}
            //catch (Exception ex)
            //{
            //    // تعالج أي خطأ آخر لم يتم التقاطه بالأعلى (الأكثر عمومية)
            //    Console.WriteLine($"There is an Error: {ex.Message}");
            //}
            //finally
            //{
            //    Console.WriteLine("Done");
            //}
            #endregion




            #region handling (Parsing) 
            
            //try
            //{
            //    string input = "9999999999999999999";
            //    int number = int.Parse(input); 
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("You not enter a number.");
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("The number too long");
            //}
            #endregion



            #region Compilation Error
            
            int say(int x, int y)
            {
                return x + y;
            }

            say(45,5); 

            #endregion



        }
    }
}
