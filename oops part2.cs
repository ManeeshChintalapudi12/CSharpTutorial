// // OOPS - Abstraction, Interface //
// interface IVehicle
// {
//     void DisplayDetails();
// }

// abstract class Vehicle : IVehicle
// {

//     public string Color { get; set; }
//     public int MaxSpeed { get; set; }

//     public Vehicle(string color, int maxSpeed)
//     {
//         this.Color = color;
//         this.MaxSpeed = maxSpeed;
//     }

 
//     public abstract void DisplayDetails();
// }

// class Car : Vehicle
// {
//     public Car(string color, int maxSpeed) : base(color, maxSpeed) { }

//     public override void DisplayDetails()
//     {
//         Console.WriteLine($"Color: {this.Color}");
//         Console.WriteLine($"Max Speed: {this.MaxSpeed} km/h");
//     }
// }

// class ClassMembers
// {
//     public static void MyObject()
//     {
//         Car myCar = new Car("Blue", 220);
//         myCar.DisplayDetails();
//     }
// }