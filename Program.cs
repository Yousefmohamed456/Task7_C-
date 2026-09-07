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
            #region P6
            //Rectangle rectangle = new Rectangle(); 
            //rectangle.Width = 10; rectangle.Height = 5; 
            //Console.WriteLine($"Area = {rectangle.Area}"); 
            //rectangle.Draw();
            //Q6:You cannot create an instance of an interface directly because an interface only defines a contract—it specifies what members a class must provide
            //but it doesn't provide a complete implementation or object itself.
            #endregion
            #region P7
            //Circle circle = new Circle(); 
            //circle.Radius = 5; 
            //IShape shape = circle; 
            //shape.PrintDetails();
            //Q7:
            //Default interface implementations allow interfaces to provide method implementations.
            //They improve code reuse, maintain backward compatibility when adding new members to interfaces 
            //and reduce the need for duplicate implementations in classes.
            #endregion
            #region P8
            //IMovable movable = new Car1(); 
            //movable.Move();
            //Q8:
            //Using an interface reference allows code to work with different implementing classes through a common contract.
            //This provides polymorphismflexibility and loose coupling, making the code easier to maintain and extend.
            #endregion
            #region P9
            //File file = new File(); 
            //file.Read(); 
            //file.Write(); 
            //IReadable readable = file; 
            //readable.Read(); 
            //IWritable writable = file; 
            //writable.Write();
            //Q9:
            //C# overcomes the single-inheritance limitation by allowing a class to implement multiple interfaces. 
            //A class can inherit from one base class while implementing any number of interfaces, 
            //giving it multiple behaviors or contracts.
            #endregion
            #region P10
            //Rectangle1 rectangle = new Rectangle1(); 
            //rectangle.Width = 10; 
            //rectangle.Height = 5; 
            //rectangle.Draw(); 
            //Console.WriteLine($"Area = {rectangle.CalculateArea()}"); 
            //Shape shape = new Rectangle1(); 
            //shape.Draw(); 
            //Console.WriteLine($"Area = {shape.CalculateArea()}");
            //Q10:
            //A virtual method provides a default implementation that a derived class can optionally override
            //while an abstract method has no implementation and must be overridden by a derived class
            //Abstract methods can only be declared inside an abstract class.
            #endregion
        }
    }
}
