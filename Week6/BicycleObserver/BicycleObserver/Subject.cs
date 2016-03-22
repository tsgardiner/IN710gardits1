using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicycleObserver
{
    public class BicycleSubject : ISubject
    {
        List<IObserver> bicycleList;
        int data;

        public int Data
        {
            get { return data; }
            set { data = value; }
        }

        public BicycleSubject(int data)
        {
            bicycleList = new List<IObserver>();
            this.data = data;
        }

        public void AddObserver(IObserver o)
        {
            bicycleList.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            bicycleList.Remove(o);
        }

        public void NotifyObservers()
        {
            foreach (BicycleObserver item in bicycleList)
            {
                item.Update(data);
            }
        }
    }
}
