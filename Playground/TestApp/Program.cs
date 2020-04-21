using Playground;
using System;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MemoryManagement.AllocateAndCleanupLargeMemory();
            var totalMemory = GC.GetTotalMemory(true); // all returned to normal
        }
    }
}
