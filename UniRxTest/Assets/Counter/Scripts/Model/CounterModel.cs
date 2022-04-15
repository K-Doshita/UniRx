using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UniRx;

namespace Counter.Model
{
    public class CounterModel
    {
        private int _count = 0;

        private Subject<int> countValueSubject = new Subject<int>();

        public void OnCountValue()
        {
            AddCount();
            countValueSubject.OnNext(_count);
        }

        public IObservable<int> OnCountValueObservable()
        {
            return countValueSubject.AsObservable();
        }

        private void AddCount()
        {
            _count++;
        }
    }
}
