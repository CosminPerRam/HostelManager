using System.Text.Json;

namespace HotelMan
{
    public class Customer
    {
        public string name;

        public Customer(string name) {
            this.name = name;
        }

        public Customer()
        {

        }
    }

    public class Room
    {
        public string id;
        public uint capacity;
        public uint luxuryRate;
        public List<Customer> occupants;

        public Room(string id, uint capacity, uint luxuryRate) {
            this.id = id;
            this.capacity = capacity;
            this.luxuryRate = luxuryRate;
        }

        public Room() { }
    }

    public class Rate
    {
        public uint perNight;
        public uint luxuryRate;

        public Rate(uint perNight, uint luxuryRate)
        {
            this.perNight = perNight;
            this.luxuryRate = luxuryRate;
        }

        public Rate()
        {

        }
    }

    public class Hotel
    {
        public List<List<Room>> rooms;
        public List<Rate> rates;
        public string name;

        public Hotel() { }

        public TreeNode asTree()
        {
            TreeNode hotel = new TreeNode(name);

            for (int level = 0; level < rooms.Count; level++)
            {
                TreeNode currentLevel = hotel.Nodes.Add($"L{level}", $"Floor {level}");
                foreach (Room room in rooms[level])
                {
                    TreeNode currentRoom = currentLevel.Nodes.Add($"R{room.id}", $"Room ${room.id}");
                    foreach (Customer customer in room.occupants)
                    {
                        currentRoom.Nodes.Add($"O{customer.name}", customer.name);
                    }
                }
            }

            return hotel;
        }

        public void erase()
        {
            rooms.Clear();
            rates.Clear();
        }
    }
}
