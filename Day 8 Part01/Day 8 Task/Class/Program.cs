using System;
using Day_8_Task.Interface;
using Day_8_Task;
using Day_8_Task.Abstract;
using Day_8_Task.Class;

public class Program
{
    public static void Main(string[] args)
    {
        #region Problem 1
        //IVehicle car = new Car();
        //IVehicle bike = new Bike();
        //car.StartEngine();
        //car.StopEngine();
        //bike.StartEngine();
        //bike.StopEngine();

        //// Question: Why is it better to code against an interface rather than a concrete class? 
        //// Coding against an interface promotes flexibility and decoupling because you can swap implementations
        //// without changing the code that uses the interface.
        #endregion

        #region Problem 2
        //Shape rectangle = new Rectangle(7, 14);
        //Shape circle = new Circle(6);

        //rectangle.Display();
        //Console.WriteLine($"Area of Rectangle: {rectangle.GetArea()}");

        //circle.Display();
        //Console.WriteLine($"Area of Circle: {circle.GetArea()}");

        ////Question: When should you prefer an abstract class over an interface?  
        ////Shared Code: Use an abstract class when you have shared code that can be reused by multiple derived classes.
        ////Default Behavior: Abstract classes can provide default behavior, whereas interfaces cannot(unless using default interface methods in C# 8.0+).
        ////Versioning: Abstract classes can be easier to evolve without breaking existing implementations.
        #endregion

        #region Problem 3
        //Product[] products = {
        //    new Product { Id = 1, Name = "Product A", Price = 10.0m },
        //    new Product { Id = 2, Name = "Product B", Price = 5.0m },
        //    new Product { Id = 3, Name = "Product C", Price = 20.0m }
        //};

        //Array.Sort(products);

        //foreach (var product in products)
        //{
        //    Console.WriteLine($"{product.Name}: {product.Price}");
        //}

        ////Question: How does implementing IComparable improve flexibility in sorting?  
        ////Implementing IComparable allows objects to define their own comparison logic, making sorting more intuitive and reusable.
        #endregion

        #region Problem 4
        //Student original = new Student(1, "Nour Tamer", 99.5);
        //Student copy = new Student(original);

        //Console.WriteLine($"Original: {original.Name}, {original.Grade}");
        //Console.WriteLine($"Copy: {copy.Name}, {copy.Grade}");

        ////Question: What is the primary purpose of a copy constructor in C#? 
        ////Deep Copy: To create a new instance of a class that is a deep copy of an existing instance, ensuring that changes to the new instance do not affect the original.
        #endregion

        #region Problem 5
        //Robot robot = new Robot();
        //IWalkable walkableRobot = robot;

        //robot.Walk();
        //walkableRobot.Walk();

        ////Question: How does explicit interface implementation help in resolving naming conflicts?   
        //// Explicit interface implementation resolves naming conflicts by separating interface methods from class methods.
        #endregion

        #region Problem 6
        //Account account = new Account
        //{
        //    AccountId = 1,
        //    AccountHolder = "Nour Tamer",
        //    Balance = 1000.0m
        //};
        //Console.WriteLine($"Account Holder: {account.AccountHolder}, Balance: {account.Balance}");

        ////Question: What is the key difference between encapsulation in structs and classes?
        ////Encapsulation in structs is similar to classes but structs are value types, leading to differences in memory management.

        ////Question: what is abstraction as a guideline, what’s its relation with encapsulation ?
        //// Abstraction hides implementation details (guideline), while encapsulation restricts direct access to data.
        #endregion,

        #region Problem 7 Bonus
        //ILogger logger = new ConsoleLogger();
        //logger.Log();

        ////Question: How do default interface implementations affect backward compatibility in C#? 
        ////Backward Compatibility: They allow new methods to be added to interfaces without breaking existing implementations, providing a default behavior that existing classes can inherit.
        #endregion

        #region Problem 8
        //Book book1 = new Book();
        //Book book2 = new Book("C# & SQL");
        //Book book3 = new Book("C# & SQL", "Nour Tamer");

        //Console.WriteLine($"Book1: {book1.Title}, {book1.Author}");
        //Console.WriteLine($"Book2: {book2.Title}, {book2.Author}");
        //Console.WriteLine($"Book3: {book3.Title}, {book3.Author}");

        ////Question: How does constructor overloading improve class usability?  
        ////Constructor overloading enhances class usability by providing multiple ways to initialize objects.
        #endregion
    }
}