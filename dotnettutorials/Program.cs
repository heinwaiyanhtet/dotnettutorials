using System;
using System.Collections.Generic;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {

        Comparison<int> comparison = (x, y) => x.CompareTo(y);
List<int> numbers = new List<int> { 3, 1, 2 };
numbers.Sort(comparison); // Sorts numbers in ascending order

    Console.WriteLine(comparison);

        // List<Person> people = new List<Person>
        // {
        //     new Person { Name = "Alice", Age = 30 },
        //     new Person { Name = "Bob", Age = 25 },
        //     new Person { Name = "Charlie", Age = 35 }
        // };

        // // Sorting by Age using Comparison<T> delegate
        // people.Sort((x, y) => x.Age.CompareTo(y.Age));

        // foreach (var person in people)
        // {
        //     Console.WriteLine($"{person.Name}, {person.Age}");
        // }
    }
}






// namespace MainProgam
// {
//     class Program 
//     {    
//         static void Main(string[] args)
//         {



//             Console.WriteLine("Generic Method Example in C#");

//             GenericClass<string> myGenericClass = new GenericClass<string>
//             {
//                 Message = "Welcome to DotNetTutorials"
//             };

//             myGenericClass.GenericMethod("Pranata Rout", "Bhubaneswar");

//             Console.ReadLine();




            // MyGenricClass<int> integerGenericClass = new MyGenricClass<int>(10);

            // int val = integerGenericClass.GenericMethod(200);

            // Console.WriteLine(val);

            // Console.ReadKey();








            // method overloading testing

            // bool isEqual = CalsCalculator.Equals(10.5,10.5);

            // if(isEqual)
            // {
            //     Console.WriteLine("Both are equal");
            // }

            // else
            // {
            //     Console.WriteLine("Both are not equal");
            // }

            // Console.ReadKey();

            // bool isEqual = CalsCalculator.AreEqual(20, 20);





//         }
//     }
// }
















// using System;
// using System.Buffers;
// using System.Collections;
// namespace ArayDemo
// {

 
    // public abstract class shape
    // {
    //     public abstract double CalculateArea();
    //     public void Display() => Console.WriteLine("Displaying shape...");
    // }


    // public class Circle : shape
    // {
    //     private double radius;

    //     public Circle(double radius)
    //     {
    //         this.radius = radius;
    //     }

    //     public override double CalculateArea()
    //     {
    //         return Math.PI * radius * radius;
    //     }
    // }

    // public class Rectangle : shape
    // {
    //     public double Width { get; set; }
    //     public double Height { get; set; }

    //     // Implementing the abstract method
    //     public override double CalculateArea() => Width * Height;
    // }


    // Generics in C#

    // class Program
    // {   
    //     static void Main(string[] args)
    //     {

            
                // bool isEqual = CalsCalculator.AreEqual(20,20);

                // if (isEqual)
                // {
                //     Console.WriteLine("Both are Equal");
                // }
                // else
                // {
                //     Console.WriteLine("Both are Not Equal");
                // }

                // Console.ReadKey();


                // to test queue data structure
            //    Queue queue = new Queue();

            //    queue.Enqueue(101);
            //    queue.Enqueue("Hello");
            //    queue.Enqueue(3.14f);
            //    queue.Enqueue(true);
            //    queue.Enqueue(67.8);
            //    queue.Enqueue('A');   


            //    foreach (var item in queue)
            //    {
            //         Console.WriteLine(item);
            //    }

            //     // Console.ReadKey();

            // Console.WriteLine($"\n\nDeleted Element: {queue.Dequeue()}");

            // //Printing item after removing the first added item
            // Console.WriteLine($"\nAll Queue Elements After Deletion: Count {queue.Count}");


            // Console.WriteLine($"First Element of Queue is {queue.Peek()}");
            // Console.WriteLine($"Total Elements present in Queue : {queue.Count}");
            // Console.ReadKey();


          


//         int[,] NumbersArray = {{11,12,13,14},
//                           {21,22,23,24},
//                           {31,32,33,34}};

//         Console.WriteLine("Printing Array Elements using ForEach loop");

//         foreach (var i in NumbersArray)
//         {
//             Console.Write(i + " ");
//         }

//         Console.WriteLine("\n\nPrinting Array Elements using Nested For Loop");


//         for (int i = 0; i < NumbersArray.GetLength(0); i++)
//         {
//             for (int j = 0; j < NumbersArray.GetLength(1); j++)
//             {
//                 Console.Write(NumbersArray[i, j] + " ");
//             }
//         }




// Console.ReadKey();







        //     int[] Numbers = { 17, 23, 4, 59, 27, 36, 96, 9, 1, 3 };

        //     Console.WriteLine("Original Array Elements :");

        //      for (int i = 0; i < Numbers.Length; i++)
        //     {
        //         Console.Write(Numbers[i] + " ");
        //     }

        //     Console.WriteLine();

        //     Array.Sort(Numbers);

        //     Console.WriteLine("\nArray Elements After Sorting :");

        //    foreach (int i in Numbers)
        //     {
        //         Console.Write(i + " ");
        //     }

        //     Console.WriteLine();

        //     Array.Reverse(Numbers);

        //     Console.WriteLine("\nArray Elements in the Reverse Order :");

        //     foreach (int i in Numbers)
        //     {
        //         Console.Write(i + " ");
        //     }

        //     Console.WriteLine();

        //     Array.Reverse(Numbers);

        //     Console.WriteLine("\nArray Elements in the Reverse Order :");

        //     foreach (int i in Numbers)
        //     {
        //         Console.Write(i + " ");
        //     }
        //     Console.WriteLine();

        //      int[] NewNumbers = new int[10];

        //      Array.Copy(Numbers, NewNumbers, 5);

        //      Console.WriteLine("\nNew Array Elements :");

        //     foreach (int i in NewNumbers)
        //     {
        //         Console.Write(i + " ");
        //     }


        //     Console.WriteLine();

        //     Console.WriteLine($"\nNew Array Length using Length Property :{NewNumbers.Length}");

        //     Console.WriteLine($"New Array Length using GetLength Method :{NewNumbers.GetLength(0)}");

        //     Console.ReadKey();











          





          
            // int[] Numbers = new int[3];

            // Console.WriteLine("Accessing the Array Elements Before Initialization");
            // for (int i = 0; i <= Numbers.Length - 1; i++)
            // {
            //     Console.WriteLine($"Numbers[{i}] = {Numbers[i]}");
            // }

            // Numbers[0] = 10;
            // Numbers[1] = 20;
            // Numbers[2] = 30;

            // Console.WriteLine("\nAccessing the Array Elements After Initialization");
            // for (int i = 0; i <= Numbers.Length - 1; i++)
            // {
            //     Console.WriteLine($"Numbers[{i}] = {Numbers[i]}");
            // }
            
            // Console.ReadKey();



//         }
//     }

//     public class CalsCalculator
//     {
//         public static bool AreEqual(int value1,int value2)
//         {
//                 return  value1 == value2;
//         }
//     }
// }




