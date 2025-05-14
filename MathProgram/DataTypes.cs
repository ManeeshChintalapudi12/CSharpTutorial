// Datatypes - Int, Float, Long, Double // 
// class Datatypes
//   {
//     public static void Number()
//     {
//       int myNum = 100000;
//       long x = 15000000000L;
//       float f1 = 5.75F;
//       double d1 = 19.99D;
//       Console.WriteLine(d1);
//       Console.WriteLine(f1);
//       Console.WriteLine(myNum);
//       Console.WriteLine(x);
//     }
//   }

// Datatypes -Strings, Char, Boolean //

// class Datatypes
// {
//     public static void Names()
//     {
//         string greeting = "Hello World";
//         char myGrade = 'B';
//         bool isCSharpFun = true;
//         bool isFishTasty = false;
//         Console.WriteLine(isCSharpFun); 
//         Console.WriteLine(isFishTasty);  
//         Console.WriteLine(myGrade);
//         Console.WriteLine(greeting);
//     }
// }

// TypeCasting - Implict(small to Big)

// class TypeCasting
// {
//     public static void Number()
//     {
//         int myInt = 9;
//         double myDouble = myInt;    
//         Console.WriteLine(myInt);     
//         Console.WriteLine(myDouble); 
//     }
// }

// TypeCasting - Explict(Big to Small)

//  class TypeCasting
// {
//     public static void Number()
//     {
//       double myDouble = 9.78;
//       int myInt = (int) myDouble;   
//       Console.WriteLine(myDouble);  
//       Console.WriteLine(myInt); 
//     }
// }

// User Inputs //

// class UserInputs
// {
//     public static void Age()
//     {
//         Console.WriteLine("Enter your age:");
//         int age = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine("Your age is: " + age);
//     }
// }

// Conditional Statment- If, Else, Elif //

// class Conditional
// {
//     public static void Statment()
//     {
//         int time = 22;
//         if (time < 10)
//         {
//             Console.WriteLine("Good morning.");
//         }
//         else if (time < 20)
//         {
//             Console.WriteLine("Good day.");
//         }
//         else
//         {
//             Console.WriteLine("Good evening.");
//         }
//     }
// }

// Switch //
// class Switch
// {
//     public static void Statment()
//     {
//         int day = 4;
//         switch (day)
//         {
//             case 1:
//                 Console.WriteLine("Monday");
//                 break;
//             case 2:
//                 Console.WriteLine("Tuesday");
//                 break;
//             case 3:
//                 Console.WriteLine("Wednesday");
//                 break;
//             case 4:
//                 Console.WriteLine("Thursday");
//                 break;
//             case 5:
//                 Console.WriteLine("Friday");
//                 break;
//             case 6:
//                 Console.WriteLine("Saturday");
//                 break;
//             case 7:
//                 Console.WriteLine("Sunday");
//                 break;
//         }
//     }
// }

// Loops with Break And Continue //

// While with Continue //
// class Loops
// {
//     public static void code()
//     {
//         int i = 0;
//         while (i < 10)
//         {
//             if (i == 4)
//             {
//                 i++;
//                 continue;
//             }
//             Console.WriteLine(i);
//             i++;
//         }
//     }
// }

// While with Break//
// class Loops
// {
//     public static void code()
//     {
//         int i = 0;
//         while (i < 10)
//         {
//             Console.WriteLine(i);
//             i++;
//             if (i == 4)
//             {
//                 break;
//             }
//         }
//     }
// }

// For with Break //
// class Loops
// {
//     public static void code()
//     {
//         for (int i = 0; i < 10; i++)
//         {
//             if (i == 4)
//             {
//                 break;
//             }
//             Console.WriteLine(i);
//         }
//     }
// }

// For with Continue //
// class Loops
// {
//     public static void code()
//     {
//         for (int i = 0; i < 10; i++)
//         {
//             if (i == 4)
//             {
//                 continue;
//             }
//             Console.WriteLine(i);
//         }
//     }
// }

// // Arrays //
// class Arrays
// {
//     public static void Elements()
//     {
//         string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
//         for (int i = 0; i<cars.Length; i++) 
//         {
//             Console.WriteLine(cars[i]);
//         }
//     }
// }