using ConsoleApp1;

public class Program
{
    public static void Main(string[] args)
    {
        ParkingManager parkingManager = null;

        while (true)
        {
            Console.WriteLine("Enter command:");
            string input = Console.ReadLine();
            string[] tokens = input.Split(' ');

            switch (tokens[0])
            {
                case "create_parking_lot":
                    int capacity = int.Parse(tokens[1]);
                    parkingManager = new ParkingManager(capacity);
                    Console.WriteLine($"Created a parking lot with {capacity} slots");
                    break;

                case "park":
                    if (parkingManager == null)
                    {
                        Console.WriteLine("Please create parking lot first.");
                        break;
                    }
                    string licensePlate = tokens[1];
                    string color = tokens[2];
                    string type = tokens[3];
                    Vehicle vehicle = new Vehicle(licensePlate, color, type);
                    bool parked = parkingManager.CheckIn(vehicle, int.Parse(tokens[4]));
                    if (!parked)
                    {
                        Console.WriteLine("Vehicle cannot be parked.");
                    }
                    break;

                case "leave":
                    if (parkingManager == null)
                    {
                        Console.WriteLine("Please create parking lot first.");
                        break;
                    }
                    parkingManager.CheckOut(int.Parse(tokens[1]));
                    break;

                case "report":
                    if (parkingManager == null)
                    {
                        Console.WriteLine("Please create parking lot first.");
                        break;
                    }
                    parkingManager.GenerateReport();
                    break;

                case "exit":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }
        }
    }
}