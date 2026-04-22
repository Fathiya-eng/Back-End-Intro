using System.Diagnostics;

namespace Project_Solution01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Practice 
            //File.Create("text01.txt");
            //using (FileStream fs = File.Create("text01.txt"));

            //File.WriteAllText("text01.txt", "Hello my File");



            //string[] lines = { "Fathiya", "Ebtesam", "Malak", "Wedad" };
            //File.WriteAllLines("text01.txt", lines);

            //File.AppendAllText("text01.txt", "\n this is new line"); 
            #endregion


            //=========================================================


            #region Task 

            //File.Create("exam01.txt");
            //File.Create("exam02.txt");
            //File.Create("exam03.txt");


            Console.WriteLine("Enter number of exam you want");
            int number = Convert.ToInt32(Console.ReadLine());

            try
            {
                if (number == 1)
                {
                    
                    Process.Start("notepad.exe", "Exam01.txt");
                }
                else if (number == 2)
                {
                    
                    Process.Start("notepad.exe", "Exam02.txt");
                }
                else if (number == 3)
                {
                    
                    Process.Start("notepad.exe", "Exam03.txt");
                }
                else
                {
                    Console.WriteLine("The Value is Invalid");
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        
    

            #endregion












}
    }
        }
