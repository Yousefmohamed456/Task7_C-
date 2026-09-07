using System;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;

namespace task7
{   
    internal class Program
    {
        static void Main()
        {
            #region P1
            //Car car1 = new Car();
            //Car car2 = new Car(1);
            //Car car3 = new Car(2, "BMW");
            //Car car4 = new Car(3, "Mercedes", 50000);

            //Console.WriteLine($"{car1.Id}, {car1.Brand}, {car1.Price}");
            //Console.WriteLine($"{car2.Id}, {car2.Brand}, {car2.Price}");
            //Console.WriteLine($"{car3.Id}, {car3.Brand}, {car3.Price}");
            //Console.WriteLine($"{car4.Id}, {car4.Brand}, {car4.Price}");

            //Q1:
            //the compiler automatically provides a parameterless (default) constructor only if you don't define any constructor yourself.

            #endregion
            #region P2
            //Calculator calculator = new Calculator();
            //Console.WriteLine(calculator.Sum(10, 20));
            //Console.WriteLine(calculator.Sum(10, 20, 30));
            //Console.WriteLine(calculator.Sum(10.5, 20.5));
            //Q2:
            //Method overloading improves code readability and reusability by
            //allowing multiple methods to have the same name but different parameter lists.
            #endregion
            #region P3
            //Child child = new Child(10, 20, 30); 
            //Console.WriteLine($"X = {child.X}");
            //Console.WriteLine($"Y = {child.Y}"); 
            //Console.WriteLine($"Z = {child.Z}");
            //Q3:
            //Constructor chaining in inheritance is used to ensure that the constructor of the base class is executed before the constructor of the derived class.
            #endregion
            #region P4
            //Parent p1 = new ChildNew(2, 3, 4);
            //Console.WriteLine(p1.Product());

            //ChildNew c1 = new ChildNew(2, 3, 4);
            //Console.WriteLine(c1.Product());

            //Parent p2 = new ChildOverride(2, 3, 4);
            //Console.WriteLine(p2.Product());
            //Q4:
            //override replaces the behavior of a virtual or abstract base method and supports polymorphism. 
            //new hides the base method, 
            //so the method called depends on the reference type rather than the actual object type.
            #endregion
            #region P5
            //Parent parent = new Parent(10, 20); 
            //Parent child = new Child(10, 20, 30);
            //Console.WriteLine(parent); 
            //Console.WriteLine(child);
            //Q5:
            //ToString() is often overridden in custom classes because the default usually returns the class name
            //which doesn't provide useful information about the object.
            #endregion

            #endregion
        }
    }
}
