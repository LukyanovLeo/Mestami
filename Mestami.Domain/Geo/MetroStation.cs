namespace Mestami.Domain.Models.Geo
{
    public class MetroStation
    {
        public int Id { get; private set; }

        public int MteroLineId { get; private set; }

        public string Name { get; private set; }


        public MetroStation(int id, int metroLineId, string name)
        {
            Id = id;
            MteroLineId = metroLineId;
            Name = name;
        }
    }
}
