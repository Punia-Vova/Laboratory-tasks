using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Папа_мама
{
    class PapaMama
    {
        public static int num_of_repeats;
        private int _delay;
        private int _repeats;
        private string _message;
        public static object lo = new object();
        public PapaMama(string message, int repeats, int delay)
        {
            this._delay = delay;
            this._repeats = repeats;
            this._message = message;
        }

        public void Say()
        {
            int i = 0;
            while (true)
            {
                lock (lo)
                {
                    if (i < _repeats & num_of_repeats > 0)
                    {
                        Console.WriteLine(_message);
                        num_of_repeats--;
                    }
                }
                if (i >= _repeats | num_of_repeats <= 0)
                    break;
                i++;
                Thread.Sleep(_delay);
            }
        }
    }
}