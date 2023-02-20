namespace Mestami.Infrastructure.DTO
{
    public class LoungeBarDTO
    {
        public int Id { get; private set; }

        public string Title { get; private set; }

        public string City { get; private set; }

        public string MetroStation { get; private set; }

        public string Address { get; private set; }

        public string ApproxPrice { get; private set; }

        public string Pros { get; private set; }

        public string Cons { get; private set; }

        public string Quality { get; private set; }

        public string VipRoomInfo { get; private set; }

        public bool IsTest { get; private set; } = false;
        

        public LoungeBarDTO(
            int id, 
            string title, 
            string city, 
            string address, 
            string approxPrice, 
            string pros, 
            string cons, 
            string quality, 
            string vipRoomInfo)
        {
            Id = id;
            Title = title;
            City = city;
            Address = address;
            ApproxPrice = approxPrice;
            Pros = pros;
            Cons = cons;
            Quality = quality;
            VipRoomInfo = vipRoomInfo;
        }
    }
}
