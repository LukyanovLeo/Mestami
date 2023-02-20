using Mestami.Domain.Models.Geo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mestami.Domain.Geo
{
    public class Address
    {
        public Guid Id { get; private set; }

        public int CityId { get; private set; }

        public HashSet<int> MetroStationIds { get; private set; } = new HashSet<int>();

        public int StreetId { get; private set; }

        public string HouseNumber { get; private set; }


        public Address(Guid id, int cityId, HashSet<int> metroStationIds, int streetId, string houseNumber)
        {
            Id = id;
            CityId = cityId;
            MetroStationIds = metroStationIds;
            StreetId = streetId;
            HouseNumber = houseNumber;
        }
    }
}
