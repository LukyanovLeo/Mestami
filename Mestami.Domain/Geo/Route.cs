using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mestami.Domain.Geo
{
    public class Route
    {
        public Guid Id { get; set; }

        public Address Start { get; set; }

        public Address End { get; set; }
    }
}
