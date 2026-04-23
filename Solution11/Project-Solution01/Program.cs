using System.Xml.Linq;

namespace Project_Solution01
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region List Practice 
            //List<int> list01 = new List<int>();

            //list01.Add(10);
            //list01.Add(20);
            //list01.Add(30);
            //list01.Add(10);
            //list01.Add(40);

            ////Console.WriteLine(list01[1]); //  يرجعلي العنصر المحدد في index

            //foreach (int i in list01)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("==================");
            //Console.WriteLine(list01.Count); // يحسبلي عدد العناصر 

            //try
            //{
            //    //    list01.Remove(10);
            //    //    list01.RemoveAt(2);
            //    //    list01.RemoveAll(x => x <= 10); 

            //    //list01.Clear(); // يمسح كامل العناصر داخل Array
            //    //Console.WriteLine(list01.Count);


            //    Console.WriteLine(list01.Contains(40));  // هل يوجد هذا العنصر ( true or false)
            //    Console.WriteLine(list01.IndexOf(20));   // يرجعلي أول رقم في ال index
            //    Console.WriteLine(list01.Find(x => x <= 10)); // يرجعلي أول عنصر حقق الشرط

            //    if(list01.Exists(x => x <= 10))
            //    {
            //        Console.WriteLine("Yes Element is here you can use find");
            //    }

            //}

            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            #endregion


            //==============================

            #region Function 

            void myCalculator()
            {
                bool again = true;

                while (again)
                {
                    Console.WriteLine("Enter First Number:");
                    int x = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Second Number:");
                    int y = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Operation (+, -, *, /):");
                    string operation = Console.ReadLine();

                    if (operation == "+")
                    {
                        Console.WriteLine((x + y));
                    }
                    else if (operation == "-")
                    {
                        Console.WriteLine((x - y));
                    }
                    else if (operation == "*")
                    {
                        Console.WriteLine((x * y));
                    }
                    else if (operation == "/")
                    {
                        if (y != 0)
                            Console.WriteLine((x / y));
                        else
                            Console.WriteLine("Cannot divide by zero");
                    }

                    else
                    {
                        Console.WriteLine("Invalid operation");
                    }

                    Console.WriteLine("Do you want another operation? (yes/no)");
                    string answer = Console.ReadLine();

                    if (answer != "yes")
                    {
                        again = false;
                    }
                }

                Console.WriteLine("Calculator closed.");
            }

            myCalculator();


            #endregion













        }
        }
    }
