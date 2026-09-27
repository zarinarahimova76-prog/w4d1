//ClassTask
// using System.Runtime.CompilerServices;

// User user1 = new User()
// {
//     id = 1,
//     Name = "Zarina",
//     SurName = "Rahimova",

// };
// User user2 = new User()
// {
//     id = 2,
//     Name = "Ali",
//     SurName = "Valiev",

// };
// User user3 = new User()
// {
//     id = 3,
//     Name = "Vali",
//     SurName = "Sayvali",

// };

// UserService service = new UserService();

// service.AddUser(user1);
// service.AddUser(user2);
// service.AddUser(user3);

// var all=service.GetAll();
// foreach(var item in all)
// {
//     Console.WriteLine($"{item.Name} , {item.SurName} , {item.id}" );
// }

//HomeTask
RoomService service = new RoomService();

while (true)
{
    Console.WriteLine();
    Console.WriteLine("===== HOTEL =====");
    Console.WriteLine("1. Сохтани утоқ");
    Console.WriteLine("2. Рӯйхати утоқҳо");
    Console.WriteLine("3. Дидани утоқ");
    Console.WriteLine("4. Навсозии утоқ");
    Console.WriteLine("5. Нест кардани утоқ");
    Console.WriteLine("6. Ҷойгир кардани меҳмон");
    Console.WriteLine("7. Баровардани меҳмон");
    Console.WriteLine("8. Ҳисоб кардани арзиш");
    Console.WriteLine("0. Баромад");

    Console.Write("Интихоб: ");
    int choice = Convert.ToInt32(Console.ReadLine());

    try
    {
        if (choice == 1)
        {
            Console.Write("Id: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Room Number: ");
            string roomNumber = Console.ReadLine();

            Console.Write("Capacity: ");
            int capacity = Convert.ToInt32(Console.ReadLine());

            Console.Write("Price per night: ");
            decimal price = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("1 - Standard");
            Console.WriteLine("2 - Deluxe");
            Console.WriteLine("3 - Suite");

            Console.Write("Намуди утоқ: ");
            int type = Convert.ToInt32(Console.ReadLine());

            Room room;

            if (type == 1)
            {
                room = new StandardRoom(
                    id,
                    roomNumber,
                    capacity,
                    price);
            }
            else if (type == 2)
            {
                room = new DeluxeRoom(
                    id,
                    roomNumber,
                    capacity,
                    price);
            }
            else if (type == 3)
            {
                room = new SuiteRoom(
                    id,
                    roomNumber,
                    capacity,
                    price);
            }
            else
            {
                throw new Exception("Намуди утоқ нодуруст аст.");
            }

            service.AddRoom(room);

            Console.WriteLine("Утоқ бомуваффақият сохта шуд.");
        }

        else if (choice == 2)
        {
            List<Room> rooms = service.GetAllRooms();

            if (rooms.Count == 0)
            {
                Console.WriteLine("Ягон утоқ вуҷуд надорад.");
            }
            else
            {
                foreach (Room room in rooms)
                {
                    Console.WriteLine(
                        $"Id: {room.Id}, " +
                        $"Room: {room.RoomNumber}, " +
                        $"Capacity: {room.Capacity}, " +
                        $"Price: {room.PricePerNight}, " +
                        $"Available: {room.IsAvailable}");
                }
            }
        }

        else if (choice == 3)
        {
            Console.Write("Id: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Room room = service.GetRoom(id);

            Console.WriteLine($"Id: {room.Id}");
            Console.WriteLine($"Room Number: {room.RoomNumber}");
            Console.WriteLine($"Capacity: {room.Capacity}");
            Console.WriteLine($"Price: {room.PricePerNight}");
            Console.WriteLine($"Available: {room.IsAvailable}");
            Console.WriteLine($"Guest: {room.GuestName}");
        }

        else if (choice == 4)
        {
            Console.Write("Id: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("New price: ");
            decimal price = Convert.ToDecimal(Console.ReadLine());

            Console.Write("New capacity: ");
            int capacity = Convert.ToInt32(Console.ReadLine());

            service.UpdateRoom(id, price, capacity);

            Console.WriteLine("Утоқ навсозӣ шуд.");
        }

        else if (choice == 5)
        {
            Console.Write("Id: ");
            int id = Convert.ToInt32(Console.ReadLine());

            service.DeleteRoom(id);

            Console.WriteLine("Утоқ нест карда шуд.");
        }

        else if (choice == 6)
        {
            Console.Write("Id: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Номи меҳмон: ");
            string guestName = Console.ReadLine();

            service.CheckIn(id, guestName);

            Console.WriteLine("Меҳмон ҷойгир карда шуд.");
        }

        else if (choice == 7)
        {
            Console.Write("Id: ");
            int id = Convert.ToInt32(Console.ReadLine());

            service.CheckOut(id);

            Console.WriteLine("Меҳмон бароварда шуд.");
        }

        else if (choice == 8)
        {
            Console.Write("Id: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Шумораи шабҳо: ");
            int nights = Convert.ToInt32(Console.ReadLine());

            decimal total = service.CalculatePrice(id, nights);

            Console.WriteLine(
                $"Арзиши умумӣ: {total}");
        }

        else if (choice == 0)
        {
            break;
        }

        else
        {
            Console.WriteLine("Фармони нодуруст.");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Хато: {ex.Message}");
    }
}
