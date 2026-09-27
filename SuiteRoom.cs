public class SuiteRoom : Room
{
    public SuiteRoom(
        int id,
        string roomNumber,
        int capacity,
        decimal pricePerNight)
        : base(id, roomNumber, capacity, pricePerNight)
    {
    }

    public override decimal CalculatePrice(int nights)
    {
        decimal price = base.CalculatePrice(nights);

        return price * 1.50m;
    }
}