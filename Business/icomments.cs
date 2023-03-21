using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public interface icomments
    {
        void AddObserver(icomments observer);
        void RemoveObserver(icomments observer);
        void NotifyObserver(string comment);

    }
}
