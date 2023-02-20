using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mestami.Domain.Feedback
{
    public class UserRating
    {
        public int Id { get; }

        public UserRatings Rating { get; private set; }


        public UserRating(int id, UserRatings rating)
        {
            Id = id;
            Rating = rating;
        }
    }

    public enum UserRatings
    {
        Newbee,
        Experienced,
        Master,
        Guru,
    }
}
