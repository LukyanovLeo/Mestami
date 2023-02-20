using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mestami.Infrastructure.Requests
{
    public class GetLoungeBarsByFilterRequest
    {
        public string City { get; set; }

        public string Title { get; set; }

        public string Address { get; set; }

        public string MetroStation { get; set; }
    }
}
