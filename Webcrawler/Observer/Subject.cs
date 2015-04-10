﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webcrawler.Observer
{
    public interface Subject
    {
        void RegisterObserver(Observer subscriber);
        void UnregisterObserver(Observer unsubscriber);
        void NotifyObservers(Observer observer);
    }
}
