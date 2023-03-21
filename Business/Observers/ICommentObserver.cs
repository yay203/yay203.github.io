using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Observers
{
    public interface ICommentObserver
    {
        void Notify(string comment);
    }
}
