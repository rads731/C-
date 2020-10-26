using System;

namespace StopWatch
{
    class StopWatch
    {
        private DateTime t1=DateTime.Now;

        public DateTime Start() { return t1; }
        public DateTime Stop() { return t1; }

    }
}
