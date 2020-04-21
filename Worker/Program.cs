using System;
using System.Threading;
using System.Threading.Tasks;
using GameFramework;
using GameFramework.Characters;
namespace Worker
{
    class Program
    {
        static void Main(string[] args)
        {
            World wl = new World(32, 25);
            Parallel.Invoke((() => new Thread(wl.playerMovementHandler).Start()));

            Console.ReadLine();


        }
    }
}
