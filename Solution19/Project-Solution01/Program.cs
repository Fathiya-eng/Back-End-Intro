namespace Project_Solution01
{
    internal class Program
    {
        #region Polymophism
        //========================
        // Polymophism
        //========================

        //class Animals
        //{
        //    public void Sleep()
        //    {
        //        Console.WriteLine("Animal is sleeping");
        //    }
        //    public virtual void Sound()
        //    {
        //        Console.WriteLine("The animal makes a sound");
        //    }
        //    public virtual void Eat()
        //    {
        //        Console.WriteLine("Animal is eating");
        //    }

        //}

        //class Dog : Animals
        //{
        //    public override void Sound()
        //    {
        //        Console.WriteLine("Dog sounds Barking");
        //    }

        //    public override void Eat()
        //    {
        //        Console.WriteLine("Dog eats Meats");
        //    }
        //}

        //static void Main(string[] args)
        //{
        //    Dog dog = new Dog();

        //    dog.Sound();
        //    dog.Eat();

        //    dog.Sleep();
        //} 
        #endregion
        //===================================================================================

        #region Rnu Time Polymophism
        //========================
        // Rnu Time Polymophism
        //========================

        class Shape
        {
            public virtual void Drow()
            {
                Console.WriteLine("Drowing Shape");
            }

        }

        class Circle : Shape
        {
            public override void Drow()
            {
                Console.WriteLine("Drowing Circle");
            }

        }

        class Rectangular : Shape
        {
            public override void Drow()
            {
                Console.WriteLine("Drowing Rectangular");
            }

        }

        static void Main(string[] args)
        {
            Shape s1 = new Circle();
            Shape s2 = new Rectangular();
            s1.Drow();
            s2.Drow();

        } 
        #endregion
        //===================================================================================






    }
}
