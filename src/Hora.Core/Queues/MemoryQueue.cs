﻿using System;
using System.Collections.Generic;

namespace Hora.Core.Queues
{
    public static class MemoryQueue
    {
       
        private static int _currentIndex;
        private static int _lastIndex;
        private static bool _processing;

        private static List<object> _queue = new List<object>();

        public static void Enqueue<T>(Func<T> p)
        {
            var x = p();
            _queue.Add(p);
        }

        public static void ProcessQueue()
        {
            
        }
    }
}
