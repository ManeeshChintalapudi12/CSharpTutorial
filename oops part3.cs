// // OOPS - Enums, Files //
// enum CarType
// {
//     Sedan,
//     SUV,
//     Truck,
//     Coupe
// }

// class Car
// {
 
//     public string Color { get; set; }
//     public int MaxSpeed { get; set; }
//     public CarType Type { get; set; }

//     public Car(string color, int maxSpeed, CarType type)
//     {
//         Color = color;
//         MaxSpeed = maxSpeed;
//         Type = type;
//     }

//     public void SaveToFile(string filePath)
//     {
//         string data = $"Color: {Color}, Max Speed: {MaxSpeed}, Type: {Type}";
//         File.WriteAllText(filePath, data);
//     }

   
//     public static void ReadFromFile(string filePath)
//     {
//         if (File.Exists(filePath))
//         {
//             string content = File.ReadAllText(filePath);
//             Console.WriteLine("Car info from file:");
//             Console.WriteLine(content);
//         }
//         else
//         {
//             Console.WriteLine("File not found.");
//         }
//     }
// }

// class ClassMembers
// {
//     public static void MyObject()
//     {
        
//         Car myCar = new Car("Blue", 220, CarType.SUV);

//         string filePath = "carinfo.txt";

//         myCar.SaveToFile(filePath);     // Save to file
//         Car.ReadFromFile(filePath);     // Read from file
//     }
// }