using System.Text.Json;

namespace HotelMan
{
    public partial class MainForm : Form
    {
        public Hotel hotel;

        private int selectedRate;
        private TreeNode? selectedHotelNode;

        public MainForm()
        {
            hotel = new Hotel();
            InitializeComponent();
        }

        public void ReloadData()
        {
            hotelView.Nodes.Clear();
            hotelView.Nodes.Add(hotel.asTree());
            hotelView.ExpandAll();

            ratesList.Items.Clear();
            foreach (Rate rate in hotel.rates)
            {
                ListViewItem listViewItem = new ListViewItem(rate.luxuryRate.ToString());
                listViewItem.SubItems.Add(rate.perNight.ToString());
                string currentOccupants = hotel.rooms
                    .Sum(level => level
                        .Where(room => room.luxuryRate == rate.luxuryRate)
                        .Sum(room => room.occupants?.Count ?? 0))
                    .ToString();
                listViewItem.SubItems.Add(currentOccupants);
                ratesList.Items.Add(listViewItem);
            }

            int freeRooms = hotel.rooms.Sum(level => level.Where(room => room.occupants.Count == 0).Count());
            int occupants = hotel.rooms.Sum(level => level.Sum(room => room.occupants.Count));
            stats.Text = $"Free rooms: {freeRooms}\nOccupants: {occupants}";
        }

        private void toolStripLoad_Click(object sender, EventArgs e)
        {
            Hotel? nullableHotel = Utilities.Load<Hotel>();
            if (nullableHotel != null)
            {
                hotel = nullableHotel;
                ReloadData();
                exportStats.Enabled = true;
            }
        }

        private void toolStripSave_Click(object sender, EventArgs e)
        {
            Utilities.Save(hotel);
        }

        private void toolStripClear_Click(object sender, EventArgs e)
        {
            hotel.erase();
            ReloadData();
        }

        private void ratesList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                ratesRemove.Enabled = false;
                return;
            }

            ratesRemove.Enabled = true;
            selectedRate = e.ItemIndex;
        }

        private void ratesRemove_Click(object sender, EventArgs e)
        {
            hotel.rates.RemoveAt(selectedRate);
            ReloadData();

            if (hotel.rates.Count == 0)
            {
                ratesRemove.Enabled = false;
            }
        }

        private void hotelView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode? selectedNode = e.Node;
            occupantsRemove.Enabled = selectedNode != null;
            if (selectedNode != null)
            {
                selectedHotelNode = selectedNode;

                if (selectedNode.Parent == null)
                {
                    occupantsRemove.Enabled = false;
                }
            }
        }

        private void occupantsRemove_Click(object sender, EventArgs e)
        {
            string name = selectedHotelNode.Name;
            string identificator = name.Substring(1);
            switch (name.ElementAt(0))
            {
                case 'L':
                    hotel.rooms.RemoveAt(int.Parse(identificator));
                    break;
                case 'R':
                    foreach (List<Room> level in hotel.rooms)
                    {
                        Room? roomToRemove = level.FirstOrDefault(room => room.id == identificator);
                        if (roomToRemove != null)
                        {
                            level.Remove(roomToRemove);
                            break;
                        }
                    }
                    break;
                case 'O':
                    foreach (List<Room> level in hotel.rooms)
                    {
                        foreach (Room room in level)
                        {
                            Customer? occupantToEvict = room.occupants.FirstOrDefault(customer => customer.name == identificator);
                            if (occupantToEvict != null)
                            {
                                room.occupants.Remove(occupantToEvict);
                                break;
                            }
                        }
                    }
                    break;
                default:
                    break;
            }

            ReloadData();
        }

        private void exportStats_Click(object sender, EventArgs e)
        {
            Room[] freeRooms = hotel.rooms
                .SelectMany(level => level) // flat map
                .Where(room => room.occupants.Count == 0)
                .ToArray();

            Customer[] allCustomers = hotel.rooms
                .SelectMany(level => level)
                .SelectMany(room => room.occupants)
                .ToArray();

            Utilities.Save(new { freeRooms, allCustomers });
        }

        private void occupantsAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This isn't implemented yet.");
        }

        private void ratesAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This isn't implemented yet.");
        }
    }
}
