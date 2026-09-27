public class RoomService
{
    private List<Room> rooms = new List<Room>();

    
    public void AddRoom(Room room)
    {
        foreach (Room item in rooms)
        {
            if (item.Id == room.Id)
                throw new Exception("Ин Id аллакай вуҷуд дорад.");

            if (item.RoomNumber == room.RoomNumber)
                throw new Exception("Ин RoomNumber аллакай вуҷуд дорад.");
        }

        rooms.Add(room);
    }

    public List<Room> GetAllRooms()
    {
        return rooms;
    }


    public Room GetRoom(int id)
    {
        foreach (Room room in rooms)
        {
            if (room.Id == id)
                return room;
        }

        throw new Exception("Утоқ ёфт нашуд.");
    }

    public void UpdateRoom(
        int id,
        decimal pricePerNight,
        int capacity)
    {
        Room room = GetRoom(id);

        room.Update(pricePerNight, capacity);
    }

    public void DeleteRoom(int id)
    {
        Room room = GetRoom(id);

        if (!room.IsAvailable)
            throw new Exception(
                "Утоқи бандро нест кардан мумкин нест.");

        rooms.Remove(room);
    }
    public void CheckIn(int id, string guestName)
    {
        Room room = GetRoom(id);

        room.CheckIn(guestName);
    }
    public void CheckOut(int id)
    {
        Room room = GetRoom(id);

        room.CheckOut();
    }

    public decimal CalculatePrice(int id, int nights)
    {
        Room room = GetRoom(id);

        return room.CalculatePrice(nights);
    }
}