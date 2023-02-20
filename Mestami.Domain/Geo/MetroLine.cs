using Mestami.Domain.Models.Geo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mestami.Domain.Geo
{
    public class MetroLine
    {
        public int Id { get; private set; }

        public int CityId { get; private set; }

        public string Name { get; private set; }

        public string Color { get; private set; }

        public HashSet<MetroStation> MetroStations { get; private set; } = new HashSet<MetroStation>();


        public MetroLine(int id, int cityId, string name, string color, HashSet<MetroStation> metroStations)
        {
            Id = id;
            CityId = cityId;
            Name = name;
            Color = color;
            MetroStations = metroStations;
        }
    }
}
