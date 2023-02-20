using Mestami.Domain.Enums;
using Mestami.Domain.Feedback;
using Mestami.Domain.Geo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mestami.Domain.Aggregates.PlaceAggregate.Place
{
    public interface IPlace
    {
        void AddComment(string comment);

        void EditComment(Comment comment);

        void AddReview(string review);

        void EditReview(Review review);

        void Vote(Scores rating);
    }
}
