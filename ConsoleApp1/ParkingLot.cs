namespace ConsoleApp1;

public class ParkingLot
{
    public int Capacity { get; }
    public int AvailableSlots { get; private set; }
    private HashSet<int> occupiedSlots;

    public ParkingLot(int capacity)
    {
        Capacity = capacity;
        AvailableSlots = capacity;
        occupiedSlots = new HashSet<int>();
    }

    public bool ParkVehicle(int slotNumber)
    {
        if (slotNumber <= 0 || slotNumber > Capacity || occupiedSlots.Contains(slotNumber))
        {
            return false;
        }

        occupiedSlots.Add(slotNumber);
        AvailableSlots--;
        return true;
    }

    public bool LeaveVehicle(int slotNumber)
    {
        if (!occupiedSlots.Contains(slotNumber))
        {
            return false;
        }

        occupiedSlots.Remove(slotNumber);
        AvailableSlots++;
        return true;
    }
}