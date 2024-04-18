namespace ConsoleApp1;

public class ParkingManager
{
    private ParkingLot parkingLot;

    public ParkingManager(int capacity)
    {
        parkingLot = new ParkingLot(capacity);
    }

    public bool CheckIn(Vehicle vehicle, int slotNumber)
    {
        if (parkingLot.ParkVehicle(slotNumber))
        {
            Console.WriteLine($"Allocated slot number: {slotNumber}");
            return true;
        }
        else
        {
            Console.WriteLine("Parking slot is not available.");
            return false;
        }
    }

    public bool CheckOut(int slotNumber)
    {
        if (parkingLot.LeaveVehicle(slotNumber))
        {
            Console.WriteLine($"Slot number {slotNumber} is free.");
            return true;
        }
        else
        {
            Console.WriteLine("Slot number is not occupied.");
            return false;
        }
    }

    public void GenerateReport()
    {
        Console.WriteLine($"Available slots: {parkingLot.AvailableSlots}");
    }
}