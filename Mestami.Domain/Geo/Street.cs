using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mestami.Domain.Geo
{
    public class Street
    {
        public int Id { get; private set; }

        public int CityId { get; private set; }

        public string Name { get; private set; }


        public Street(int id, int cityId, string name)
        {
            Id = id;
            CityId = cityId;
            Name = name;
        }
    }
}
