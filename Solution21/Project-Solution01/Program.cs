namespace Project_Solution01
{
    #region Association 
    //internal class Program
    //{

    //    class Teacher
    //    {
    //        public string Name;

    //        public Teacher(string name)
    //        {
    //            Name = name;
    //        }
    //    }

    //    class Student
    //    {
    //        public string Name;

    //        public Student(string name)
    //        {
    //            Name = name;
    //        }

    //        public void StudyWith(Teacher t)
    //        {
    //            Console.WriteLine($"{Name} studies with teacher {t.Name}");
    //        }
    //    }

    //    static void Main(string[] args)
    //    {
    //        Teacher teacher = new Teacher("Ahmed");
    //        Student student = new Student("Ali");

    //        student.StudyWith(teacher);
    //    }
    //}
    #endregion

    //========================================================
    #region Aggregation 
    //class Student
    //{
    //    public string Name;

    //    public Student(string name)
    //    {
    //        Name = name;
    //    }
    //}

    //class University
    //{
    //    public string Name;


    //    public List<Student> Students;

    //    public University(string name)
    //    {
    //        Name = name;
    //        Students = new List<Student>();
    //    }

    //    public void AddStudent(Student s)
    //    {
    //        Students.Add(s);
    //    }
    //}

    //class Program
    //{
    //    static void Main()
    //    {
    //        Student s1 = new Student("Ali");
    //        Student s2 = new Student("Sara");

    //        University u = new University("Oman University");

    //        u.AddStudent(s1);
    //        u.AddStudent(s2);

    //        Console.WriteLine("University: " + u.Name);

    //        foreach (var x in u.Students)
    //        {
    //            Console.WriteLine("Student: " + x.Name);
    //        }

    //    }
    //}
    #endregion

    //========================================================
    #region Composition 
    //class Room
    //{
    //    public string Name;

    //    public Room(string name)
    //    {
    //        Name = name;
    //    }
    //}

    //class House
    //{
    //    private List<Room> rooms;

    //    public House()
    //    {
    //        rooms = new List<Room>();

    //        rooms.Add(new Room("Bedroom"));
    //        rooms.Add(new Room("Kitchen"));
    //        rooms.Add(new Room("Living Room"));
    //    }

    //    public void ShowRooms()
    //    {
    //        foreach (Room r in rooms)
    //        {
    //            Console.WriteLine(r.Name);
    //        }
    //    }
    //}

    //class Program
    //{
    //    static void Main()
    //    {
    //        House h = new House();

    //        h.ShowRooms();
    //    }
    //}
    #endregion

    //========================================================
    #region SOLID 
    //// interfe
    //interface IMessage
    //{
    //    void Send();
    //}
    //// open close
    //class Email : IMessage
    //{
    //    public void Send()
    //    {
    //        Console.WriteLine("Email Sent ");
    //    }
    //}
    ////another class add
    //class SMS : IMessage
    //{
    //    public void Send()
    //    {
    //        Console.WriteLine("SAend SMS");
    //    }
    //}
    ////
    //class Notification
    //{
    //    // Dependency
    //    private IMessage message;

    //    public Notification(IMessage m)
    //    {
    //        message = m;
    //    }
    //    //method for send message
    //    public void Notify()
    //    {
    //        message.Send();
    //    }

    //    internal class Program
    //    {
    //        static void Main(string[] args)
    //        {
    //            // liskove principle
    //            IMessage email = new Email();
    //            Notification n1 = new Notification(email);
    //            n1.Notify();

    //            IMessage sms = new SMS();
    //            Notification n2 = new Notification(sms);
    //            n2.Notify();

    //        }
    //    }
    //}
    #endregion

    //======================================================
    #region Async 
    internal class Program
    {
        // static void Main(string[] args)
        //{
        //    Console.WriteLine("Hello!");
        //}

        //static async Task Main(string[] args)
        //{
        //    Console.WriteLine("Start");
        //    await Task.Delay(3000);
        //    Console.WriteLine("End");
        //}

        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello before method");
            string num = await GetNumber();
            Console.WriteLine(num);
            Console.WriteLine("Hello after method");
        }
        static async Task<string> GetNumber()
        {
            await Task.Delay(2000);
            return "Hello From Async Method";
        }
    
    }
    #endregion
}
