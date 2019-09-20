using System;
using System.Collections.Concurrent;
using System.Diagnostics;

namespace EFXamarin
{
    public static class Profiler
    {
        static readonly ConcurrentDictionary<string, Stopwatch> watches = new ConcurrentDictionary<string, Stopwatch>();

        public static void Start(object view)
        {
            Start(view.GetType().Name);
        }

        public static void Start(string tag)
        {
            Console.WriteLine("Starting Stopwatch {0}", tag);

            var watch =
                watches[tag] = new Stopwatch();
            watch.Start();
        }

        public static void Stop(string tag)
        {
            Stopwatch watch;
            if (watches.TryGetValue(tag, out watch))
            {
                Console.WriteLine("Stopwatch {0} took {1}", tag, watch.Elapsed);
            }
        }
    }
}