namespace Mestami.Infrastructure.Requests
{
    public class CreateNewLoungeBarRequest
    {
        public string Title { get; set; }

        public string Address { get; set; }

        public string ApproxPrice { get; set; }

        public string Pros { get; set; }

        public string Cons { get; set; }

        public string Quality { get; set; }

        public string VipRoomInfo { get; set; }

        public bool IsTest { get; set; }
    }
}
