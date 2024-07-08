using System.Text.Json;

namespace Assignment10._1CreateClassSerialize_Deserialize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();  //created a distinct datatype to work with

            car1.Make = "Tesla";
            car1.Model = "ModelY";
            car1.Year = 2024;
            car1.IsElectric = true;
            car1.Price = 50000;

            string car1Json = JsonSerializer.Serialize(car1);

            Console.WriteLine("Serialized Car 1:");
            Console.WriteLine(car1Json);

            Console.WriteLine();

            Car deserializedCar1 = JsonSerializer.Deserialize<Car>(car1Json);
            Console.WriteLine("Deserialized Car 1:");
            Console.WriteLine($"Make: {deserializedCar1.Make}, Model: {deserializedCar1.Model}");

        }
    }
}

