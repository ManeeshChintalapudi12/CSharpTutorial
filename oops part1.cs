// // OOPS - Inheritance, Polymorphism //
// class Car
// {
//     private string color;
//     private int maxSpeed;

//     public string Color
//     {
//         get { return this.color; }
//         set { this.color = value; }
//     }

//     public int MaxSpeed
//     {
//         get { return this.maxSpeed; }
//         set { this.maxSpeed = value; }
//     }

//     public virtual void Describe()
//     {
//         Console.WriteLine($"Car: Color = {this.color}, Max Speed = {this.maxSpeed} km/h");
//     }
// }

// class SportsCar : Car
// {
//     public override void Describe()
//     {
//         Console.WriteLine($"SportsCar: Color = {this.Color}, Max Speed = {this.MaxSpeed} km/h (Overridden)");
//     }
// }

// class ClassMembers
// {
//     public static void MyObject()
//     {
//         Car myCar = new Car();
//         myCar.Color = "Blue";
//         myCar.MaxSpeed = 180;

//         SportsCar mySportsCar = new SportsCar();
//         mySportsCar.Color = "Red";
//         mySportsCar.MaxSpeed = 320;

//         // Polymorphism
//         Car[] cars = { myCar, mySportsCar };

//         foreach (Car car in cars)
//         {
//             car.Describe();
//         }
//     }
// }