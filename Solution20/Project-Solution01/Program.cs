namespace Project_Solution01
{
    internal class Program
    {
        #region Abstract: Animals
        //abstract class Animal()
        //{
        //    public abstract void sound();
        //    public abstract void Eat();
        //}

        //class Dog : Animal
        //{
        //    public override void sound()
        //    {
        //        Console.WriteLine("Barking");
        //    }
        //    public override void Eat()
        //    {
        //        Console.WriteLine("Meat");
        //    }

        //} 
        #endregion

        //======================================

        #region Abstract BankAcount
        //abstract class BankAcount()
        //{
        //    public abstract void Withdraw();

        //}

        //class Saving : BankAcount
        //{
        //    public override void Withdraw()
        //    {
        //        Console.WriteLine("Saving");
        //    }

        //}

        //class Current : BankAcount
        //{
        //    public override void Withdraw()
        //    {
        //        Console.WriteLine("Current");
        //    }

        //} 
        #endregion

        //=======================================

        #region Interface
        interface Bird
        {
            string Name { get; }
            public void Fly();
        }

        class Hodhod : Bird
        {
            public string Name { get; set; }
            public void Fly()
            {
                Console.WriteLine("Hello");
            }
        } 
        #endregion

        //=======================================

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
