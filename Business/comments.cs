using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class comments 
    {
        List<icomments> observerList;
        public comments()
        {
            observerList = new List<icomments>();
        }
        void AddObserver(icomments observer)
        {
            observerList.Add(observer);
        }
        void NotifyObserver(string comment)
        {
            foreach (var observer in observerList)
            {
                observer.NotifyObserver(comment);
            }
        }


        void RemoveObserver(icomments observer)
        {
            observerList.Remove(observer);
        }
    }
}     
