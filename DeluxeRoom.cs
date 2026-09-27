public class DeluxeRoom : Room
{
    public DeluxeRoom(
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

        return price * 1.30m;
    }
}