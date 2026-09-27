public interface IRoom
{
    decimal CalculatePrice(int nights);

    void CheckIn(string guestName);

    void CheckOut();
}