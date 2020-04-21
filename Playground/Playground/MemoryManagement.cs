using System;

namespace Playground
{
    public class MemoryManagement
    {
        public static void AllocateAndCleanupLargeMemory()
        {
            var heap = new byte[2][];

            // allocate two 2GB array
            // observe memory consumption
            for (var i = 0; i < heap.GetLength(0); i++)
            {
                heap[i] = new byte[2147483591]; // a bit less than int.MaxValue
            }

            // dereference heap
            for (var i = 0; i < heap.GetLength(0); i++)
            {
                heap[i] = null;
            }

            heap = null;
           
            var totalMemory = GC.GetTotalMemory(false); // observe memory consumption
        }
    }
}
