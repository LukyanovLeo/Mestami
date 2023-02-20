using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mestami.Domain.Feedback
{
    public abstract class Feedback
    {
        int UserId;

        string UserName;

        string Text;

        DateTime CreatedAt;

        DateTime UpdatedAt;
    }
}
