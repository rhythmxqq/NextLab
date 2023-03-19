using CarsChek;

namespace CarsChek
{
    public class Car
    {
        public string Model { get; set; }
        public string Color { get; set; }
    }

    public class Garage
    {
        private List<Car> cars = new List<Car>();

        public void AddCar(Car car)
        {
            cars.Add(car);
        }

        
        public void WashAllCars(Washer washer)
        {
            foreach (Car car in cars)
            {
                washer.Wash(car);
            }
        }
    }


    public class Washer
    {
        public void Wash(Car car)
        {
            Console.WriteLine($"Моем автомобиль {car.Model}, цвет {car.Color}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
       
        Car car1 = new Car { Model = "BMW E34", Color = "Серый" };
        Car car2 = new Car { Model = "BMW E46", Color = "Темно-синий" };
        Car car3 = new Car { Model = "BMW F50", Color = "Черный" };

     
        Garage garage = new Garage();
        garage.AddCar(car1);
        garage.AddCar(car2);
        garage.AddCar(car3);

        
        Washer washer = new Washer();

        
        garage.WashAllCars(washer);

    }
}