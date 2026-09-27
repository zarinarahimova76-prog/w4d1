public class Room : IRoom
{
    public int Id { get; set; }

    public string RoomNumber { get; set; }

    public int Capacity { get; set; }

    public decimal PricePerNight { get; private set; }

    public bool IsAvailable { get; private set; }

    public string GuestName { get; private set; }

    public Room(int id, string roomNumber, int capacity, decimal pricePerNight)
    {
        if (id <= 0)
            throw new Exception("Id бояд аз 0 калон бошад.");

        if (string.IsNullOrWhiteSpace(roomNumber))
            throw new Exception("RoomNumber холӣ буда наметавонад.");

        if (capacity <= 0)
            throw new Exception("Capacity бояд аз 0 калон бошад.");

        if (pricePerNight <= 0)
            throw new Exception("PricePerNight бояд аз 0 калон бошад.");

        Id = id;
        RoomNumber = roomNumber;
        Capacity = capacity;
        PricePerNight = pricePerNight;

        IsAvailable = true;
        GuestName = "";
    }

    public virtual decimal CalculatePrice(int nights)
    {
        if (nights <= 0)
            throw new Exception("Шумораи шабҳо бояд аз 0 калон бошад.");

        return PricePerNight * nights;
    }

    public void CheckIn(string guestName)
    {
        if (!IsAvailable)
            throw new Exception("Утоқ аллакай банд аст.");

        if (string.IsNullOrWhiteSpace(guestName))
            throw new Exception("Номи меҳмон холӣ буда наметавонад.");

        IsAvailable = false;
        GuestName = guestName;
    }

    public void CheckOut()
    {
        if (IsAvailable)
            throw new Exception("Утоқ аллакай озод аст.");

        IsAvailable = true;
        GuestName = "";
    }

    public void Update(decimal pricePerNight, int capacity)
    {
        if (pricePerNight <= 0)
            throw new Exception("Нарх бояд аз 0 калон бошад.");

        if (capacity <= 0)
            throw new Exception("Capacity бояд аз 0 калон бошад.");

        PricePerNight = pricePerNight;
        Capacity = capacity;
    }
}