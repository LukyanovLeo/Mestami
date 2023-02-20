using Mestami.Domain.Enums;
using Mestami.Domain.Feedback;
using Mestami.Domain.Geo;

namespace Mestami.Domain.Aggregates.PlaceAggregate.Place
{
    public class LoungeBar : ILoungeBar
    {
        public int Id { get; set; }

        public string City { get; set; }

        public string Title { get; set; }

        public string Address { get; set; }

        public int Quality { get; set; }

        public string ApproxPrice { get; set; }

        public string VipRoomInfo { get; set; }

        public string Pros { get; set; }

        public string Cons { get; set; }


        public void AddComment(string text)
        {
            throw new NotImplementedException();
        }

        public void AddReview(string review)
        {
            throw new NotImplementedException();
        }

        public void EditComment(Comment comment)
        {
            throw new NotImplementedException();
        }

        public void EditReview(Review review)
        {
            throw new NotImplementedException();
        }

        public void Vote(Scores rating)
        {
            throw new NotImplementedException();
        }
    }
}
