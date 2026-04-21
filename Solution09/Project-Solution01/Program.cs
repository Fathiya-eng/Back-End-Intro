namespace Project_Solution01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //================================================

            #region Array 1 
            //Console.Write("Enter number of rows: ");
            //int rows = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter number of columns: ");
            //int cols = Convert.ToInt32(Console.ReadLine());

            //int[,] numbers = new int[rows, cols];
            //int value = 1;

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        numbers[i, j] = value++;
            //    }
            //}

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write(numbers[i, j] + $"({i},{j}) ");
            //    }
            //    Console.WriteLine();
            //} 
            #endregion


            //=================================================

            #region Array 2 
            //Console.WriteLine("Enter the number of rows:");
            //int rows = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter the number of columns:");
            //int cols = Convert.ToInt32(Console.ReadLine());

            //int[,] x = new int[rows, cols];

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write($"({i} , {j}) = ");
            //        x[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}
            //Console.WriteLine("===========");
            //Console.WriteLine("Array:");

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.WriteLine($"({i} , {j}) = {x[i, j]}");
            //    }
            //}
            #endregion

            //==================================================

            #region Student Management System Assignment

            //Part 1 :
            int studentCount = 5;
            string[] students = new string[studentCount];


            Console.WriteLine("Enter 5 Name of Students: ");

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"Student {i+1}:");
                students[i] = Console.ReadLine();
            }
            Console.WriteLine("====================");
            Console.WriteLine("Students List:");
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"{i}: {students[i]}");
                
            }

            //Part 2 : 
            int[,] grades = new int[studentCount, 3];
            string[] subjects = { "Math", "Science", "English" };

            Console.WriteLine("==================");
            Console.WriteLine("Enter the grades for each studen: ");

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"{students[i]}:");

                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"{subjects[j]}:");
                    grades[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //Part 3 :
            Console.WriteLine("==================");
            Console.WriteLine("Students Grades Table:");
            Console.Write("Student  ");

            for (int j = 0; j < subjects.Length; j++)
            {
                Console.Write(subjects[j] + "\t");
            }
            Console.WriteLine();
            for (int i = 0; i < studentCount; i++)
            {
                Console.Write(students[i] + "\t");

                for (int j = 0; j < subjects.Length; j++)
                {
                    Console.Write(grades[i, j] + "\t");
                }

                Console.WriteLine();
            }

            //Part 4 :
            Console.WriteLine("==================");
            Console.WriteLine("\nStudent Averages:\n");

            for (int i = 0; i < studentCount; i++)
            {
                int sum = 0;

                for (int j = 0; j < subjects.Length; j++)
                {
                    sum += grades[i, j];
                }

                double average = (double)sum / subjects.Length;

                Console.WriteLine($"{students[i]} Average = {average}");
            }

            //Part 5 : 

            int[][] grades02 = new int[studentCount][];
            Console.WriteLine("==================");
            Console.WriteLine("\nNumber of subjects and grades for each student:\n");

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"\nEnter number of subjects for {students[i]}: ");
                int subjectCount = Convert.ToInt32(Console.ReadLine());

                grades02[i] = new int[subjectCount];

                for (int j = 0; j < subjectCount; j++)
                {
                    Console.Write($"Enter grade for subject {j + 1}: ");
                    grades02[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("\nStudents Data:\n");

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"{students[i]} has {grades02[i].Length} subjects:");

                for (int j = 0; j < grades02[i].Length; j++)
                {
                    Console.WriteLine($"Subject {j + 1}: {grades02[i][j]}");
                }

                Console.WriteLine();
            }

            Console.WriteLine("==================");

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write(students[i] + ": ");

                for (int j = 0; j < grades02[i].Length; j++)
                {
                    Console.Write(grades02[i][j] + ": ");
                }

                Console.WriteLine();
            }

            //Part 6 :

            Console.WriteLine("==================");
            Console.WriteLine("Search for a Student:");

            Console.Write("Enter student name: ");
            string searchName = Console.ReadLine();

            bool found = false;

            for (int i = 0; i < studentCount; i++)
            {
                if (students[i] == searchName)
                {
                    Console.WriteLine($"Student found at index {i}");
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Student not found");
            }

            //Part 7 : 

            int highest = grades[0, 0];
            for (int i = 0; i < studentCount; i++)
            {
                for (int j = 0; j < grades02[i].Length; j++)
                {
                    if (grades02[i][j] == highest)
                    {
                        highest = grades02[i][j];
                    }
                }
            }
            Console.WriteLine("===================");
            Console.WriteLine($"Highest Grade: {highest}");
            #endregion


                //==================================================


            }
    }
}
