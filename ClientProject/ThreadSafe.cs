﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PongGame
{
    public class ThreadSafe<T>
    {
        // The data & lock
        private T _value;
        private object _lock = new object();

        // How to get & set the data
        public T Value
        {
            get
            {
                lock (_lock)
                    return _value;
            }

            set
            {
                lock (_lock)
                    _value = value;
            }
        }

        // Initializes the value
        public ThreadSafe(T value = default(T))
        {
            Value = value;
        }
    }
}