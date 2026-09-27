public class StandardRoom : Room
{
    public StandardRoom(
        int id,
        string roomNumber,
        int capacity,
        decimal pricePerNight)
        : base(id, roomNumber, capacity, pricePerNight)
    {
    }

    public override decimal CalculatePrice(int nights)
    {
        return base.CalculatePrice(nights);
    }
}