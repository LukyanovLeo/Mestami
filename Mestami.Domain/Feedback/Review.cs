using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mestami.Domain.Feedback
{
    public class Review
    {
        // TODO: user avatar

        public int UserId { get; private set; }

        public string UserName { get; private set; }

        public UserRating UserRating { get; private set; }

        public string Text { get; set; }

        public DateTime CreatedAt { get; }

        public DateTime UpdatedAt { get; private set; }
    }
}
