using System;
using System.Threading;
using System.Threading.Tasks;

namespace FlareSolverrSharp.Utilities
{
    public class SemaphoreLocker
    {
        private readonly SemaphoreSlim semaphore = new SemaphoreSlim(1, 1);

        public async Task LockAsync<T>(Func<T> worker)
            where T : Task
        {
            await semaphore.WaitAsync();
            try
            {
                await worker();
            }
            finally
            {
                semaphore.Release();
            }
        }
    }
}